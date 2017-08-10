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
                t_dgv_PrintItemConfig.AutoGenerateColumns = false;//不添加额外列
                t_dgv_PrintItemConfig.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//列头居中
                //设置快递类型
                List<MPrintMain> myList = m_CommonBLL.GetPrintMainSource();
                foreach (MPrintMain item in myList)
                {
                    txComboBox1.Items.Add(item.TemplateName);
                }

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
                 List<MExpressItemConfig> myList = t_dgv_PrintItemConfig.DataSource as List<MExpressItemConfig>;
                
                 if (txComboBox1.SelectedIndex == -1)
                 {
                     this.Info("请先选择打印模板！");
                     return;
                 }
                 CommonBLL commonBLL = new CommonBLL();
                 commonBLL.PrintPreview(txComboBox1.Text, myList);
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
                  List<MExpressItemConfig> myList = t_dgv_PrintItemConfig.DataSource as List<MExpressItemConfig>;
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
                  t_dgv_PrintItemConfig.DataSource = m_CommonBLL.GetPrintItemConfig(txComboBox1.Text);  
              }
            catch (Exception ex)
            {
                this.Warning(ex.Message);
            }
        }
        #endregion

        private void t_dgv_PrintItemConfig_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

                this.Warning(ex.Message);
            }
        }

        #region 方法
       
      
        #endregion

        
    }
}
