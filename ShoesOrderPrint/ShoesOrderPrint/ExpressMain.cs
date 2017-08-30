using HJ.SQLiteBackup;
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
    public partial class ExpressMain : BaseForm
    {
        public ExpressMain()
        {
            InitializeComponent();
        }

        private void txButton1_Click(object sender, EventArgs e)
        {
            try
            {
                ExpressOrder myFrom = new ExpressOrder();
                myFrom.ShowDialog();
            }
            catch (Exception ex)
            {

                this.Warning(ex.Message);
            }
        }

        private void txButton2_Click(object sender, EventArgs e)
        {
            try
            {
                ExpressManage myFrom = new ExpressManage();
                myFrom.ShowDialog();

            }
            catch (Exception ex)
            {

                this.Warning(ex.Message);
            }
        }

        private void txButton4_Click(object sender, EventArgs e)
        {
            try
            {
                FrmPrintItemConfig myForm = new FrmPrintItemConfig();
                myForm.ShowDialog();
            }
            catch (Exception ex)
            {

                this.Warning(ex.Message);
            }
        }

        private void ExpressMain_Load(object sender, EventArgs e)
        {
            CommonBLL myCommonBLL = new CommonBLL();
            myCommonBLL.SetCenterScreen(this);
        }
        //数据备份
        private void t_btn_DataBackup_Click(object sender, EventArgs e)
        {
            try
            {
                string path = System.AppDomain.CurrentDomain.BaseDirectory;
                BackUpModel model = new BackUpModel();
                model.destDBFileName = path + @"DataBase\SHOEDB.db";
                model.backupDBFileName = path + string.Format(@"BuckUp\SHOEDB_{0}.db",DateTime.Now.ToShortDateString());
                BackUpDateBase myBackUpDateBase = new BackUpDateBase();
                myBackUpDateBase.Initializae(model);
                myBackUpDateBase.BackupDB();
                this.Info("备份成功！");
            }
            catch (Exception ex)
            {

                this.Warning(ex.Message);
            }
           
        }
        //打印机配置
        private void t_btn_Printer_Click(object sender, EventArgs e)
        {
            FrmPrinterSetting myForm = new FrmPrinterSetting();
            myForm.ShowDialog();
        }
        //快递单号配置
        private void t_btn_ExpressNoConfig_Click(object sender, EventArgs e)
        {
            FrmExpressNumConfig myForm = new FrmExpressNumConfig();
            myForm.ShowDialog();
        }
    }
}
