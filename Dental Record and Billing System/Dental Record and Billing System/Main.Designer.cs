namespace Dental_Record_and_Billing_System
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
            this.userTextBox = new Bunifu.Framework.UI.BunifuTextbox();
            this.pwTextBox = new Bunifu.Framework.UI.BunifuTextbox();
            this.loginBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DentistLogo = new System.Windows.Forms.PictureBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fpass = new System.Windows.Forms.LinkLabel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DentistLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // userTextBox
            // 
            this.userTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userTextBox.BackgroundImage")));
            this.userTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.userTextBox.Icon = ((System.Drawing.Image)(resources.GetObject("userTextBox.Icon")));
            this.userTextBox.Location = new System.Drawing.Point(24, 27);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(329, 43);
            this.userTextBox.TabIndex = 0;
            this.userTextBox.text = "";
            this.userTextBox.OnTextChange += new System.EventHandler(this.userTextBox_OnTextChange);
            this.userTextBox.KeyPress += new System.EventHandler(this.userTextBox_KeyPress);
            this.userTextBox.Leave += new System.EventHandler(this.userTextBox_Leave);
            // 
            // pwTextBox
            // 
            this.pwTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pwTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pwTextBox.BackgroundImage")));
            this.pwTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pwTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pwTextBox.Icon = ((System.Drawing.Image)(resources.GetObject("pwTextBox.Icon")));
            this.pwTextBox.Location = new System.Drawing.Point(24, 83);
            this.pwTextBox.Name = "pwTextBox";
            this.pwTextBox.Size = new System.Drawing.Size(329, 43);
            this.pwTextBox.TabIndex = 1;
            this.pwTextBox.text = "";
            this.pwTextBox.OnTextChange += new System.EventHandler(this.passTextBox_OnTextChange);
            this.pwTextBox.KeyPress += new System.EventHandler(this.passTextBox_KeyPress);
            this.pwTextBox.Enter += new System.EventHandler(this.pwTextBox_Enter);
            this.pwTextBox.Leave += new System.EventHandler(this.pwTextBox_Leave);
            // 
            // loginBtn
            // 
            this.loginBtn.ActiveBorderThickness = 1;
            this.loginBtn.ActiveCornerRadius = 5;
            this.loginBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(97)))), ((int)(((byte)(184)))));
            this.loginBtn.ActiveForecolor = System.Drawing.Color.White;
            this.loginBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(97)))), ((int)(((byte)(184)))));
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginBtn.BackgroundImage")));
            this.loginBtn.ButtonText = "LOGIN";
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.loginBtn.IdleBorderThickness = 1;
            this.loginBtn.IdleCornerRadius = 7;
            this.loginBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginBtn.IdleForecolor = System.Drawing.Color.White;
            this.loginBtn.IdleLineColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(134, 163);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(5);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(120, 40);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // DentistLogo
            // 
            this.DentistLogo.Image = ((System.Drawing.Image)(resources.GetObject("DentistLogo.Image")));
            this.DentistLogo.Location = new System.Drawing.Point(280, 35);
            this.DentistLogo.Name = "DentistLogo";
            this.DentistLogo.Size = new System.Drawing.Size(109, 142);
            this.DentistLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DentistLogo.TabIndex = 3;
            this.DentistLogo.TabStop = false;
            // 
            // usernameLabel
            // 
            this.usernameLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.usernameLabel.Location = new System.Drawing.Point(67, 34);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(108, 29);
            this.usernameLabel.TabIndex = 5;
            this.usernameLabel.Text = "Username";
            this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.usernameLabel.Click += new System.EventHandler(this.usernameLabel_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.passwordLabel.Location = new System.Drawing.Point(67, 90);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(104, 29);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Password";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.passwordLabel.Click += new System.EventHandler(this.passwordLabel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(97)))), ((int)(((byte)(184)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 22);
            this.label2.TabIndex = 34;
            this.label2.Text = "__";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(97)))), ((int)(((byte)(184)))));
            this.close.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(393, 1);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(22, 22);
            this.close.TabIndex = 33;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 67);
            this.label1.TabIndex = 40;
            this.label1.Text = "ARROYO-DEREQUITO \r\nDENTAL CLINIC\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.fpass);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.passwordLabel);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.usernameLabel);
            this.panel2.Controls.Add(this.loginBtn);
            this.panel2.Controls.Add(this.pwTextBox);
            this.panel2.Controls.Add(this.userTextBox);
            this.panel2.Location = new System.Drawing.Point(18, 221);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 225);
            this.panel2.TabIndex = 41;
            // 
            // fpass
            // 
            this.fpass.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(97)))), ((int)(((byte)(184)))));
            this.fpass.AutoSize = true;
            this.fpass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpass.LinkColor = System.Drawing.Color.White;
            this.fpass.Location = new System.Drawing.Point(131, 141);
            this.fpass.Name = "fpass";
            this.fpass.Size = new System.Drawing.Size(123, 17);
            this.fpass.TabIndex = 43;
            this.fpass.TabStop = true;
            this.fpass.Text = "Forgot Password?";
            this.fpass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.fpass_LinkClicked);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(10, 215);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(359, 10);
            this.panel6.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(10, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(359, 10);
            this.panel5.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 225);
            this.panel4.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(369, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 225);
            this.panel3.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(419, 466);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DentistLogo);
            this.Controls.Add(this.close);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.DentistLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuTextbox pwTextBox;
        private Bunifu.Framework.UI.BunifuThinButton2 loginBtn;
        private System.Windows.Forms.PictureBox DentistLogo;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel fpass;
        public Bunifu.Framework.UI.BunifuTextbox userTextBox;
    }
}

