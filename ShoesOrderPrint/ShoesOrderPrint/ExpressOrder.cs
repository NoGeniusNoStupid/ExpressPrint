using ShoesOrderPrint.BLL;
using ShoesOrderPrint.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TX.Framework.WindowUI.Controls;
using TX.Framework.WindowUI.Forms;

namespace ShoesOrderPrint
{
    public partial class ExpressOrder : BaseForm
    {
        #region 构造函数
        public ExpressOrder()
        {
            InitializeComponent();
            this.Width = 570;
            this.Height = 645;
        }

        public ExpressOrder(string primaryId,bool isCopy = false)
        {
            InitializeComponent();
            this.Width = 570;
            this.Height = 645;
            this.PrimaryId = primaryId;
            this.IsCopy = isCopy;
        }
        #endregion

        #region 字段
        /// <summary>
        /// 实体对象
        /// </summary>
        MExpress m_Express;
        /// <summary>
        /// 业务逻辑层
        /// </summary>
        ExpressBLL mExpressBLL = new ExpressBLL();
        /// <summary>
        /// 业务主键
        /// </summary>
        string PrimaryId=string.Empty;
        /// <summary>
        /// 是否复制
        /// </summary>
        bool IsCopy = false;
        /// <summary>
        /// 表示通用的业务逻辑类
        /// </summary>
        CommonBLL mCommonBLL = new CommonBLL();
        /// <summary>
        /// 创建快递流水号管理对象
        /// </summary>
        ExpressNumBll m_ExpressItemConfigBLL = new ExpressNumBll();
       
        #endregion

        #region 方法
        /// <summary>
        /// 创建对象
        /// </summary>
        private void NewModel()
        {           
            m_Express = new MExpress();
            m_Express.UUID = Guid.NewGuid().ToString("N");
            m_Express.IsPrint = "未打印";
            m_Express.IsStock = "有货";
            m_Express.Status = "新建";
            m_Express.GoodsPic = null;
        }
        /// <summary>
        /// 复制快递单
        /// </summary>
        private void CopyExpress()
        {
            if (m_Express.Status == "新建")
            {
                this.Warning("当前订单尚未保存，无法进行复制操作！");
                return;
            }
            m_Express.UUID = Guid.NewGuid().ToString("N");
            m_Express.IsPrint = "未打印";
            m_Express.IsStock = "有货";
            m_Express.Status = "新建";
            m_Express.ExpressNo = string.Empty;
            t_txt_ExpressNum.Text = string.Empty;
            t_lbl_Status.Text = "状态：" + m_Express.Status;
            this.Info("复制成功！");
        }
        /// <summary>
        /// 保存之后
        /// </summary>
        /// <param name="affectRecrd"></param>
        private void SaveAfter(int affectRecrd)
        {
            if (affectRecrd != 0)
            {
                this.Info("保存成功！");
                t_lbl_Status.Text = "状态：" + m_Express.Status;
                t_txt_ExpressNum.Text = m_Express.ExpressNo;
            }
            else
            {
                this.Warning("保存失败");
                m_Express.Status = "新建";
            }
        }
        /// <summary>
        /// 加载界面数据
        /// </summary>
        private void LoadPageDate(string primaryId)
        {
            m_Express = mExpressBLL.QuerySingle(primaryId);

            t_txt_ExpressNum.Text = m_Express.ExpressNo;
            t_cmg_ExpressType.Text = m_Express.ExpreeType;
            if (m_Express.ExpreeDate!=null)
                t_dtp_ExpressDate.Value = Convert.ToDateTime(m_Express.ExpreeDate);
            t_txt_SenderName.Text = m_Express.SenderName;
            t_txt_SenderZipCode.Text = m_Express.SenderZipCode;
            t_txt_SenderAddress.Text = m_Express.SenderAddress;
            t_txt_SenderCompanyName.Text = m_Express.SenderCompanyName;
            t_txt_SenderPhone.Text = m_Express.SenderPhone;
            t_txt_SenderTel.Text = m_Express.SenderTel;
            t_txt_ReceiveName.Text = m_Express.ReceiveName;
            t_txt_ReceiveZipCode.Text = m_Express.ReceiveZipCode;
            t_txt_ReceiveAddress.Text = m_Express.ReceiveAddress;
            t_txt_ReceiveCompanyName.Text = m_Express.ReceiveCompanyName;
            t_txt_ReceivePhone.Text = m_Express.ReceivePhone;
            t_txt_ReceiveTel.Text = m_Express.ReceiveTel;
            t_txt_GoodsName.Text = m_Express.GoodsName;
            t_txt_GoodsSize.Text = m_Express.GoodsSize;
            t_txt_Sum.Text = m_Express.Sum;
            t_cmg_IsStock.Text = m_Express.IsStock;
            t_cmg_SenderPro.Text = m_Express.SenderProvince;
            t_cmg_SenderCity.Text = m_Express.SenderCity;
            t_cmg_ReceivePro.Text = m_Express.ReceiveProvince;
            t_cmg_ReceiveCity.Text = m_Express.ReceiveCity;
            t_lbl_Status.Text = "状态：" + m_Express.Status;
            if (m_Express.GoodsPic != null)
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream(m_Express.GoodsPic);
                System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
                Bitmap bmp = new Bitmap(img, 162, 91);
                t_pic_GoodsPic.Image = bmp;
            }
            //复制单证操作
            if (IsCopy)
            {
                t_tsm_Copy_Click(null, null);
            }
        }
        /// <summary>
        /// 设置二级城市联动
        /// </summary>
        private void SetSecondCity(TXComboBox myComboBox, string selectedItem)
        {
            myComboBox.Items.Clear();
            SQLiteDataReader myReader = mCommonBLL.GetCityDate(selectedItem);
            while (myReader.Read())
            {
                string name = myReader.GetString(myReader.GetOrdinal("CityName"));
                myComboBox.Items.Add(name);
            }
        }
        /// <summary>
        /// 保存前执行校验
        /// </summary>
        /// <param name="m_Express"></param>
        /// <returns></returns>
        private bool BeforeSave(MExpress m_Express)
        {
            bool isPass = true;
            if (string.IsNullOrEmpty(m_Express.ExpreeType))
            {
                this.Warning("请选择快递类型");
                return false;
            }
            //自动生成快递单号          
            string mExpressNo = m_ExpressItemConfigBLL.GetExpressNo(m_Express.ExpreeType);
            if (!string.IsNullOrEmpty(mExpressNo))
            {
                m_Express.ExpressNo = mExpressNo;
                t_txt_ExpressNum.Text = mExpressNo;
            }

            if (string.IsNullOrEmpty(m_Express.ExpressNo))
            {
                this.Warning("请输入快递单号");
                return false;
            }
            return isPass;
        }
        //更新流水号
        private void UpdateMaxNum(string expreeType)
        {
            m_ExpressItemConfigBLL.UpdateMaxNum(expreeType);
        }     
        #endregion

