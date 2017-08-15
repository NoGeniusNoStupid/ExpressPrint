// ===============================================================================
// 项目名称  :    ShoesOrderPrint
// 项目描述  :    
// ===============================================================================
// 类名称    :    CommonBLL
// 类描述    :    
// 创建作者  :    DESKTOP-BTQS5T7/姜华健
// 创建时间  :    2017-7-25 22:58:53
// ===============================================================================
// Copyright © 榕基软件 2015 . All rights reserved.
// ===============================================================================


using ShoesOrderPrint.BLL;
using ShoesOrderPrint.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TX.Framework.WindowUI.Controls;
using TX.Framework.WindowUI.Controls.HJTextBox;

namespace ShoesOrderPrint
{
    /// <summary>
    /// 表示通用查询的业务逻辑层
    /// </summary>
    public class CommonBLL
    {
        #region 字段
        /// <summary>
        /// 打印项配置管理类
        /// </summary>
        private ExpressItemConfigBLL m_ItemConfigBll = new ExpressItemConfigBLL();
        /// <summary>
        /// 表示打印项数据源
        /// </summary>
        List<MExpressItemConfig> m_List=new List<MExpressItemConfig>();
        /// <summary>
        /// 表示打印主表
        /// </summary>
        PrintMainBLL m_PrintMainBLL = new PrintMainBLL();
       
        #endregion

        #region 公开方法
        public CommonBLL()
        {

        }
        /// <summary>
        /// 设置省份
        /// </summary>
        /// <returns></returns>
        public SQLiteDataReader GetPromaryDate()
        {
            string sql = "select ProName from T_Promary order by ProID";
            return SqlHelper.ExecuteReader(CommandType.Text, sql);
        }
        /// <summary>
        /// 设置城市
        /// </summary>
        /// <param name="proName"></param>
        /// <returns></returns>
        public SQLiteDataReader GetCityDate(string proName)
        {
            string sql = string.Format("select CityName from T_City,T_Promary where T_City.ProID=T_Promary.ProID and T_Promary.ProName='{0}'", proName);
            return SqlHelper.ExecuteReader(CommandType.Text, sql);
        }
        /// <summary>
        /// 打印预览
        /// </summary>
        public bool PrintPreview(string templateName, List<MExpressItemConfig> myList)
        {
            if (myList == null||string.IsNullOrEmpty(templateName))
                return false;
            string ImagePath = AppDomain.CurrentDomain.BaseDirectory + @"BackImage\{0}.jpg";
            ImagePath = string.Format(ImagePath, templateName);
            Image backImg = Image.FromFile(ImagePath);
            FrmPreview mFrmPreview = new FrmPreview();
            mFrmPreview.Width = backImg.Width+20;
            mFrmPreview.Height = backImg.Height+30;
            mFrmPreview.BackgroundImage = backImg;
            mFrmPreview.MaximizeBox = false;

            foreach (MExpressItemConfig item in myList)
            {
                if (item.Visable == "是")
                {
                    mFrmPreview.Controls.Add(CreateTextBox(item));
                }
            }
            mFrmPreview.ShowDialog();
            return mFrmPreview.m_IsUpdate;
        }
        /// <summary>
        /// 表示获取打印项配置
        /// </summary>
        /// <param name="templateName"></param>
        /// <returns></returns>
        public List<MExpressItemConfig> GetPrintItemConfig(string templateName)
        {
            string sqlWhere = string.Format("where TemplateName='{0}' order by SeqNo", templateName);
            List<MExpressItemConfig> List = new List<MExpressItemConfig>();

            IEnumerable<MExpressItemConfig> myList = m_ItemConfigBll.QueryList(sqlWhere);
            if (myList == null)
                return null;
            foreach (MExpressItemConfig item in myList)
            {
                List.Add(item);
            }
            return List;
        }
        /// <summary>
        /// 表示获取打印数据源
        /// </summary>
        /// <param name="templateName"></param>
        public List<MExpressItemConfig> GetPrintResource(string templateName, MExpress mExpress)
        {
            List<MExpressItemConfig> myList = GetPrintItemConfig(templateName);
            var props = typeof(MExpress).GetProperties();//表示实体对象
            foreach (MExpressItemConfig ItemConfigModel in myList)
            {
                //获取名称
                string name = ItemConfigModel.ItemlCode;
                if (!string.IsNullOrEmpty(ItemConfigModel.TemplateName))
                    name = name.Replace("_","");
                //for (int i = 0; i < props.Length; i++)
                //{
                //    if (name == props[i].Name)
                //    {
                //        ItemConfigModel.ItemlName = props[i].GetValue(mExpress).ToString();
                //        break;
                //    }
                //}
                foreach (var prop in props)
                {
                    if (name == prop.Name)
                    {
                        ItemConfigModel.ItemlName = prop.GetValue(mExpress).ToString();
                        break;
                    }
                }
            }
            return myList;
        }
        /// <summary>
        /// 表示需要打印的数据源集合
        /// </summary>
        /// <param name="mList"></param>
        public void Print( string templateName,MExpress mExpress) 
        {
            if (mExpress == null || string.IsNullOrEmpty(templateName))
                return;
            m_List = GetPrintResource(templateName, mExpress);
            if (m_List == null)
                return;
            string ImagePath = AppDomain.CurrentDomain.BaseDirectory + @"BackImage\{0}.jpg";
            ImagePath = string.Format(ImagePath, templateName);
            Image backImg = Image.FromFile(ImagePath);
             //设置打印用的纸张 当设置为Custom的时候，可以自定义纸张的大小，还可以选择A4,A5等常用纸型
            PrintDocument mPrintDocument = new PrintDocument();
            mPrintDocument.PrintPage += mPrintDocument_PrintPage;
            mPrintDocument.DefaultPageSettings.PaperSize = new PaperSize("Custum", backImg.Width, backImg.Height);
            mPrintDocument.DefaultPageSettings.Landscape = true;
            mPrintDocument.Print();
        }
        /// <summary>
        /// 表示获取打印主表数据
        /// </summary>
        /// <param name="sqlWhere"></param>
        /// <returns></returns>
        public List<MPrintMain>  GetPrintMainSource(string sqlWhere="")
        {
            List<MPrintMain> myList = new List<MPrintMain>();
            IEnumerable<MPrintMain> IEList = m_PrintMainBLL.QueryList(sqlWhere);
            if (IEList == null)
                return myList;
            foreach (MPrintMain item in IEList)
            {
                myList.Add(item);
            }
            return myList;
        }
        /// <summary>
        /// 设置中间屏幕
        /// </summary>
        /// <param name="form"></param>
        public void SetCenterScreen(Form form)
        {
            int height = System.Windows.Forms.SystemInformation.WorkingArea.Height;
            int width = System.Windows.Forms.SystemInformation.WorkingArea.Width;
            int formheight = form.Size.Height;
            int formwidth = form.Size.Width;

            int newformx = width / 2 - formwidth / 2;
            int newformy = height / 2 - formheight / 2;

            form.SetDesktopLocation(newformx, newformy);
        }
        #endregion

