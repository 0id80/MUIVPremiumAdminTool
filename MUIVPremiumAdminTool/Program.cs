using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

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

            Process current = Process.GetCurrentProcess();
            if (Process.GetProcessesByName(current.ProcessName).Length > 1)
            {
                string msg_title = $"{current.ProcessName} - Secondary launch of the application";
                string msg_message = "Данное прилложение уже запущено!\nИщите его в трее...";
                MessageBox.Show(msg_message, msg_title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
                return;
            }

            Application.Run(new mainForm());
        }
    }
}
