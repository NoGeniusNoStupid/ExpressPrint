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
    public partial class FrmPreview : Form
    {
        /// <summary>
        /// 是否更新
        /// </summary>
        public bool m_IsUpdate = false;

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
            m_IsUpdate = true;
            CommonBLL m_CommonBLL = new CommonBLL();
            m_CommonBLL.InitialControl(this.Controls);

            MessageBox.Show("保存成功");
        }

        private void FrmPreview_Load(object sender, EventArgs e)
        {
           

        }
    }
}