        #region 私有方法
        /// <summary>
        /// 创建配置项
        /// </summary>
        /// <returns></returns>
        private TXTextBox CreateTextBox(MExpressItemConfig ItemConfig)
        {
            try
            {
                TXTextBox myTextBox = new TXTextBox();
                myTextBox.Name = ItemConfig.ItemlCode;
                myTextBox.Text = ItemConfig.ItemlName;
                myTextBox.IsCanDrag = true;
                myTextBox.Multiline = true;                             
                myTextBox.Size = new Size(ItemConfig.Wight, ItemConfig.Helght);
                myTextBox.Location = new Point(ItemConfig.LeftAway, ItemConfig.TopAway);
                myTextBox.Font = new Font(new FontFamily(ItemConfig.Font), Convert.ToInt32(ItemConfig.FontSize));
                myTextBox.Tag = ItemConfig;
                return myTextBox;

            }
            catch (Exception)
            {
                return new TXTextBox();
            }

        }

       
        /// <summary>
        /// 打印页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mPrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                foreach (MExpressItemConfig item in m_List)
                {
                    if (item.Visable != "是")
                        continue;
                   e.Graphics.DrawString(item.ItemlName, new Font(new FontFamily(item.Font),Convert.ToInt32(item.FontSize)), System.Drawing.Brushes.Black, item.LeftAway, item.TopAway);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                
            }
        }
        /// <summary>
        /// 选好遍历界面控件
        /// </summary>
        /// <param name="objControlCollection"></param>
        public void InitialControl(Control.ControlCollection controlCollection)
        {

            foreach (Control objControl in controlCollection)
            {                     
                    TXTextBox myTextBox = objControl as TXTextBox;
                    if (myTextBox == null)
                        continue;
                    MExpressItemConfig myItemConfig = myTextBox.Tag as MExpressItemConfig;
                    if (myItemConfig == null)
                        continue;
                    myItemConfig.LeftAway = myTextBox.Location.X;
                    myItemConfig.TopAway = myTextBox.Location.Y;
                    m_ItemConfigBll.Update(myItemConfig);
            }           
        }
        #endregion

      
    }
}
