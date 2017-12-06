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
    public partial class FrmColumns : BaseForm
    {
        /// <summary>
        /// 表示维护控件
        /// </summary>
        List<MColumnStyle> m_List;
        /// <summary>
        /// 维护列业务逻辑类
        /// </summary>
        ColumnStyleBLL m_ColumnStyleBLL = new ColumnStyleBLL();

        #region 构造函数
        public FrmColumns()
        {
            InitializeComponent();
        }
        public FrmColumns(List<MColumnStyle> myList)
        {
            //参数传递
            m_List = myList;
            InitializeComponent();
        }
        #endregion

        /// <summary>
        /// 页面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmColumns_Load(object sender, EventArgs e)
        {          
            int LocationY = 40;
            foreach (MColumnStyle columnStyle in m_List)
            {
                //创建CheckBox控件
                TXCheckBox myCheckBox = CreateCheckBox(columnStyle);
                myCheckBox.Location = new Point(this.Width/2-myCheckBox.Width/2, LocationY);
                this.Controls.Add(myCheckBox);
                LocationY += 30;
            }
        }


        /// <summary>
        /// 创建CheckBox
        /// </summary>
        /// <param name="columnStyle"></param>
        private TXCheckBox CreateCheckBox(MColumnStyle columnStyle)
        {
            TXCheckBox myCheckBox = new TXCheckBox();
            myCheckBox.BackColor = Color.Transparent;
            myCheckBox.Text = columnStyle.ColumnCaption;
            if (columnStyle.ColumnVisible == 1)
                myCheckBox.Checked = true;
            else
                myCheckBox.Checked = false;
            myCheckBox.Tag = columnStyle;
            return myCheckBox;
        }

        //保存
        private void txButton1_Click(object sender, EventArgs e)
        {
            try
            {
                //循环所有控件
                foreach (Control control in this.Controls)
                {
                    TXCheckBox myCheckBox = control as TXCheckBox;
                    if (myCheckBox == null)
                        continue;
                    MColumnStyle mColumnStyle = myCheckBox.Tag as MColumnStyle;
                    if (mColumnStyle == null)
                        continue;
                    int visible = 0;
                    if (myCheckBox.Checked)
                        visible = 1;
                    else
                        visible = 0;
                    if (visible != mColumnStyle.ColumnVisible)
                    {
                        mColumnStyle.ColumnVisible = visible;
                        m_ColumnStyleBLL.Update(mColumnStyle);
                    }                
                }
                this.Info("保存成功！");
                this.Close();
            }
            catch (Exception ex)
            {

                this.Warning(ex.Message);
            }
        }
    }
}
