// ===============================================================================
// 项目名称  :    ShoesOrderPrint.BLL
// 项目描述  :    
// ===============================================================================
// 类名称    :    GetPrinter
// 类描述    :    
// 创建作者  :    DESKTOP-BTQS5T7/姜华健
// 创建时间  :    2017-8-17 16:18:33
// ===============================================================================
// Copyright © 榕基软件 2015 . All rights reserved.
// ===============================================================================


using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesOrderPrint.BLL
{
    /// <summary>
    /// 获取所有打印机
    /// </summary>
    public class GetPrinter
    {
        #region 构造函数
        public GetPrinter()
        {

        }
        #endregion

        private static PrintDocument fPrintDocument = new PrintDocument();

        ///获取本地默认打印机名称
        ///</summary>
        public static string DefaultPrinter
        {
            get { return fPrintDocument.PrinterSettings.PrinterName; }
        }
        /// <summary>
        ///  获取本地打印机的列表，第一项就是默认打印机
        /// </summary>
        public static List<string> GetLocalPrinter()
        {
            List<string> fPrinters = new List<string>();
            fPrinters.Add(DefaultPrinter);  //默认打印机出现在列表的第一项
            foreach (string fPrinterName in PrinterSettings.InstalledPrinters)
            {
                if (!fPrinters.Contains(fPrinterName))
                    fPrinters.Add(fPrinterName);
            }
            return fPrinters;
        }

    }
}
