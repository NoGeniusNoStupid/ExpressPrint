using ShoesOrderPrint.BLL;
using ShoesOrderPrint.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TX.Framework.WindowUI.Controls;
using TX.Framework.WindowUI.Forms;

namespace ShoesOrderPrint
{
    public partial class FrmPrinterSetting : BaseForm
    {
        /// <summary>
        /// 表示打印机业务管理类
        /// </summary>
        PrinterBLL m_PrinterBLL = new PrinterBLL();
        /// <summary>
        /// 打印机对象
        /// </summary>
        public MPrinter m_Printer = new MPrinter();
        /// <summary>
        /// 配置结果
        /// </summary>
        public DialogResult result = DialogResult.Cancel;
        /// <summary>
        /// 提示信息
        /// </summary>
        ToolTip mToolTip ;

        #region 构造函数
        public FrmPrinterSetting()
        {
            InitializeComponent();
        }
        public FrmPrinterSetting(string exrpessType)
        {
            InitializeComponent();
            try
            {
                m_Printer = m_PrinterBLL.QueryModel(string.Format("where ExpressName='{0}'", exrpessType));
                if (m_Printer == null)
                {
                    m_Printer = new MPrinter();
                    m_Printer.PrintFoward = "竖向";
                    m_Printer.PrintNum = 1;
                    m_Printer.LeftAway = 0;
                    m_Printer.TopAway = 0;
                    m_Printer.IniWeight = 0;
                    m_Printer.IniHeight = 0;
                    m_Printer.NowWeight = 0;
                    m_Printer.NowHeight = 0;
                    m_Printer.ExpressName = exrpessType;
                }
                if (m_Printer.IniWeight == 0 || m_Printer.IniHeight == 0)
                {
                    string ImagePath = AppDomain.CurrentDomain.BaseDirectory + @"BackImage\{0}.jpg";
                    ImagePath = string.Format(ImagePath, exrpessType);
                    Image backImg = Image.FromFile(ImagePath);
                    m_Printer.IniWeight = backImg.Width * 10;
                    m_Printer.IniHeight = backImg.Height * 10;
                }
            }
            catch (Exception ex)
            {

                this.Warning(ex.Message);
            }
            
        }
        #endregion

        #region 事件

        //详细说明
        private void t_btn_Detail_Click(object sender, EventArgs e)
        {
            this.Info(@"1、连续进纸时，如果高度不准会越打越偏（偏上或偏下）

2、越打越偏上，请将纸张高度调大。

3、越打越偏下，请将纸张高度调小

4、请根据实际打印效果进行微调（精确到0.01毫米）

5、连续几十张、上百张之后，累积偏移会很明显，建议手动进纸
");
        }
        //页面加载
        private void FrmPrinterSetting_Load(object sender, EventArgs e)
        {
            try
            {            
                List<string> printName = GetPrinter.GetLocalPrinter();
                if (printName == null || printName.Count<=0)
                    return;
                //绑定打印机数据源
                foreach (string pName in printName)
                {
                    t_cmg_PrinterName.Items.Add(pName);
                }
                t_cmg_PrinterName.SelectedIndex = 0;
                //绑定数据
                if (!string.IsNullOrEmpty(m_Printer.Printer) && printName.Contains(m_Printer.Printer))
                     t_cmg_PrinterName.Text = m_Printer.Printer;
                t_cmg_PrintForward.Text = m_Printer.PrintFoward;
                t_num_PrintNum.Value = m_Printer.PrintNum;
                t_txt_TopAway.Text = m_Printer.TopAway.ToString();
                t_txt_LeftAway.Text = m_Printer.LeftAway.ToString();
                t_txt_IniWeight.Text = m_Printer.IniWeight.ToString();
                t_txt_IniHeight.Text = m_Printer.IniHeight.ToString();
                t_txt_NowWeight.Text = m_Printer.NowWeight.ToString();
                t_txt_NowHeight.Text = m_Printer.NowHeight.ToString();
            }
            catch (Exception ex)
            {

                this.Warning(ex.Message);
            }
        }
        //取消按钮
        private void t_btn_Cancel_Click(object sender, EventArgs e)
        {   
            //关闭窗体
            this.Close();
        }
        //确定
        private void t_btn_Save_Click(object sender, EventArgs e)
        {
            //校验
            if (string.IsNullOrEmpty(t_cmg_PrinterName.Text))
            {
                this.Warning("请先选择打印设备！");
                return; 
            }
            m_Printer.Printer = t_cmg_PrinterName.Text;
            m_Printer.PrintFoward = t_cmg_PrintForward.Text;
            int printNum = Convert.ToInt32(t_num_PrintNum.Value);
            if (printNum <= 0)
            {
                this.Warning("打印分数不能小于1份！");
                return; 
            }
            m_Printer.PrintNum = printNum;            
            m_Printer.TopAway = Convert.ToDecimal(t_txt_TopAway.Text);
            m_Printer.LeftAway = Convert.ToDecimal(t_txt_LeftAway.Text);
            m_Printer.IniWeight = Convert.ToDecimal(t_txt_IniWeight.Text);
            m_Printer.IniHeight = Convert.ToDecimal(t_txt_IniHeight.Text);            
            m_Printer.NowWeight = Convert.ToDecimal(t_txt_NowWeight.Text);
            m_Printer.NowHeight = Convert.ToDecimal(t_txt_NowHeight.Text);
            if (m_Printer.NowWeight < 0 || m_Printer.NowHeight < 0)
            {
                this.Warning("修正纸张的宽度和高度不能小于零！");
                return; 
            }
            //保存记录
            m_PrinterBLL.Update(m_Printer);
            result = DialogResult.OK;
            this.Close();
        }
        //文本框离开时触发
        private void t_txt_TopAway_Leave(object sender, EventArgs e)
        {
            TXTextBox mTextBox = sender as TXTextBox;
            if (mTextBox == null)
                return;
            //判断输入内容是否是数字
            if (!IsNumberic(mTextBox.Text))
            {
                mTextBox.Focus();
                if (mToolTip == null)
                    mToolTip = new ToolTip();
                mToolTip.ToolTipIcon = ToolTipIcon.Info;
                mToolTip.ToolTipTitle = "提示";               
                mToolTip.IsBalloon = true;
                mToolTip.UseFading = true;

                mToolTip.Show("此处只能输入数字！", mTextBox, new Point(2, mTextBox.Height), 0xbb8);
                mToolTip.Show("此处只能输入数字！", mTextBox, new Point(2, mTextBox.Height), 0xbb8);
            }
        }
        #endregion

        #region 方法
        /// <summary>
        /// 判断是否是数字
        /// </summary>
        /// <param name="oText"></param>
        /// <returns></returns>
        private bool IsNumberic(string oText)
        {
            try
            {
                Decimal var1 = Convert.ToDecimal(oText);
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

    }
}
