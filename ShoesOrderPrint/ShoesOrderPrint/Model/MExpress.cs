using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesOrderPrint
{
    /// <summary>
    /// 表示快递单实体类
    /// </summary>
   public class MExpress
    {
       public string UUID
       {
           get;
           set;
       }
       public string ExpressNo
       {
           get;
           set;
       }
       public string ExpreeType
       {
           get;
           set;
       }
       public DateTime ExpreeDate
       {
           get;
           set;
       }
       public string SenderName
       {
           get;
           set;
       }
       public string SenderZipCode
       {
           get;
           set;
       }
       public string SenderAddress
       {
           get;
           set;
       }
       public string SenderCompanyName
       {
           get;
           set;
       }
       public string SenderPhone
       {
           get;
           set;
       }
       public string SenderTel
       {
           get;
           set;
       }
       public string ReceiveName
       {
           get;
           set;
       }
       public string ReceiveZipCode
       {
           get;
           set;
       }
       public string ReceiveAddress
       {
           get;
           set;
       }
       public string ReceiveCompanyName
       {
           get;
           set;
       }
       public string ReceivePhone
       {
           get;
           set;
       }
       public string ReceiveTel
       {
           get;
           set;
       }
       public byte[] GoodsPic
       {
           get;
           set;
       }
       public string GoodsName
       {
           get;
           set;
       }
       public string GoodsSize
       {
           get;
           set;
       }
       public string Sum
       {
           get;
           set;
       }
       public string IsStock
       {
           get;
           set;
       }
       public string IsPrint
       {
           get;
           set;        
       }
       public string SenderProvince
       {
           get;
           set;
       }
       public string SenderCity
       {
           get;
           set;
       }
       public string ReceiveProvince
       {
           get;
           set;
       }
       public string ReceiveCity
       {
           get;
           set;
       }
       public string Status
       {
           get;
           set;
       }
    }
}
