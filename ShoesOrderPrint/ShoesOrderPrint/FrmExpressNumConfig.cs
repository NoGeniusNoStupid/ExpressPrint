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
using TX.Framework.WindowUI.Forms;

namespace ShoesOrderPrint
{
    public partial class FrmExpressNumConfig : BaseForm
    {
        /// <summary>
        /// 创建快递流水号管理对象
        /// </summary>
        ExpressNumBll mExpressItemConfigBLL = new ExpressNumBll();

        public FrmExpressNumConfig()
        {
            InitializeComponent();
        }

        #region 事件
        //保存
        private void t_btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
               List<MExpressNum> myList = t_dgv_Data.DataSource as List<MExpressNum>;
               //更新
               foreach (MExpressNum mExpressNum in myList)
               {
                   mExpressItemConfigBLL.Update(mExpressNum);
               }
               this.Info("保存成功");
               //绑定数据源
               t_dgv_Data.DataSource = mExpressItemConfigBLL.QueryList(" order by ModuleId");

            }
            catch (Exception ex)
            {

                this.Warning(ex.Message);
            }
        }
        //取消
        private void t_btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //页面加载
        private void FrmExpressNumConfig_Load(object sender, EventArgs e)
        {
            try
            {
                t_dgv_Data.AutoGenerateColumns = false;//不添加额外列
                t_dgv_Data.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//列头居中
                //绑定数据源
                t_dgv_Data.DataSource = mExpressItemConfigBLL.QueryList(" order by ModuleId");
            }
            catch (Exception ex)
            {

                this.Warning(ex.Message);
            }
                   
        }

        private void t_dgv_Data_DataError(object sender, DataGridViewDataErrorEventArgs e)
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
        #endregion
    }
}
