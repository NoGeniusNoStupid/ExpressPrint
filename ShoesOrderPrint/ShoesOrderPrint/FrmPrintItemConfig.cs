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
    public partial class FrmPrintItemConfig : BaseForm
    {
        #region 字段
        /// <summary>
        /// 打印项配置管理类
        /// </summary>
        private ExpressItemConfigBLL ItemConfig = new ExpressItemConfigBLL();
        /// <summary>
        /// 通用方法管理类
        /// </summary>
        CommonBLL m_CommonBLL = new CommonBLL();
        #endregion

        #region 构造函数
        public FrmPrintItemConfig()
        {
            InitializeComponent();
        }
        #endregion

        #region 事件
        //页面加载
        private void FrmPrintItemConfig_Load(object sender, EventArgs e)
        {
            try
            {
                t_dgv_Data.AutoGenerateColumns = false;//不添加额外列
                t_dgv_Data.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//列头居中
                //设置快递类型
                List<MPrintMain> myList = m_CommonBLL.GetPrintMainSource();
                foreach (MPrintMain item in myList)
                {
                    txComboBox1.Items.Add(item.TemplateName);
                }
                t_cmg_Font.SelectedIndex = 0;
                t_cmg_FontSize.SelectedIndex = 0;
                txComboBox1_SelectedIndexChanged(null, null);
                             
            }
            catch (Exception ex)
            {
                this.Warning(ex.Message);
            }
        }     
        //预览
        private void t_btn_Preview_Click(object sender, EventArgs e)
        {
            try
            {
                 List<MExpressItemConfig> myList = t_dgv_Data.DataSource as List<MExpressItemConfig>;
                
                 if (txComboBox1.SelectedIndex == -1)
                 {
                     this.Info("请先选择打印模板！");
                     return;
                 }
                 CommonBLL commonBLL = new CommonBLL();
                 bool isUpdate= commonBLL.PrintPreview(txComboBox1.Text, myList);
                 if (isUpdate)
                 {
                    //刷新
                    txComboBox1_SelectedIndexChanged(null, null);
                 }
                
                
            }
            catch (Exception ex)
            {
                
                this.Warning(ex.Message);
            }
        }
        //保存配置
        private void t_btn_SaveConfig_Click(object sender, EventArgs e)
        {
              try
              {
                  List<MExpressItemConfig> myList = t_dgv_Data.DataSource as List<MExpressItemConfig>;
                  if (myList == null)
                      return;
                  //更新
                  foreach (MExpressItemConfig item in myList)
                  {
                      ItemConfig.Update(item);
                  }
                  this.Info("保存成功");
              }
              catch (Exception ex)
              {
                  this.Warning(ex.Message);
              }
        }        
        // 改变模板        
        private void txComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
              {
                  if (txComboBox1.SelectedIndex == -1)
                  {
                      txComboBox1.SelectedIndex = 0;
                  }
                  //绑定数据
                List<MExpressItemConfig> myList= m_CommonBLL.GetPrintItemConfig(txComboBox1.Text);
                t_dgv_Data.DataSource = myList;
                if (myList != null && myList.Count > 0)
                {
                    t_cmg_Font.Text = myList[0].Font;
                    t_cmg_FontSize.Text = myList[0].FontSize;
                    t_txt_Color.Text = myList[0].PrintColor;
                }


              }
            catch (Exception ex)
            {
                this.Warning(ex.Message);
            }
        }
        //输入数据出错时，取消操作
        private void t_dgv_PrintItemConfig_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                e.Cancel = false;
            }
            catch (Exception ex)
            {

                this.Warning(ex.Message);
            }
        }
        //颜色选择器
        private void t_btn_ColorSelect_Click(object sender, EventArgs e)
        {
            try
            {
                ColorDialog myColorDialog = new ColorDialog();
                myColorDialog.AllowFullOpen = false;
                myColorDialog.ShowDialog();
                t_txt_Color.Text = myColorDialog.Color.Name;
            }
            catch (Exception ex)
            {

                this.Warning(ex.Message);
            }
        }
        //保存模板配置
        private void t_btn_TemplateSava_Click(object sender, EventArgs e)
        {
            try
            {
                List<MExpressItemConfig> myList = t_dgv_Data.DataSource as List<MExpressItemConfig>;
                if (myList == null)
                    return;
                string color = "black";
                string font = "宋体";
                string fontSize = "8";

                font = t_cmg_Font.Text;
                fontSize = t_cmg_FontSize.Text;
                if (!string.IsNullOrEmpty(t_txt_Color.Text))
                {
                    color = t_txt_Color.Text;
                }
                //更新
                foreach (MExpressItemConfig item in myList)
                {
                    item.PrintColor = color;
                    item.Font = font;
                    item.FontSize = fontSize;
                    ItemConfig.Update(item);
                }
                this.Info("保存成功");
                //刷新
                txComboBox1_SelectedIndexChanged(null, null);
            }
            catch (Exception ex)
            {

                this.Warning(ex.Message);
            }
        }
        #endregion

        #region 方法
       
      
        #endregion

        
    }
}
