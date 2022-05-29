using System.Drawing;

namespace MUIVPremiumAdminTool
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.ADSearchPage = new System.Windows.Forms.TabPage();
            this.HRDepartmentPage = new System.Windows.Forms.TabPage();
            this.HRDepartamentControl = new System.Windows.Forms.TabControl();
            this.GeneralUniversityPage = new System.Windows.Forms.TabPage();
            this.BranchesUniversityPage = new System.Windows.Forms.TabPage();
            this.InformationPage = new System.Windows.Forms.TabPage();
            this.SettingsPage = new System.Windows.Forms.TabPage();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl.SuspendLayout();
            this.HRDepartmentPage.SuspendLayout();
            this.HRDepartamentControl.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.ADSearchPage);
            this.tabControl.Controls.Add(this.HRDepartmentPage);
            this.tabControl.Controls.Add(this.InformationPage);
            this.tabControl.Controls.Add(this.SettingsPage);
            this.tabControl.Location = new System.Drawing.Point(-4, -1);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(493, 669);
            this.tabControl.TabIndex = 0;
            this.tabControl.Click += new System.EventHandler(this.tabControl_Click);
            this.tabControl.Enter += new System.EventHandler(this.tabControl_Enter);
            // 
            // ADSearchPage
            // 
            this.ADSearchPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ADSearchPage.ForeColor = System.Drawing.Color.White;
            this.ADSearchPage.Location = new System.Drawing.Point(4, 22);
            this.ADSearchPage.Name = "ADSearchPage";
            this.ADSearchPage.Padding = new System.Windows.Forms.Padding(3);
            this.ADSearchPage.Size = new System.Drawing.Size(485, 643);
            this.ADSearchPage.TabIndex = 0;
            this.ADSearchPage.Text = "ADский Поисковик";
            // 
            // HRDepartmentPage
            // 
            this.HRDepartmentPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HRDepartmentPage.Controls.Add(this.HRDepartamentControl);
            this.HRDepartmentPage.ForeColor = System.Drawing.Color.White;
            this.HRDepartmentPage.Location = new System.Drawing.Point(4, 22);
            this.HRDepartmentPage.Name = "HRDepartmentPage";
            this.HRDepartmentPage.Padding = new System.Windows.Forms.Padding(3);
            this.HRDepartmentPage.Size = new System.Drawing.Size(485, 643);
            this.HRDepartmentPage.TabIndex = 1;
            this.HRDepartmentPage.Text = "Отдел кадров";
            // 
            // HRDepartamentControl
            // 
            this.HRDepartamentControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HRDepartamentControl.Controls.Add(this.GeneralUniversityPage);
            this.HRDepartamentControl.Controls.Add(this.BranchesUniversityPage);
            this.HRDepartamentControl.Location = new System.Drawing.Point(-4, 0);
            this.HRDepartamentControl.Name = "HRDepartamentControl";
            this.HRDepartamentControl.SelectedIndex = 0;
            this.HRDepartamentControl.Size = new System.Drawing.Size(496, 647);
            this.HRDepartamentControl.TabIndex = 0;
            this.HRDepartamentControl.Click += new System.EventHandler(this.HRDepartamentControl_Click);
            this.HRDepartamentControl.Enter += new System.EventHandler(this.HRDepartamentControl_Enter);
            // 
            // GeneralUniversityPage
            // 
            this.GeneralUniversityPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.GeneralUniversityPage.Location = new System.Drawing.Point(4, 22);
            this.GeneralUniversityPage.Name = "GeneralUniversityPage";
            this.GeneralUniversityPage.Padding = new System.Windows.Forms.Padding(3);
            this.GeneralUniversityPage.Size = new System.Drawing.Size(488, 621);
            this.GeneralUniversityPage.TabIndex = 0;
            this.GeneralUniversityPage.Text = "Москвичи";
            // 
            // BranchesUniversityPage
            // 
            this.BranchesUniversityPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BranchesUniversityPage.Location = new System.Drawing.Point(4, 22);
            this.BranchesUniversityPage.Name = "BranchesUniversityPage";
            this.BranchesUniversityPage.Padding = new System.Windows.Forms.Padding(3);
            this.BranchesUniversityPage.Size = new System.Drawing.Size(488, 621);
            this.BranchesUniversityPage.TabIndex = 1;
            this.BranchesUniversityPage.Text = "ЗаМКАДыши";
            // 
            // InformationPage
            // 
            this.InformationPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InformationPage.Location = new System.Drawing.Point(4, 22);
            this.InformationPage.Name = "InformationPage";
            this.InformationPage.Padding = new System.Windows.Forms.Padding(3);
            this.InformationPage.Size = new System.Drawing.Size(485, 643);
            this.InformationPage.TabIndex = 2;
            this.InformationPage.Text = "Реклама";
            // 
            // SettingsPage
            // 
            this.SettingsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SettingsPage.Location = new System.Drawing.Point(4, 22);
            this.SettingsPage.Name = "SettingsPage";
            this.SettingsPage.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsPage.Size = new System.Drawing.Size(485, 643);
            this.SettingsPage.TabIndex = 3;
            this.SettingsPage.Text = "Сетинги";
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.закрытьToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(121, 26);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(484, 661);
            this.Controls.Add(this.tabControl);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 700);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MUIVPremiumAdminTool";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.tabControl.ResumeLayout(false);
            this.HRDepartmentPage.ResumeLayout(false);
            this.HRDepartamentControl.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage ADSearchPage;
        private System.Windows.Forms.TabPage HRDepartmentPage;
        private System.Windows.Forms.TabPage InformationPage;
        private System.Windows.Forms.TabPage SettingsPage;
        private System.Windows.Forms.TabControl HRDepartamentControl;
        private System.Windows.Forms.TabPage GeneralUniversityPage;
        private System.Windows.Forms.TabPage BranchesUniversityPage;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
    }
}

