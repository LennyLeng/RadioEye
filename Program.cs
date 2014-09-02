using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;

namespace RadioEye
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            StringBuilder szDevice = new StringBuilder();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Start(ref szDevice));
            Application.Run(new Main(szDevice.ToString()));
        }
    }
}
