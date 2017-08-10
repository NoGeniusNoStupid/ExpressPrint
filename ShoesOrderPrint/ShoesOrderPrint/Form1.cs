using ShoesOrderPrint.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TX.Framework.WindowUI.Forms;

namespace ShoesOrderPrint
{
    public partial class Form1 : BaseForm
    {

        public DialogResult myDialogResult = DialogResult.No;

        public Form1()
        {
            InitializeComponent();
        }

       
        //确定
        private void txButton1_Click_1(object sender, EventArgs e)
        {
            myDialogResult = DialogResult.OK;
            //ExpressMain myMain = new ExpressMain();
            //myMain.Show();
            this.Close();         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CommonBLL myCommonBLL = new CommonBLL();
            myCommonBLL.SetCenterScreen(this);

            SoftReg softReg = new SoftReg();
            string CpuId = softReg.getCpu();
            if (!string.IsNullOrEmpty(CpuId))
            {
                txTextBox1.Text = CpuId;
                txTextBox1.ReadOnly = true;
            }
        }

    }
}
