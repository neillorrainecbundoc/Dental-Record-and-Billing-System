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
            this.username_textbox = new Bunifu.Framework.UI.BunifuTextbox();
            this.password_textbox = new Bunifu.Framework.UI.BunifuTextbox();
            this.login_button = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dentist_clinic_logo = new System.Windows.Forms.PictureBox();
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.minimize = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.clinic_name_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.forgot_password_link = new System.Windows.Forms.LinkLabel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dentist_clinic_logo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // username_textbox
            // 
            this.username_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.username_textbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("username_textbox.BackgroundImage")));
            this.username_textbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.username_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.username_textbox.Icon = ((System.Drawing.Image)(resources.GetObject("username_textbox.Icon")));
            this.username_textbox.Location = new System.Drawing.Point(24, 27);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(329, 43);
            this.username_textbox.TabIndex = 0;
            this.username_textbox.text = "";
            this.username_textbox.OnTextChange += new System.EventHandler(this.username_textbox_on_text_change);
            this.username_textbox.KeyPress += new System.EventHandler(this.username_textbox_keypress);
            this.username_textbox.Enter += new System.EventHandler(this.username_textbox_enter);
            this.username_textbox.Leave += new System.EventHandler(this.username_textbox_leave);
            // 
            // password_textbox
            // 
            this.password_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.password_textbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("password_textbox.BackgroundImage")));
            this.password_textbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.password_textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.password_textbox.Icon = ((System.Drawing.Image)(resources.GetObject("password_textbox.Icon")));
            this.password_textbox.Location = new System.Drawing.Point(24, 83);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(329, 43);
            this.password_textbox.TabIndex = 1;
            this.password_textbox.text = "";
            this.password_textbox.OnTextChange += new System.EventHandler(this.password_textbox_on_text_change);
            this.password_textbox.KeyPress += new System.EventHandler(this.password_textbox_keypress);
            this.password_textbox.Enter += new System.EventHandler(this.password_textbox_enter);
            this.password_textbox.Leave += new System.EventHandler(this.password_textbox_leave);
            // 
            // login_button
            // 
            this.login_button.ActiveBorderThickness = 1;
            this.login_button.ActiveCornerRadius = 5;
            this.login_button.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(97)))), ((int)(((byte)(184)))));
            this.login_button.ActiveForecolor = System.Drawing.Color.White;
            this.login_button.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(97)))), ((int)(((byte)(184)))));
            this.login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.login_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("login_button.BackgroundImage")));
            this.login_button.ButtonText = "LOGIN";
            this.login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.login_button.IdleBorderThickness = 1;
            this.login_button.IdleCornerRadius = 7;
            this.login_button.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.login_button.IdleForecolor = System.Drawing.Color.White;
            this.login_button.IdleLineColor = System.Drawing.Color.White;
            this.login_button.Location = new System.Drawing.Point(134, 163);
            this.login_button.Margin = new System.Windows.Forms.Padding(5);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(120, 40);
            this.login_button.TabIndex = 2;
            this.login_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.login_button.Click += new System.EventHandler(this.login_button_click);
            // 
            // dentist_clinic_logo
            // 
            this.dentist_clinic_logo.Image = ((System.Drawing.Image)(resources.GetObject("dentist_clinic_logo.Image")));
            this.dentist_clinic_logo.Location = new System.Drawing.Point(280, 35);
            this.dentist_clinic_logo.Name = "dentist_clinic_logo";
            this.dentist_clinic_logo.Size = new System.Drawing.Size(109, 142);
            this.dentist_clinic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dentist_clinic_logo.TabIndex = 3;
            this.dentist_clinic_logo.TabStop = false;
            // 
            // username_label
            // 
            this.username_label.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.username_label.Location = new System.Drawing.Point(67, 34);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(108, 29);
            this.username_label.TabIndex = 5;
            this.username_label.Text = "Username";
            this.username_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // password_label
            // 
            this.password_label.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.password_label.Location = new System.Drawing.Point(67, 90);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(104, 29);
            this.password_label.TabIndex = 6;
            this.password_label.Text = "Password";
            this.password_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minimize
            // 
            this.minimize.AutoSize = true;
            this.minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(97)))), ((int)(((byte)(184)))));
            this.minimize.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize.Location = new System.Drawing.Point(363, 0);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(30, 22);
            this.minimize.TabIndex = 34;
            this.minimize.Text = "__";
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
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
            this.close.Click += new System.EventHandler(this.close_click);
            // 
            // clinic_name_label
            // 
            this.clinic_name_label.BackColor = System.Drawing.Color.Transparent;
            this.clinic_name_label.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clinic_name_label.ForeColor = System.Drawing.Color.White;
            this.clinic_name_label.Location = new System.Drawing.Point(27, 77);
            this.clinic_name_label.Name = "clinic_name_label";
            this.clinic_name_label.Size = new System.Drawing.Size(267, 67);
            this.clinic_name_label.TabIndex = 40;
            this.clinic_name_label.Text = "ARROYO-DEREQUITO \r\nDENTAL CLINIC\r\n";
            this.clinic_name_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.forgot_password_link);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.password_label);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.username_label);
            this.panel2.Controls.Add(this.login_button);
            this.panel2.Controls.Add(this.password_textbox);
            this.panel2.Controls.Add(this.username_textbox);
            this.panel2.Location = new System.Drawing.Point(18, 221);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 225);
            this.panel2.TabIndex = 41;
            // 
            // forgot_password_link
            // 
            this.forgot_password_link.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(97)))), ((int)(((byte)(184)))));
            this.forgot_password_link.AutoSize = true;
            this.forgot_password_link.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgot_password_link.LinkColor = System.Drawing.Color.White;
            this.forgot_password_link.Location = new System.Drawing.Point(131, 141);
            this.forgot_password_link.Name = "forgot_password_link";
            this.forgot_password_link.Size = new System.Drawing.Size(123, 17);
            this.forgot_password_link.TabIndex = 43;
            this.forgot_password_link.TabStop = true;
            this.forgot_password_link.Text = "Forgot Password?";
            this.forgot_password_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.forgot_password_link_clicked);
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
            this.Controls.Add(this.clinic_name_label);
            this.Controls.Add(this.dentist_clinic_logo);
            this.Controls.Add(this.close);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dentist_clinic_logo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuTextbox password_textbox;
        private Bunifu.Framework.UI.BunifuThinButton2 login_button;
        private System.Windows.Forms.PictureBox dentist_clinic_logo;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label clinic_name_label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label minimize;
        private System.Windows.Forms.LinkLabel forgot_password_link;
        public Bunifu.Framework.UI.BunifuTextbox username_textbox;
    }
}

