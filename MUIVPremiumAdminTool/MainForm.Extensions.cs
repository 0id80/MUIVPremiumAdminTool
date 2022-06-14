using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;

namespace MUIVPremiumAdminTool
{
    partial class mainForm
    {
        private static bool IsAdminPrivileges
        {
            get
            {
                using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
                {
                    WindowsPrincipal principal = new WindowsPrincipal(identity);
                    return principal.IsInRole(WindowsBuiltInRole.Administrator);
                }
            }
        }

        private bool InTray
        {
            get 
            {
                return !Visible && notifyIcon.Visible;
            }
            set
            {
                Visible = !value;
                notifyIcon.Visible = value;
            }
        }

        private void CollapseToTray()
        {
            InTray = true;
        }

        private void ExpandFromTray()
        {
            InTray = false;
        }
    }
}
