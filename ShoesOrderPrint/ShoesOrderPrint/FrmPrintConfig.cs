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
    public partial class FrmPrintConfig : BaseForm
    {
        public FrmPrintConfig()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ImagePath=AppDomain.CurrentDomain.BaseDirectory+@"BackImage\圆通.jpg";
            Image backImg = Image.FromFile(ImagePath);
            FrmPreview mFrmPreview = new FrmPreview();
            mFrmPreview.Width = backImg.Width+30;
            mFrmPreview.Height = backImg.Height+30;
            mFrmPreview.BackgroundImage = backImg;
            mFrmPreview.Controls.Add(CreateTextBox(250,20,115,120,"宋体",9));
            mFrmPreview.Controls.Add(CreateTextBox(250, 40, 120, 180, "宋体",8));
            mFrmPreview.ShowDialog();

           
            
        }

        /// <summary>
        /// 创建配置项
        /// </summary>
        /// <returns></returns>
        private TXTextBox CreateTextBox(int width, int heigth, int x, int y, string font,int fontSize)
        {
              TXTextBox myTextBox=new TXTextBox();
              myTextBox.Multiline = true; 
              myTextBox.Size = new Size(width, heigth);
              myTextBox.Location = new Point(x, y);
              myTextBox.Font = new Font(new FontFamily(font), fontSize);
              return myTextBox;
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

       
    }
}
