using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesOrderPrint.Model
{
    /// <summary>
    /// 快递单打印项配置类
    /// </summary>
   public class MExpressItemConfig
    {
        /// <summary>
        /// ItemID
        /// </summary>
        public string ItemID { get; set; }
        /// <summary>
        /// UUID
        /// </summary>
        public string UUID { get; set; }
        /// <summary>
        /// TemplateName
        /// </summary>
        public string TemplateName { get; set; }
        /// <summary>
        /// ItemlName
        /// </summary>
        public string ItemlName { get; set; }
        /// <summary>
        /// ItemlCode
        /// </summary>
        public string ItemlCode { get; set; }
        /// <summary>
        /// Wight
        /// </summary>
        public int Wight { get; set; }
        /// <summary>
        /// Helght
        /// </summary>
        public int Helght { get; set; }
        /// <summary>
        /// LeftAway
        /// </summary>
        public int LeftAway { get; set; }
        /// <summary>
        /// TopAway
        /// </summary>
        public int TopAway { get; set; }
        /// <summary>
        /// Font
        /// </summary>
        public string Font { get; set; }
        /// <summary>
        /// FontSize
        /// </summary>
        public string FontSize { get; set; }
        /// <summary>
        /// SeqNo
        /// </summary>
        public int SeqNo { get; set; }
        /// <summary>
        /// Visable
        /// </summary>
        public string Visable { get; set; }
        /// <summary>
        /// 打印颜色
        /// </summary>
        public string PrintColor { get; set; }
    }
}
