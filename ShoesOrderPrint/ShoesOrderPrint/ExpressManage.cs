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
    public partial class ExpressManage : BaseForm
    {
        /// <summary>
        /// 表示快递业务逻辑层
        /// </summary>
        private ExpressBLL m_ExpressBLL = new ExpressBLL();
        /// <summary>
        /// 显示列业务逻辑层
        /// </summary>
        private ColumnStyleBLL m_ColumnStyleBLL = new ColumnStyleBLL();
        public ExpressManage()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 是否界面加载
        /// </summary>
        bool isPageLoad = true;

        #region 事件
        /// <summary>
        /// 页面加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExpressManage_Load(object sender, EventArgs e)
        {
            try
            {
                t_dgv_Data.AutoGenerateColumns = false;//不添加额外列
                t_dgv_Data.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;//列头居中
                t_dgv_Data.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;  //自动调动datagridview的行高度
               
                t_txt_Search_Click(null, null);

                //设置显示列
                List<MColumnStyle> list = m_ColumnStyleBLL.QueryList("where Style_Name='Manage0101' order by Column_Index");
                if (list == null)
                    return;
                SetShowColumns(list);
               
            }
            catch (Exception ex)
            {

                this.Warning(ex.Message);
            }
        }
       
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void t_txt_Search_Click(object sender, EventArgs e)
        {
            try
            {
                //获取订单号
                string expressNo = t_txt_ExpressNo.Text;
                string expressNoSql = string.Empty;
                if (!string.IsNullOrEmpty(expressNo))
                    expressNoSql = string.Format("Express_No like '%{0}%'", expressNo);
                //获取日期选择
                string DateSql=string.Empty;
                if(txRadioButton1.Checked)
                    DateSql = string.Format(" date({0})=date('now')", "Expree_Date");//天
                if (txRadioButton2.Checked)
                    DateSql = string.Format(@"{0}>=datetime('now','start of day','-7 day','weekday 1') AND {0}<datetime('now','start of day','+0 day','weekday 1')", "Expree_Date");//周
                if (txRadioButton3.Checked)
                    DateSql = string.Format(" strftime('%Y.%m',{0})=strftime('%Y.%m','now')", "Expree_Date");//月
                if (!string.IsNullOrEmpty(DateSql)&&!string.IsNullOrEmpty(expressNo))
                    DateSql = "and" + DateSql;
                string sqlWhere = string.Empty;
                if (string.IsNullOrEmpty(DateSql) && string.IsNullOrEmpty(expressNo))
                {
                    sqlWhere = "order by Expree_Date";
                }
                else
                {
                    sqlWhere = string.Format("where {0} {1} {2}", expressNoSql, DateSql, "order by Expree_Date");
                }

                IEnumerable<MExpress> myList = m_ExpressBLL.QueryList(sqlWhere);

                List<MExpress> List = new List<MExpress>();
                foreach (MExpress m_Express in myList)
                {
                    if (m_Express.GoodsPic != null)
                    {
                        System.IO.MemoryStream ms = new System.IO.MemoryStream(m_Express.GoodsPic);
                        System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
                        Bitmap bmp = new Bitmap(img, 80, 40);
                        m_Express.MyGoodsPic = bmp;
                    }
                    List.Add(m_Express);
                }
                t_dgv_Data.DataSource = List;
            }
            catch (Exception ex)
            {
                
                this.Warning(ex.Message);
            }
        }
       
        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ExpressOrder myFrom = new ExpressOrder();
                myFrom.ShowDialog();
                //重新绑定数据
                t_txt_Search_Click(null, null);
            }
            catch (Exception ex)
            {
                this.Warning(ex.Message);
            }
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (t_dgv_Data.CurrentRow == null)
                    return;
                MExpress BList = this.t_dgv_Data.CurrentRow.DataBoundItem as MExpress;
                ExpressOrder myFrom = new ExpressOrder(BList.UUID,true);
                myFrom.ShowDialog();
                //重新绑定数据
                t_txt_Search_Click(null, null);
            }
            catch (Exception ex)
            {
                this.Warning(ex.Message);
            }
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (t_dgv_Data.CurrentRow == null)
                    return;
                MExpress BList = this.t_dgv_Data.CurrentRow.DataBoundItem as MExpress;
                ExpressOrder myFrom = new ExpressOrder(BList.UUID);
                myFrom.ShowDialog();
                //重新绑定数据
                t_txt_Search_Click(null, null);
            }
            catch (Exception ex)
            {
                this.Warning(ex.Message);
            }
        }

        private void 打印ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                this.Warning(ex.Message);
            }
        }

        //双击打开事件
        private void t_dgv_Data_DoubleClick(object sender, EventArgs e)
        {
            打开ToolStripMenuItem_Click(sender, e);

        }

        //删除事件
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
               DialogResult result= this.Question("确定要删除吗？");
               if (result != DialogResult.OK)
                   return;
               if (t_dgv_Data.SelectedRows == null)
                    return;
               DataGridViewSelectedRowCollection myRows = t_dgv_Data.SelectedRows;
               if (myRows == null)
                   return;                
               foreach (DataGridViewRow item in myRows)
               {
                   MExpress myExpress = item.DataBoundItem as MExpress;
                   m_ExpressBLL.Delete(myExpress.UUID);
               }

               this.Info("删除成功");

                //重新绑定数据
                t_txt_Search_Click(null, null);
                
            }
            catch (Exception ex)
            {
                this.Warning(ex.Message);
            }
        }
        /// <summary>
        /// 表示列宽发生改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void t_dgv_Data_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            try
            {
                if (isPageLoad)
                    return;
                //设置显示列
                List<MColumnStyle> list = m_ColumnStyleBLL.QueryList("where Style_Name='Manage0101' order by Column_Index");
                if (list == null)
                    return;
                //保存列宽
                foreach (DataGridViewColumn column in t_dgv_Data.Columns)
                {
                    if (!column.Visible)
                        continue;
                    foreach (MColumnStyle mColumnStyle in list)
                    {                   
                        if (column.HeaderText != mColumnStyle.ColumnCaption)
                            continue;
                        if (column.Width != mColumnStyle.ColumnWidth)
                        {
                            m_ColumnStyleBLL.Update(column.Width, column.HeaderText, "Manage0101");
                            return;
                        }                         
                    }  
                }
            }
            catch (Exception ex)
            {
                this.Warning(ex.Message);
            }
        }

        #endregion

        /// <summary>
        /// 维护列点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void t_btn_columns_Click(object sender, EventArgs e)
        {
            try
            {
                List<MColumnStyle> list = m_ColumnStyleBLL.QueryList("where Style_Name='Manage0101' order by Column_Index");
                if (list == null)
                    return;
                FrmColumns myFrmColumns = new FrmColumns(list);
                myFrmColumns.ShowDialog();
                SetShowColumns(list);
            }
            catch (Exception ex)
            {

                this.Warning(ex.Message);
            }
        }


        /// <summary>
        /// 设置显示列
        /// </summary>
        /// <param name="list"></param>
        private void SetShowColumns(List<MColumnStyle> list)
        {
            isPageLoad = true;

            foreach (DataGridViewColumn column in t_dgv_Data.Columns)
            {
                foreach (MColumnStyle mColumnStyle in list)
                {
                    if (column.HeaderText == mColumnStyle.ColumnCaption)
                    {
                        if (column.Width != mColumnStyle.ColumnWidth)
                            column.Width = mColumnStyle.ColumnWidth;
                        if (mColumnStyle.ColumnVisible == 0)
                            column.Visible = false;
                        else if (mColumnStyle.ColumnVisible == 1)
                            column.Visible = true;
                        break;
                    }
                }
            }

            isPageLoad = false;
        }

    }
}
