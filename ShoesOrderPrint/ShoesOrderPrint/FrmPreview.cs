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
    public partial class FrmPreview : Form
    {
        public FrmPreview()
        {
            InitializeComponent();
        }

        private void FrmPreview_FormClosing(object sender, FormClosingEventArgs e)
        {
            //CommonBLL m_CommonBLL = new CommonBLL();
            //m_CommonBLL.InitialControl(this.Controls);
        }

        private void txButton1_Click(object sender, EventArgs e)
        {
            CommonBLL m_CommonBLL = new CommonBLL();
            m_CommonBLL.InitialControl(this.Controls);
        }
    }
}
