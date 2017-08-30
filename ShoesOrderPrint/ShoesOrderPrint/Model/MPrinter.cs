// ===============================================================================
// 项目名称  :    ShoesOrderPrint.Model
// 项目描述  :    
// ===============================================================================
// 类名称    :    MPrinter
// 类描述    :    
// 创建作者  :    DESKTOP-BTQS5T7/姜华健
// 创建时间  :    2017-8-30 15:16:16
// ===============================================================================
// Copyright © 榕基软件 2015 . All rights reserved.
// ===============================================================================


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesOrderPrint.Model
{
    /// <summary>
    /// 打印机维护类
    /// </summary>
    public class MPrinter
    {
        public MPrinter()
        {

        }
        /// <summary>
        /// UUID
        /// </summary>
        public string UUID { get; set; }
        /// <summary>
        /// Printer
        /// </summary>
        public string Printer { get; set; }
        /// <summary>
        /// PrintFoward
        /// </summary>
        public string PrintFoward { get; set; }
        /// <summary>
        /// PrintNum
        /// </summary>
        public int PrintNum { get; set; }
        /// <summary>
        /// LeftAway
        /// </summary>
        public decimal LeftAway { get; set; }
        /// <summary>
        /// TopAway
        /// </summary>
        public decimal TopAway { get; set; }
        /// <summary>
        /// IniWeight
        /// </summary>
        public decimal IniWeight { get; set; }
        /// <summary>
        /// IniHeight
        /// </summary>
        public decimal IniHeight { get; set; }
        /// <summary>
        /// NowWeight
        /// </summary>
        public decimal NowWeight { get; set; }
        /// <summary>
        /// NowHeight
        /// </summary>
        public decimal NowHeight { get; set; }
        /// <summary>
        /// ExpressName
        /// </summary>
        public string ExpressName { get; set; }
    }
}
