using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUIVPremiumAdminTool
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string filePath = "C:\\MUIVPremiumAdminTool\\settings.txt";
            if (!(File.Exists(filePath)))
            {
                Application.Run(new RegisterForm());
            }
            else
            {
                Application.Run(new MainForm());
            }
            }
    }
}
