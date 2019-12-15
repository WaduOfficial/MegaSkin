namespace MegaSkin.Pages
{
    partial class Home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InputBOX = new System.Windows.Forms.GroupBox();
            this.ProxyTImeoutTXT = new MetroSuite.MetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ThreadsTXT = new MetroSuite.MetroTextbox();
            this.DoSkinChecker = new MetroSuite.MetroChecker();
            this.label1 = new System.Windows.Forms.Label();
            this.ProxyTypeOption = new MetroSuite.MetroComboBox();
            this.StartBTN = new MetroSuite.MetroButton();
            this.StopBTN = new MetroSuite.MetroButton();
            this.LoadProxiesBTN = new MetroSuite.MetroButton();
            this.LoadCombosBTN = new MetroSuite.MetroButton();
            this.InfoBOX = new System.Windows.Forms.GroupBox();
            this.NewsTXT = new System.Windows.Forms.TextBox();
            this.RunThreads = new System.ComponentModel.BackgroundWorker();
            this.InputBOX.SuspendLayout();
            this.InfoBOX.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputBOX
            // 
            this.InputBOX.Controls.Add(this.ProxyTImeoutTXT);
            this.InputBOX.Controls.Add(this.label3);
            this.InputBOX.Controls.Add(this.label2);
            this.InputBOX.Controls.Add(this.ThreadsTXT);
            this.InputBOX.Controls.Add(this.DoSkinChecker);
            this.InputBOX.Controls.Add(this.label1);
            this.InputBOX.Controls.Add(this.ProxyTypeOption);
            this.InputBOX.Controls.Add(this.StartBTN);
            this.InputBOX.Controls.Add(this.StopBTN);
            this.InputBOX.Controls.Add(this.LoadProxiesBTN);
            this.InputBOX.Controls.Add(this.LoadCombosBTN);
            this.InputBOX.ForeColor = System.Drawing.Color.Silver;
            this.InputBOX.Location = new System.Drawing.Point(4, 4);
            this.InputBOX.Name = "InputBOX";
            this.InputBOX.Size = new System.Drawing.Size(217, 317);
            this.InputBOX.TabIndex = 0;
            this.InputBOX.TabStop = false;
            this.InputBOX.Text = "Input";
            // 
            // ProxyTImeoutTXT
            // 
            this.ProxyTImeoutTXT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ProxyTImeoutTXT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.ProxyTImeoutTXT.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ProxyTImeoutTXT.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ProxyTImeoutTXT.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProxyTImeoutTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.ProxyTImeoutTXT.HideSelection = false;
            this.ProxyTImeoutTXT.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ProxyTImeoutTXT.Location = new System.Drawing.Point(111, 167);
            this.ProxyTImeoutTXT.Name = "ProxyTImeoutTXT";
            this.ProxyTImeoutTXT.PasswordChar = '\0';
            this.ProxyTImeoutTXT.Size = new System.Drawing.Size(100, 23);
            this.ProxyTImeoutTXT.Style = MetroSuite.Design.Style.Dark;
            this.ProxyTImeoutTXT.TabIndex = 10;
            this.ProxyTImeoutTXT.Text = "1000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "Proxy Timeout:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "Threads:";
            // 
            // ThreadsTXT
            // 
            this.ThreadsTXT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ThreadsTXT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.ThreadsTXT.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ThreadsTXT.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ThreadsTXT.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreadsTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.ThreadsTXT.HideSelection = false;
            this.ThreadsTXT.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ThreadsTXT.Location = new System.Drawing.Point(111, 138);
            this.ThreadsTXT.Name = "ThreadsTXT";
            this.ThreadsTXT.PasswordChar = '\0';
            this.ThreadsTXT.Size = new System.Drawing.Size(100, 23);
            this.ThreadsTXT.Style = MetroSuite.Design.Style.Dark;
            this.ThreadsTXT.TabIndex = 7;
            this.ThreadsTXT.Text = "250";
            // 
            // DoSkinChecker
            // 
            this.DoSkinChecker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.DoSkinChecker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DoSkinChecker.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.DoSkinChecker.Checked = true;
            this.DoSkinChecker.CheckedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.DoSkinChecker.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.DoSkinChecker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DoSkinChecker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.DoSkinChecker.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.DoSkinChecker.Location = new System.Drawing.Point(7, 225);
            this.DoSkinChecker.Name = "DoSkinChecker";
            this.DoSkinChecker.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(165)))));
            this.DoSkinChecker.Size = new System.Drawing.Size(84, 14);
            this.DoSkinChecker.Style = MetroSuite.Design.Style.Dark;
            this.DoSkinChecker.TabIndex = 6;
            this.DoSkinChecker.Text = "Check Skins";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Proxy Type:";
            // 
            // ProxyTypeOption
            // 
            this.ProxyTypeOption.AccentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ProxyTypeOption.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.ProxyTypeOption.AutoStyle = false;
            this.ProxyTypeOption.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.ProxyTypeOption.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ProxyTypeOption.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ProxyTypeOption.DisplayMember = "nn";
            this.ProxyTypeOption.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ProxyTypeOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProxyTypeOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProxyTypeOption.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProxyTypeOption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.ProxyTypeOption.FormattingEnabled = true;
            this.ProxyTypeOption.Items.AddRange(new object[] {
            "HTTP/s",
            "Socks-4",
            "Socks-4a",
            "Socks-5",
            "Proxyless"});
            this.ProxyTypeOption.Location = new System.Drawing.Point(6, 110);
            this.ProxyTypeOption.Name = "ProxyTypeOption";
            this.ProxyTypeOption.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ProxyTypeOption.Size = new System.Drawing.Size(205, 22);
            this.ProxyTypeOption.Style = MetroSuite.Design.Style.Dark;
            this.ProxyTypeOption.TabIndex = 4;
            this.ProxyTypeOption.SelectedIndexChanged += new System.EventHandler(this.ProxyTypeOption_SelectedIndexChanged);
            // 
            // StartBTN
            // 
            this.StartBTN.AutoStyle = false;
            this.StartBTN.BackColor = System.Drawing.Color.Transparent;
            this.StartBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StartBTN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.StartBTN.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.StartBTN.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.StartBTN.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.StartBTN.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.StartBTN.Location = new System.Drawing.Point(6, 245);
            this.StartBTN.Name = "StartBTN";
            this.StartBTN.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.StartBTN.RoundingArc = 30;
            this.StartBTN.Size = new System.Drawing.Size(205, 30);
            this.StartBTN.Style = MetroSuite.Design.Style.Dark;
            this.StartBTN.TabIndex = 3;
            this.StartBTN.Text = "Start";
            this.StartBTN.Click += new System.EventHandler(this.StartBTN_Click);
            // 
            // StopBTN
            // 
            this.StopBTN.AutoStyle = false;
            this.StopBTN.BackColor = System.Drawing.Color.Transparent;
            this.StopBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StopBTN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.StopBTN.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.StopBTN.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.StopBTN.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.StopBTN.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.StopBTN.Location = new System.Drawing.Point(6, 281);
            this.StopBTN.Name = "StopBTN";
            this.StopBTN.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.StopBTN.RoundingArc = 30;
            this.StopBTN.Size = new System.Drawing.Size(205, 30);
            this.StopBTN.Style = MetroSuite.Design.Style.Dark;
            this.StopBTN.TabIndex = 2;
            this.StopBTN.Text = "Stop";
            this.StopBTN.Click += new System.EventHandler(this.StopBTN_Click);
            // 
            // LoadProxiesBTN
            // 
            this.LoadProxiesBTN.AutoStyle = false;
            this.LoadProxiesBTN.BackColor = System.Drawing.Color.Transparent;
            this.LoadProxiesBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LoadProxiesBTN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.LoadProxiesBTN.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.LoadProxiesBTN.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.LoadProxiesBTN.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadProxiesBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.LoadProxiesBTN.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.LoadProxiesBTN.Location = new System.Drawing.Point(6, 56);
            this.LoadProxiesBTN.Name = "LoadProxiesBTN";
            this.LoadProxiesBTN.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.LoadProxiesBTN.RoundingArc = 30;
            this.LoadProxiesBTN.Size = new System.Drawing.Size(205, 30);
            this.LoadProxiesBTN.Style = MetroSuite.Design.Style.Dark;
            this.LoadProxiesBTN.TabIndex = 1;
            this.LoadProxiesBTN.Text = "Load Proxies";
            this.LoadProxiesBTN.Click += new System.EventHandler(this.LoadProxiesBTN_Click);
            // 
            // LoadCombosBTN
            // 
            this.LoadCombosBTN.AutoStyle = false;
            this.LoadCombosBTN.BackColor = System.Drawing.Color.Transparent;
            this.LoadCombosBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LoadCombosBTN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.LoadCombosBTN.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.LoadCombosBTN.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.LoadCombosBTN.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadCombosBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.LoadCombosBTN.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.LoadCombosBTN.Location = new System.Drawing.Point(6, 20);
            this.LoadCombosBTN.Name = "LoadCombosBTN";
            this.LoadCombosBTN.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.LoadCombosBTN.RoundingArc = 30;
            this.LoadCombosBTN.Size = new System.Drawing.Size(205, 30);
            this.LoadCombosBTN.Style = MetroSuite.Design.Style.Dark;
            this.LoadCombosBTN.TabIndex = 0;
            this.LoadCombosBTN.Text = "Load Combos";
            this.LoadCombosBTN.Click += new System.EventHandler(this.LoadCombosBTN_Click);
            // 
            // InfoBOX
            // 
            this.InfoBOX.Controls.Add(this.NewsTXT);
            this.InfoBOX.ForeColor = System.Drawing.Color.Silver;
            this.InfoBOX.Location = new System.Drawing.Point(227, 4);
            this.InfoBOX.Name = "InfoBOX";
            this.InfoBOX.Size = new System.Drawing.Size(369, 317);
            this.InfoBOX.TabIndex = 1;
            this.InfoBOX.TabStop = false;
            this.InfoBOX.Text = "Announcements";
            // 
            // NewsTXT
            // 
            this.NewsTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.NewsTXT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NewsTXT.ForeColor = System.Drawing.Color.Silver;
            this.NewsTXT.Location = new System.Drawing.Point(7, 20);
            this.NewsTXT.Multiline = true;
            this.NewsTXT.Name = "NewsTXT";
            this.NewsTXT.Size = new System.Drawing.Size(356, 291);
            this.NewsTXT.TabIndex = 0;
            this.NewsTXT.Text = "{0}";
            // 
            // RunThreads
            // 
            this.RunThreads.DoWork += new System.ComponentModel.DoWorkEventHandler(this.RunThreads_DoWork);
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.InfoBOX);
            this.Controls.Add(this.InputBOX);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Silver;
            this.Name = "Home";
            this.Size = new System.Drawing.Size(599, 324);
            this.Load += new System.EventHandler(this.Home_Load);
            this.InputBOX.ResumeLayout(false);
            this.InputBOX.PerformLayout();
            this.InfoBOX.ResumeLayout(false);
            this.InfoBOX.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox InputBOX;
        private System.Windows.Forms.GroupBox InfoBOX;
        private MetroSuite.MetroButton LoadCombosBTN;
        private MetroSuite.MetroButton LoadProxiesBTN;
        private MetroSuite.MetroButton StopBTN;
        private MetroSuite.MetroButton StartBTN;
        private MetroSuite.MetroComboBox ProxyTypeOption;
        private System.Windows.Forms.Label label1;
        private MetroSuite.MetroChecker DoSkinChecker;
        private System.Windows.Forms.TextBox NewsTXT;
        private MetroSuite.MetroTextbox ThreadsTXT;
        private System.Windows.Forms.Label label2;
        private MetroSuite.MetroTextbox ProxyTImeoutTXT;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker RunThreads;
    }
}
