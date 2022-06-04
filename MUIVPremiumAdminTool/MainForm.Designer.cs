using System.Drawing;

namespace MUIVPremiumAdminTool
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.adSearchPage = new System.Windows.Forms.TabPage();
            this.hrDeptPage = new System.Windows.Forms.TabPage();
            this.hrDeptTabControl = new System.Windows.Forms.TabControl();
            this.generalPage = new System.Windows.Forms.TabPage();
            this.branchesPage = new System.Windows.Forms.TabPage();
            this.informationPage = new System.Windows.Forms.TabPage();
            this.settingsPage = new System.Windows.Forms.TabPage();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTabControl.SuspendLayout();
            this.hrDeptPage.SuspendLayout();
            this.hrDeptTabControl.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.mainTabControl.Controls.Add(this.adSearchPage);
            this.mainTabControl.Controls.Add(this.hrDeptPage);
            this.mainTabControl.Controls.Add(this.informationPage);
            this.mainTabControl.Controls.Add(this.settingsPage);
            this.mainTabControl.ItemSize = new System.Drawing.Size(110, 21);
            this.mainTabControl.Location = new System.Drawing.Point(-4, 0);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(492, 665);
            this.mainTabControl.TabIndex = 0;
            this.mainTabControl.TabStop = false;
            this.mainTabControl.Click += new System.EventHandler(this.mainTabControl_Click);
            this.mainTabControl.Enter += new System.EventHandler(this.mainTabControl_Enter);
            // 
            // adSearchPage
            // 
            this.adSearchPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.adSearchPage.ForeColor = System.Drawing.Color.White;
            this.adSearchPage.Location = new System.Drawing.Point(4, 25);
            this.adSearchPage.Name = "adSearchPage";
            this.adSearchPage.Padding = new System.Windows.Forms.Padding(3);
            this.adSearchPage.Size = new System.Drawing.Size(484, 636);
            this.adSearchPage.TabIndex = 0;
            this.adSearchPage.Text = "ADский Поисковик";
            // 
            // hrDeptPage
            // 
            this.hrDeptPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.hrDeptPage.Controls.Add(this.hrDeptTabControl);
            this.hrDeptPage.ForeColor = System.Drawing.Color.White;
            this.hrDeptPage.Location = new System.Drawing.Point(4, 25);
            this.hrDeptPage.Name = "hrDeptPage";
            this.hrDeptPage.Padding = new System.Windows.Forms.Padding(3);
            this.hrDeptPage.Size = new System.Drawing.Size(484, 636);
            this.hrDeptPage.TabIndex = 1;
            this.hrDeptPage.Text = "Отдел кадров";
            // 
            // hrDeptTabControl
            // 
            this.hrDeptTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hrDeptTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.hrDeptTabControl.Controls.Add(this.generalPage);
            this.hrDeptTabControl.Controls.Add(this.branchesPage);
            this.hrDeptTabControl.Location = new System.Drawing.Point(-4, 0);
            this.hrDeptTabControl.Name = "hrDeptTabControl";
            this.hrDeptTabControl.SelectedIndex = 0;
            this.hrDeptTabControl.Size = new System.Drawing.Size(491, 640);
            this.hrDeptTabControl.TabIndex = 0;
            this.hrDeptTabControl.TabStop = false;
            this.hrDeptTabControl.Click += new System.EventHandler(this.hrDeptTabControl_Click);
            this.hrDeptTabControl.Enter += new System.EventHandler(this.hrDeptTabControl_Enter);
            // 
            // generalPage
            // 
            this.generalPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.generalPage.Location = new System.Drawing.Point(4, 25);
            this.generalPage.Name = "generalPage";
            this.generalPage.Padding = new System.Windows.Forms.Padding(3);
            this.generalPage.Size = new System.Drawing.Size(483, 611);
            this.generalPage.TabIndex = 0;
            this.generalPage.Text = "Москвичи";
            // 
            // branchesPage
            // 
            this.branchesPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.branchesPage.Location = new System.Drawing.Point(4, 25);
            this.branchesPage.Name = "branchesPage";
            this.branchesPage.Padding = new System.Windows.Forms.Padding(3);
            this.branchesPage.Size = new System.Drawing.Size(483, 611);
            this.branchesPage.TabIndex = 1;
            this.branchesPage.Text = "ЗаМКАДыши";
            // 
            // informationPage
            // 
            this.informationPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.informationPage.Location = new System.Drawing.Point(4, 25);
            this.informationPage.Name = "informationPage";
            this.informationPage.Padding = new System.Windows.Forms.Padding(3);
            this.informationPage.Size = new System.Drawing.Size(484, 636);
            this.informationPage.TabIndex = 2;
            this.informationPage.Text = "Реклама";
            // 
            // settingsPage
            // 
            this.settingsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.settingsPage.Location = new System.Drawing.Point(4, 25);
            this.settingsPage.Name = "settingsPage";
            this.settingsPage.Padding = new System.Windows.Forms.Padding(3);
            this.settingsPage.Size = new System.Drawing.Size(484, 636);
            this.settingsPage.TabIndex = 3;
            this.settingsPage.Text = "Сетинги";
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "MUIVPremiumAdminTool";
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuButton});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(121, 26);
            // 
            // closeToolStripMenuButton
            // 
            this.closeToolStripMenuButton.Name = "closeToolStripMenuButton";
            this.closeToolStripMenuButton.Size = new System.Drawing.Size(120, 22);
            this.closeToolStripMenuButton.Text = "Закрыть";
            this.closeToolStripMenuButton.Click += new System.EventHandler(this.closeToolStripMenuButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(484, 661);
            this.Controls.Add(this.mainTabControl);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 700);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MUIVPremiumAdminTool";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.mainTabControl.ResumeLayout(false);
            this.hrDeptPage.ResumeLayout(false);
            this.hrDeptTabControl.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage adSearchPage;
        private System.Windows.Forms.TabPage hrDeptPage;
        private System.Windows.Forms.TabPage informationPage;
        private System.Windows.Forms.TabPage settingsPage;
        private System.Windows.Forms.TabControl hrDeptTabControl;
        private System.Windows.Forms.TabPage generalPage;
        private System.Windows.Forms.TabPage branchesPage;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuButton;
    }
}