        #region 事件
        /// <summary>
        /// 界面加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExpressOrder_Load(object sender, EventArgs e)
        {
            try
            {
                //新建
                if(m_Express==null)
                  NewModel();
                //绑定下拉框               
                SQLiteDataReader myReader =  mCommonBLL.GetPromaryDate();
                while (myReader.Read())
                {
                    string name = myReader.GetString(myReader.GetOrdinal("ProName"));
                    t_cmg_ReceivePro.Items.Add(name);
                    t_cmg_SenderPro.Items.Add(name);
                }
                //设置快递类型
                List<MPrintMain> myList = mCommonBLL.GetPrintMainSource();
                foreach (MPrintMain item in myList)
                {
                    t_cmg_ExpressType.Items.Add(item.TemplateName);
                }
                //界面赋值
                if (!string.IsNullOrEmpty(PrimaryId))
                    LoadPageDate(PrimaryId);
            }
            catch (Exception ex)
            {
                this.Warning(ex.Message);
            }
        }

        /// <summary>
        /// 图片上传
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void t_btn_Upload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog myDialog = new OpenFileDialog();
                myDialog.Filter = "图片|*.jpg;*.png;*.jpeg";
                myDialog.RestoreDirectory = true;

                if (myDialog.ShowDialog() != DialogResult.OK)
                    return;             
                ///根据图片文件的路径使用文件流打开，并保存为byte[] 
                FileStream fs = new FileStream(myDialog.FileName, FileMode.Open);
                byte[] byData = new byte[fs.Length];
                fs.Read(byData, 0, byData.Length);
                fs.Close();
                m_Express.GoodsPic = byData;
                //图片
                Image img = Image.FromFile(myDialog.FileName);
                Bitmap bmp = new Bitmap(img, 162, 91);
                t_pic_GoodsPic.Image = bmp;
            }
            catch (Exception ex)
            {

                this.Warning(ex.Message);
            }


        }

        /// <summary>
        /// 表示下拉框选择改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void t_cmg_SenderPro_SelectedIndexChanged(object sender, EventArgs e)
        {
            TXComboBox myComboBox = sender as TXComboBox;
            if (sender == null || myComboBox.SelectedItem == null)
                return;
            switch (myComboBox.Name)
            {
                case "t_cmg_SenderPro":
                    SetSecondCity(t_cmg_SenderCity, myComboBox.SelectedItem.ToString());
                    break;
                case "t_cmg_ReceivePro":
                    SetSecondCity(t_cmg_ReceiveCity, myComboBox.SelectedItem.ToString());
                    break;
            }
        }

        #region 导航条事件
        /// <summary>
        /// 新建
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void t_tsm_New_Click(object sender, EventArgs e)
        {
            NewModel();
            t_txt_ExpressNum.Text = string.Empty;
            t_cmg_ExpressType.Text = string.Empty;
            t_dtp_ExpressDate.Value = DateTime.Now;
            t_txt_SenderName.Text = string.Empty;
            t_txt_SenderZipCode.Text = string.Empty;
            t_txt_SenderAddress.Text = string.Empty;
            t_txt_SenderCompanyName.Text = string.Empty;
            t_txt_SenderPhone.Text = string.Empty;
            t_txt_SenderTel.Text = string.Empty;
            t_txt_ReceiveName.Text = string.Empty;
            t_txt_ReceiveZipCode.Text = string.Empty;
            t_txt_ReceiveAddress.Text = string.Empty;
            t_txt_ReceiveCompanyName.Text = string.Empty;
            t_txt_ReceivePhone.Text = string.Empty;
            t_txt_ReceiveTel.Text = string.Empty;
            t_txt_GoodsName.Text = string.Empty;
            t_txt_GoodsSize.Text = string.Empty;
            t_txt_Sum.Text = string.Empty;
            t_cmg_IsStock.Text = string.Empty;
            t_pic_GoodsPic.Image = null;
            t_cmg_IsStock.Text = string.Empty;
            t_cmg_SenderPro.Text = string.Empty;
            t_cmg_SenderCity.Text = string.Empty;
            t_cmg_ReceivePro.Text = string.Empty;
        }
        /// <summary>
        /// 复制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void t_tsm_Copy_Click(object sender, EventArgs e)
        {
            CopyExpress();
        }      
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void t_tms_Save_Click(object sender, EventArgs e)
        {
            try
            {
                //获取值           
                m_Express.ExpressNo = t_txt_ExpressNum.Text;
                m_Express.ExpreeType = t_cmg_ExpressType.Text;
                if (t_dtp_ExpressDate.Value != null)
                    m_Express.ExpreeDate = Convert.ToDateTime(t_dtp_ExpressDate.Value);
                m_Express.SenderName = t_txt_SenderName.Text;
                m_Express.SenderZipCode = t_txt_SenderZipCode.Text;
                m_Express.SenderCompanyName = t_txt_SenderCompanyName.Text;
                m_Express.SenderPhone = t_txt_SenderPhone.Text;
                m_Express.SenderTel = t_txt_SenderTel.Text;
                m_Express.ReceiveName = t_txt_ReceiveName.Text;
                m_Express.ReceiveZipCode = t_txt_ReceiveZipCode.Text;
                m_Express.ReceiveCompanyName = t_txt_ReceiveCompanyName.Text;
                m_Express.ReceivePhone = t_txt_ReceivePhone.Text;
                m_Express.ReceiveAddress = t_txt_ReceiveAddress.Text;
                m_Express.SenderAddress = t_txt_SenderAddress.Text;
                m_Express.ReceiveTel = t_txt_ReceiveTel.Text;
                m_Express.GoodsName = t_txt_GoodsName.Text;
                m_Express.GoodsSize = t_txt_GoodsSize.Text;
                m_Express.Sum = t_txt_Sum.Text;
                m_Express.IsStock = t_cmg_IsStock.Text;              
                m_Express.SenderProvince = t_cmg_SenderPro.Text;
                m_Express.SenderCity = t_cmg_SenderCity.Text;
                m_Express.ReceiveProvince = t_cmg_ReceivePro.Text;
                m_Express.ReceiveCity = t_cmg_ReceiveCity.Text;
                //保存               
                if (m_Express.Status == "新建")//状态
                {
                   
                    if (!BeforeSave(m_Express))
                        return;
                    //校验是否已经存在
                    MExpress mExpress = mExpressBLL.QueryModel(string.Format("where Express_No='{0}'", m_Express.ExpressNo));
                    if (mExpress != null)
                    {

                       DialogResult result = this.Question("该快递单号已存在，是否继续保存！");
                       if (result != DialogResult.OK)
                           return;
                    }
                    m_Express.Status = "已保存";
                    //插入
                    int affectRecrd = mExpressBLL.Insert(m_Express);                    
                    SaveAfter(affectRecrd);
                    //更新流水号
                    UpdateMaxNum(m_Express.ExpreeType);
                }
                else
                {
                  
                    if (!BeforeSave(m_Express))
                        return;
                    //更新
                    int affectRecrd = mExpressBLL.Update(m_Express);
                    SaveAfter(affectRecrd);
                }
            }
            catch (Exception ex)
            {

                this.Warning(ex.Message); 
            }
          
        }
     
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void t_tsm_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = this.Question("确定要删除吗？");
                if (result != DialogResult.OK)
                    return;
                int affectRecrd = mExpressBLL.Delete(m_Express.UUID);
                if (affectRecrd != 0)
                {
                    t_tsm_New_Click(null, null);
                    this.Info("删除成功");
                }
            }
            catch (Exception ex)
            {

                this.Warning(ex.Message);
            }
        }
        /// <summary>
        /// 打开
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void t_tsm_Open_Click(object sender, EventArgs e)
        {

        }      
        /// <summary>
        /// 快速填制
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void t_tsm_QuickIn_Click(object sender, EventArgs e)
        {

            t_dtp_ExpressDate.Value = DateTime.Now;
            t_txt_SenderName.Text = "张三";
            t_txt_SenderZipCode.Text = "310000";
            t_txt_SenderAddress.Text = "浙江省杭州市西湖区文一路8888号801室";
            t_txt_SenderCompanyName.Text = "杭州ABC软件有限公司";
            t_txt_SenderPhone.Text = "0571-8888xxxx";
            t_txt_SenderTel.Text = "139571xxxxx";
            t_txt_ReceiveName.Text = "李四";
            t_txt_ReceiveZipCode.Text = "518000";
            t_txt_ReceiveAddress.Text = "广东省深圳市罗湖区深南中路9999号901室";
            t_txt_ReceiveCompanyName.Text = "深圳XYZ电子有限公司";
            t_txt_ReceivePhone.Text = "0755-8888xxxx";
            t_txt_ReceiveTel.Text = "139571xxxxx";
            t_txt_GoodsName.Text = string.Empty;
            t_txt_GoodsSize.Text = string.Empty;
            t_txt_Sum.Text = string.Empty;
            t_cmg_IsStock.Text = string.Empty;

        }
        //打印预览
        private void t_tsm_PrintPreview_Click(object sender, EventArgs e)
        {
            try
            {
                if (t_cmg_ExpressType.SelectedIndex == -1)
                 {
                     this.Info("请先选择快递类型！");
                     return;
                 }
                List<MExpressItemConfig> myList = mCommonBLL.GetPrintItemConfig(t_cmg_ExpressType.Text);
                if (myList == null)
                    return;

                mCommonBLL.PrintPreview(t_cmg_ExpressType.Text, myList);         
            }
            catch (Exception ex)
            {

                this.Warning(ex.Message);
            }
        }
        //打印配置
        private void t_tsm_PrintConfig_Click(object sender, EventArgs e)
        {
            FrmPrintItemConfig myForm = new FrmPrintItemConfig();
            myForm.ShowDialog();
        }
        /// <summary>
        /// 打印
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void t_tsm_PrintExpress_Click(object sender, EventArgs e)
        {
            try
            {                
                if (m_Express.Status == "新建")
                {
                    this.Info("当前快递单还未保存，请保存后再操作！");
                    return;
                }
                mCommonBLL.OnePrint(m_Express);
                
            }
            catch (Exception ex)
            {

                this.Warning(ex.Message);
            }
        }
        #endregion
        //查看按钮
        private void txButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (t_cmg_ExpressType.SelectedIndex==-1)
                {
                    this.Warning("请选择快递类型！");
                    return;
                }

                string ImagePath = AppDomain.CurrentDomain.BaseDirectory + @"BackImage\{0}.jpg";
                ImagePath = string.Format(ImagePath, t_cmg_ExpressType.Text);
                Image backImg = Image.FromFile(ImagePath);
                Bitmap bmp = new Bitmap(backImg, t_pic_Express.Width, t_pic_Express.Height);
                t_pic_Express.Image = bmp;


                if (txButton2.Text == "查看")
                {
                    txButton2.Text = "收缩";
                    this.Width = 1200;
                    this.Height = 645;
                }
                else
                {
                    txButton2.Text = "查看";
                    this.Width = 570;
                    this.Height = 645;
                }
            }
            catch (Exception ex)
            {

                this.Warning(ex.Message);
            }
        }
        //快递类型选择变更
        private void t_cmg_ExpressType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
        #endregion

    }
}
