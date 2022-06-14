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
using MUIVPremiumAdminTool.Properties;

namespace MUIVPremiumAdminTool
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        // Метод перед загрузкой формы
        private void mainForm_Load(object sender, EventArgs e)
        {
            string access_level = IsAdminPrivileges ? "Администратор" : "Обычный пользователь";
            MessageBox.Show(access_level);
        }

        //Сворачивание в трей
        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Control.ModifierKeys != Keys.Shift && !InTray)
            {
                e.Cancel = true;
                CollapseToTray();
            }
        }

        //Нажатия по трею
        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ExpandFromTray();
            }
            if (e.Button == MouseButtons.Right)
            {
                notifyContextMenuStrip.Show();
            }
        }

        //Вызов настроек из контекстного меню
        private void settingsToolStripMenuButton_Click(object sender, EventArgs e)
        {
            ExpandFromTray();
            mainTabControl.SelectedTab = settingsPage;
        }

        //Закрытие из контекстного меню
        private void closeToolStripMenuButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Сохранение настроек
        private void saveSettingsButton_Click(object sender, EventArgs e)
        {
            Settings.Default.Save();
        }

        //Сброс настроек
        private void resetSettingsToDefaultButton_Click(object sender, EventArgs e)
        {
            string msg_title = "MUIVPremiumAdminTool - Reset Settings";
            string msg_question = "Вы действительно хотите сбросить все настройки к значениям по умолчанию?";
            DialogResult result = MessageBox.Show(msg_question, msg_title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Settings.Default.Reset();
            }
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
