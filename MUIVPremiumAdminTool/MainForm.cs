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
    
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        // Метод загрузки формы
        private void mainForm_Load(object sender, EventArgs e)
        {
        }

        //Сворачивание в трей
        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Visible == true && this.notifyIcon.Visible == false)
            {
                e.Cancel = true;
                this.Hide();
                this.notifyIcon.Visible = true;
            }
        }

        //Нажатия по трею
        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Show();
                this.notifyIcon.Visible = false;
            }
            if (e.Button == MouseButtons.Right)
            {
                this.contextMenuStrip.Show();
            }
        }

        //Закрытие из контекстного меню
        private void closeToolStripMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // TabControl
        // Методы отвечающие за отключение фокуса на вкладках
        private void mainTabControl_Click(object sender, EventArgs e)
        {
            (sender as TabControl).SelectedTab.Focus();
        }

        private void mainTabControl_Enter(object sender, EventArgs e)
        {
            (sender as TabControl).SelectedTab.Focus();
        }

        private void hrDeptTabControl_Click(object sender, EventArgs e)
        {
            (sender as TabControl).SelectedTab.Focus();
        }

        private void hrDeptTabControl_Enter(object sender, EventArgs e)
        {
            (sender as TabControl).SelectedTab.Focus();
        }
    }
}
