using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoesOrderPrint
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Form1 myFrom = new Form1();
            //myFrom.ShowDialog();
            //if (myFrom.myDialogResult == DialogResult.OK)
            //{
            //    Application.Run(new ExpressMain());
            //}
            Application.Run(new ExpressMain()); 
        }
    }
}
