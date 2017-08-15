// ===============================================================================
// 项目名称  :    ShoesOrderPrint.Model
// 项目描述  :    
// ===============================================================================
// 类名称    :    MColumnStyle
// 类描述    :    
// 创建作者  :    DESKTOP-BTQS5T7/姜华健
// 创建时间  :    2017-8-15 16:46:02
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
    public class MColumnStyle
    {
        /// <summary>
        /// ColumnId
        /// </summary>
        public string ColumnId { get; set; }
        /// <summary>
        /// StyleName
        /// </summary>
        public string StyleName { get; set; }
        /// <summary>
        /// ColumnName
        /// </summary>
        public string ColumnName { get; set; }
        /// <summary>
        /// ColumnCaption
        /// </summary>
        public string ColumnCaption { get; set; }
        /// <summary>
        /// ColumnType
        /// </summary>
        public int ColumnType { get; set; }
        /// <summary>
        /// ColumnIndex
        /// </summary>
        public int ColumnIndex { get; set; }
        /// <summary>
        /// ColumnWidth
        /// </summary>
        public int ColumnWidth { get; set; }
        /// <summary>
        /// ColumnVisible
        /// </summary>
        public int ColumnVisible { get; set; }
        /// <summary>
        /// UpdateSign
        /// </summary>
        public string UpdateSign { get; set; }
    }
}
