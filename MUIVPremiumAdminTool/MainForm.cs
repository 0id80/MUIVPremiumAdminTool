using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUIVPremiumAdminTool
{
    
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Метод загрузки формы
        private void MainForm_Load(object sender, EventArgs e)
        {
            notifyIcon.Text = "MUIVPremiumAdminTool";
        }

        private void NotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon.Visible = true;
            }
            else if (FormWindowState.Normal == this.WindowState)
            { notifyIcon.Visible = false; }
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {

        }

        // Метод обработки нажатия на кнопку "Закрыть"
        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // TabControl
        // Методы отвечающие за отключение фокуса на вкладках
        private void tabControl_Click(object sender, EventArgs e)
        {
            //(sender as TabControl).SelectedTab.Focus();
        }

        private void tabControl_Enter(object sender, EventArgs e)
        {
            //(sender as TabControl).SelectedTab.Focus();
        }

        private void HRDepartamentControl_Click(object sender, EventArgs e)
        {
            //(sender as TabControl).SelectedTab.Focus();
        }

        private void HRDepartamentControl_Enter(object sender, EventArgs e)
        {
            //(sender as TabControl).SelectedTab.Focus();
        }
    }
}
