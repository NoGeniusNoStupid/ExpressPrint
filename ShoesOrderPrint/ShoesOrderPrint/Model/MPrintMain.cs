// ===============================================================================
// 项目名称  :    ShoesOrderPrint.Model
// 项目描述  :    
// ===============================================================================
// 类名称    :    M
// 类描述    :    
// 创建作者  :    DESKTOP-BTQS5T7/姜华健
// 创建时间  :    2017-8-3 17:28:09
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
    public class MPrintMain
    {
        /// <summary>
        /// UUID
        /// </summary>
        public string UUID { get; set; }
        /// <summary>
        /// TemplateName
        /// </summary>
        public string TemplateName { get; set; }
        /// <summary>
        /// BackImage
        /// </summary>
        public string BackImage { get; set; }
        /// <summary>
        /// TemplateType
        /// </summary>
        public string TemplateType { get; set; }
    }
}
