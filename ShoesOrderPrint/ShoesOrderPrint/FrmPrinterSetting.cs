using ShoesOrderPrint.BLL;
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
    public partial class FrmPrinterSetting : BaseForm
    {
        public FrmPrinterSetting()
        {
            InitializeComponent();
        }
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
                foreach (string pName in printName)
                {
                    t_cmg_PrinterName.Items.Add(pName);
                }
                t_cmg_PrinterName.SelectedIndex = 0;
            }
            catch (Exception ex)
            {

                this.Warning(ex.Message);
            }
        }

       
    }
}
