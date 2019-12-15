namespace MegaSkin.Forms
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.MenuSliderPanel = new System.Windows.Forms.Panel();
            this.AboutMenuBTN = new System.Windows.Forms.Button();
            this.SettingsMenuBTN = new System.Windows.Forms.Button();
            this.StatsMenuBTN = new System.Windows.Forms.Button();
            this.MainMenuBTN = new System.Windows.Forms.Button();
            this.MenuHolderPanel = new System.Windows.Forms.Panel();
            this.ExitBTN = new System.Windows.Forms.Button();
            this.MiniBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MainPanel.Controls.Add(this.MenuPanel);
            this.MainPanel.Controls.Add(this.MenuHolderPanel);
            this.MainPanel.Location = new System.Drawing.Point(1, 26);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(748, 324);
            this.MainPanel.TabIndex = 0;
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(33)))));
            this.MenuPanel.Controls.Add(this.MenuSliderPanel);
            this.MenuPanel.Controls.Add(this.AboutMenuBTN);
            this.MenuPanel.Controls.Add(this.SettingsMenuBTN);
            this.MenuPanel.Controls.Add(this.StatsMenuBTN);
            this.MenuPanel.Controls.Add(this.MainMenuBTN);
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(150, 324);
            this.MenuPanel.TabIndex = 0;
            // 
            // MenuSliderPanel
            // 
            this.MenuSliderPanel.BackColor = System.Drawing.Color.Red;
            this.MenuSliderPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuSliderPanel.Name = "MenuSliderPanel";
            this.MenuSliderPanel.Size = new System.Drawing.Size(3, 25);
            this.MenuSliderPanel.TabIndex = 7;
            // 
            // AboutMenuBTN
            // 
            this.AboutMenuBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.AboutMenuBTN.FlatAppearance.BorderSize = 0;
            this.AboutMenuBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutMenuBTN.Image = ((System.Drawing.Image)(resources.GetObject("AboutMenuBTN.Image")));
            this.AboutMenuBTN.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.AboutMenuBTN.Location = new System.Drawing.Point(0, 75);
            this.AboutMenuBTN.Name = "AboutMenuBTN";
            this.AboutMenuBTN.Size = new System.Drawing.Size(150, 25);
            this.AboutMenuBTN.TabIndex = 6;
            this.AboutMenuBTN.Text = "        About";
            this.AboutMenuBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AboutMenuBTN.UseVisualStyleBackColor = true;
            this.AboutMenuBTN.Click += new System.EventHandler(this.AboutMenuBTN_Click);
            // 
            // SettingsMenuBTN
            // 
            this.SettingsMenuBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.SettingsMenuBTN.FlatAppearance.BorderSize = 0;
            this.SettingsMenuBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsMenuBTN.Image = ((System.Drawing.Image)(resources.GetObject("SettingsMenuBTN.Image")));
            this.SettingsMenuBTN.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.SettingsMenuBTN.Location = new System.Drawing.Point(0, 50);
            this.SettingsMenuBTN.Name = "SettingsMenuBTN";
            this.SettingsMenuBTN.Size = new System.Drawing.Size(150, 25);
            this.SettingsMenuBTN.TabIndex = 5;
            this.SettingsMenuBTN.Text = "        Settings";
            this.SettingsMenuBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsMenuBTN.UseVisualStyleBackColor = true;
            this.SettingsMenuBTN.Click += new System.EventHandler(this.SettingsMenuBTN_Click);
            // 
            // StatsMenuBTN
            // 
            this.StatsMenuBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.StatsMenuBTN.FlatAppearance.BorderSize = 0;
            this.StatsMenuBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatsMenuBTN.Image = ((System.Drawing.Image)(resources.GetObject("StatsMenuBTN.Image")));
            this.StatsMenuBTN.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.StatsMenuBTN.Location = new System.Drawing.Point(0, 25);
            this.StatsMenuBTN.Name = "StatsMenuBTN";
            this.StatsMenuBTN.Size = new System.Drawing.Size(150, 25);
            this.StatsMenuBTN.TabIndex = 4;
            this.StatsMenuBTN.Text = "        Stats";
            this.StatsMenuBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StatsMenuBTN.UseVisualStyleBackColor = true;
            this.StatsMenuBTN.Click += new System.EventHandler(this.StatsMenuBTN_Click);
            // 
            // MainMenuBTN
            // 
            this.MainMenuBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MainMenuBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.MainMenuBTN.FlatAppearance.BorderSize = 0;
            this.MainMenuBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainMenuBTN.Image = ((System.Drawing.Image)(resources.GetObject("MainMenuBTN.Image")));
            this.MainMenuBTN.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MainMenuBTN.Location = new System.Drawing.Point(0, 0);
            this.MainMenuBTN.Name = "MainMenuBTN";
            this.MainMenuBTN.Size = new System.Drawing.Size(150, 25);
            this.MainMenuBTN.TabIndex = 3;
            this.MainMenuBTN.Text = "        Main";
            this.MainMenuBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainMenuBTN.UseVisualStyleBackColor = false;
            this.MainMenuBTN.Click += new System.EventHandler(this.MainMenuBTN_Click);
            // 
            // MenuHolderPanel
            // 
            this.MenuHolderPanel.Location = new System.Drawing.Point(149, 0);
            this.MenuHolderPanel.Name = "MenuHolderPanel";
            this.MenuHolderPanel.Size = new System.Drawing.Size(599, 324);
            this.MenuHolderPanel.TabIndex = 1;
            // 
            // ExitBTN
            // 
            this.ExitBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ExitBTN.FlatAppearance.BorderSize = 0;
            this.ExitBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBTN.Location = new System.Drawing.Point(664, 1);
            this.ExitBTN.Name = "ExitBTN";
            this.ExitBTN.Size = new System.Drawing.Size(85, 25);
            this.ExitBTN.TabIndex = 1;
            this.ExitBTN.Text = "X";
            this.ExitBTN.UseVisualStyleBackColor = true;
            this.ExitBTN.Click += new System.EventHandler(this.ExitBTN_Click);
            // 
            // MiniBTN
            // 
            this.MiniBTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.MiniBTN.FlatAppearance.BorderSize = 0;
            this.MiniBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MiniBTN.Location = new System.Drawing.Point(577, 1);
            this.MiniBTN.Name = "MiniBTN";
            this.MiniBTN.Size = new System.Drawing.Size(85, 25);
            this.MiniBTN.TabIndex = 2;
            this.MiniBTN.Text = "_";
            this.MiniBTN.UseVisualStyleBackColor = true;
            this.MiniBTN.Click += new System.EventHandler(this.MiniBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "MegaSkin [v1.2]";
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(750, 350);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MiniBTN);
            this.Controls.Add(this.ExitBTN);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MegaSkin - Fortnite Checker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.MainPanel.ResumeLayout(false);
            this.MenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button ExitBTN;
        private System.Windows.Forms.Button MiniBTN;
        public System.Windows.Forms.Button MainMenuBTN;
        public System.Windows.Forms.Button StatsMenuBTN;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button SettingsMenuBTN;
        public System.Windows.Forms.Button AboutMenuBTN;
        public System.Windows.Forms.Panel MenuHolderPanel;
        public System.Windows.Forms.Panel MenuSliderPanel;
    }
}