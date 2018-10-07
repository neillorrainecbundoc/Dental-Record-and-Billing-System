namespace Dental_Record_and_Billing_System
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.registerPanel = new System.Windows.Forms.Panel();
            this.addpatientsbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bdayPicker = new System.Windows.Forms.DateTimePicker();
            this.contactNoTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.addrTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lnameTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.mnameTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.fnameTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.addPatientLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.contactNoLabel = new System.Windows.Forms.Label();
            this.mnameLabel = new System.Windows.Forms.Label();
            this.bdayLabel = new System.Windows.Forms.Label();
            this.lnameLabel = new System.Windows.Forms.Label();
            this.fnameLabel = new System.Windows.Forms.Label();
            this.registerLogo = new System.Windows.Forms.PictureBox();
            this.registerLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Label();
            this.registerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registerLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // registerPanel
            // 
            this.registerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.registerPanel.Controls.Add(this.addpatientsbtn);
            this.registerPanel.Controls.Add(this.bdayPicker);
            this.registerPanel.Controls.Add(this.contactNoTextBox);
            this.registerPanel.Controls.Add(this.addrTextBox);
            this.registerPanel.Controls.Add(this.lnameTextBox);
            this.registerPanel.Controls.Add(this.mnameTextBox);
            this.registerPanel.Controls.Add(this.fnameTextBox);
            this.registerPanel.Controls.Add(this.addPatientLabel);
            this.registerPanel.Controls.Add(this.addressLabel);
            this.registerPanel.Controls.Add(this.contactNoLabel);
            this.registerPanel.Controls.Add(this.mnameLabel);
            this.registerPanel.Controls.Add(this.bdayLabel);
            this.registerPanel.Controls.Add(this.lnameLabel);
            this.registerPanel.Controls.Add(this.fnameLabel);
            this.registerPanel.Location = new System.Drawing.Point(12, 149);
            this.registerPanel.Name = "registerPanel";
            this.registerPanel.Size = new System.Drawing.Size(383, 355);
            this.registerPanel.TabIndex = 1;
            // 
            // addpatientsbtn
            // 
            this.addpatientsbtn.ActiveBorderThickness = 1;
            this.addpatientsbtn.ActiveCornerRadius = 20;
            this.addpatientsbtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(97)))), ((int)(((byte)(184)))));
            this.addpatientsbtn.ActiveForecolor = System.Drawing.Color.White;
            this.addpatientsbtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(97)))), ((int)(((byte)(184)))));
            this.addpatientsbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addpatientsbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addpatientsbtn.BackgroundImage")));
            this.addpatientsbtn.ButtonText = "ADD PATIENT";
            this.addpatientsbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addpatientsbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addpatientsbtn.ForeColor = System.Drawing.Color.White;
            this.addpatientsbtn.IdleBorderThickness = 1;
            this.addpatientsbtn.IdleCornerRadius = 20;
            this.addpatientsbtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addpatientsbtn.IdleForecolor = System.Drawing.Color.White;
            this.addpatientsbtn.IdleLineColor = System.Drawing.Color.White;
            this.addpatientsbtn.Location = new System.Drawing.Point(101, 286);
            this.addpatientsbtn.Margin = new System.Windows.Forms.Padding(5);
            this.addpatientsbtn.Name = "addpatientsbtn";
            this.addpatientsbtn.Size = new System.Drawing.Size(181, 50);
            this.addpatientsbtn.TabIndex = 21;
            this.addpatientsbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addpatientsbtn.Click += new System.EventHandler(this.addpatientsbtn_Click);
            // 
            // bdayPicker
            // 
            this.bdayPicker.CalendarForeColor = System.Drawing.Color.White;
            this.bdayPicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.bdayPicker.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdayPicker.Location = new System.Drawing.Point(159, 238);
            this.bdayPicker.Name = "bdayPicker";
            this.bdayPicker.Size = new System.Drawing.Size(212, 23);
            this.bdayPicker.TabIndex = 20;
            this.bdayPicker.ValueChanged += new System.EventHandler(this.bdayPicker_ValueChanged);
            // 
            // contactNoTextBox
            // 
            this.contactNoTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contactNoTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.contactNoTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.contactNoTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.contactNoTextBox.HintText = "";
            this.contactNoTextBox.isPassword = false;
            this.contactNoTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(97)))), ((int)(((byte)(184)))));
            this.contactNoTextBox.LineIdleColor = System.Drawing.Color.DarkGray;
            this.contactNoTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(97)))), ((int)(((byte)(184)))));
            this.contactNoTextBox.LineThickness = 3;
            this.contactNoTextBox.Location = new System.Drawing.Point(159, 194);
            this.contactNoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.contactNoTextBox.Name = "contactNoTextBox";
            this.contactNoTextBox.Size = new System.Drawing.Size(212, 33);
            this.contactNoTextBox.TabIndex = 19;
            this.contactNoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.contactNoTextBox.OnValueChanged += new System.EventHandler(this.contactNoTextBox_OnValueChanged);
            this.contactNoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contactNoTextBox_KeyPress);
            // 
            // addrTextBox
            // 
            this.addrTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addrTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.addrTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addrTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.addrTextBox.HintText = "";
            this.addrTextBox.isPassword = false;
            this.addrTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(97)))), ((int)(((byte)(184)))));
            this.addrTextBox.LineIdleColor = System.Drawing.Color.DarkGray;
            this.addrTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(97)))), ((int)(((byte)(184)))));
            this.addrTextBox.LineThickness = 3;
            this.addrTextBox.Location = new System.Drawing.Point(159, 160);
            this.addrTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.addrTextBox.Name = "addrTextBox";
            this.addrTextBox.Size = new System.Drawing.Size(212, 33);
            this.addrTextBox.TabIndex = 18;
            this.addrTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.addrTextBox.OnValueChanged += new System.EventHandler(this.addrTextBox_OnValueChanged);
            // 
            // lnameTextBox
            // 
            this.lnameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lnameTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lnameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lnameTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.lnameTextBox.HintText = "";
            this.lnameTextBox.isPassword = false;
            this.lnameTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(97)))), ((int)(((byte)(184)))));
            this.lnameTextBox.LineIdleColor = System.Drawing.Color.DarkGray;
            this.lnameTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(97)))), ((int)(((byte)(184)))));
            this.lnameTextBox.LineThickness = 3;
            this.lnameTextBox.Location = new System.Drawing.Point(159, 125);
            this.lnameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.lnameTextBox.Name = "lnameTextBox";
            this.lnameTextBox.Size = new System.Drawing.Size(212, 33);
            this.lnameTextBox.TabIndex = 17;
            this.lnameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.lnameTextBox.OnValueChanged += new System.EventHandler(this.lnameTextBox_OnValueChanged);
            // 
            // mnameTextBox
            // 
            this.mnameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mnameTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.mnameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mnameTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.mnameTextBox.HintText = "";
            this.mnameTextBox.isPassword = false;
            this.mnameTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(97)))), ((int)(((byte)(184)))));
            this.mnameTextBox.LineIdleColor = System.Drawing.Color.DarkGray;
            this.mnameTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(97)))), ((int)(((byte)(184)))));
            this.mnameTextBox.LineThickness = 3;
            this.mnameTextBox.Location = new System.Drawing.Point(159, 89);
            this.mnameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.mnameTextBox.Name = "mnameTextBox";
            this.mnameTextBox.Size = new System.Drawing.Size(212, 33);
            this.mnameTextBox.TabIndex = 16;
            this.mnameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mnameTextBox.OnValueChanged += new System.EventHandler(this.mnameTextBox_OnValueChanged);
            // 
            // fnameTextBox
            // 
            this.fnameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fnameTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.fnameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fnameTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.fnameTextBox.HintText = "";
            this.fnameTextBox.isPassword = false;
            this.fnameTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(97)))), ((int)(((byte)(184)))));
            this.fnameTextBox.LineIdleColor = System.Drawing.Color.DarkGray;
            this.fnameTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(97)))), ((int)(((byte)(184)))));
            this.fnameTextBox.LineThickness = 3;
            this.fnameTextBox.Location = new System.Drawing.Point(159, 55);
            this.fnameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.fnameTextBox.Name = "fnameTextBox";
            this.fnameTextBox.Size = new System.Drawing.Size(212, 33);
            this.fnameTextBox.TabIndex = 15;
            this.fnameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fnameTextBox.OnValueChanged += new System.EventHandler(this.fnameTextBox_OnValueChanged);
            // 
            // addPatientLabel
            // 
            this.addPatientLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPatientLabel.ForeColor = System.Drawing.Color.White;
            this.addPatientLabel.Location = new System.Drawing.Point(58, 22);
            this.addPatientLabel.Name = "addPatientLabel";
            this.addPatientLabel.Size = new System.Drawing.Size(275, 29);
            this.addPatientLabel.TabIndex = 4;
            this.addPatientLabel.Text = "Patient Registration Form";
            // 
            // addressLabel
            // 
            this.addressLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addressLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addressLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.ForeColor = System.Drawing.Color.White;
            this.addressLabel.Location = new System.Drawing.Point(6, 159);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(97, 34);
            this.addressLabel.TabIndex = 14;
            this.addressLabel.Text = "Address:";
            this.addressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contactNoLabel
            // 
            this.contactNoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.contactNoLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.contactNoLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNoLabel.ForeColor = System.Drawing.Color.White;
            this.contactNoLabel.Location = new System.Drawing.Point(8, 196);
            this.contactNoLabel.Name = "contactNoLabel";
            this.contactNoLabel.Size = new System.Drawing.Size(126, 31);
            this.contactNoLabel.TabIndex = 12;
            this.contactNoLabel.Text = "Contact No:";
            this.contactNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mnameLabel
            // 
            this.mnameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mnameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mnameLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnameLabel.ForeColor = System.Drawing.Color.White;
            this.mnameLabel.Location = new System.Drawing.Point(8, 88);
            this.mnameLabel.Name = "mnameLabel";
            this.mnameLabel.Size = new System.Drawing.Size(144, 34);
            this.mnameLabel.TabIndex = 10;
            this.mnameLabel.Text = "Middle name:";
            this.mnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bdayLabel
            // 
            this.bdayLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bdayLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bdayLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdayLabel.ForeColor = System.Drawing.Color.White;
            this.bdayLabel.Location = new System.Drawing.Point(8, 232);
            this.bdayLabel.Name = "bdayLabel";
            this.bdayLabel.Size = new System.Drawing.Size(90, 29);
            this.bdayLabel.TabIndex = 7;
            this.bdayLabel.Text = "Birthday:";
            this.bdayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnameLabel
            // 
            this.lnameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lnameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lnameLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameLabel.ForeColor = System.Drawing.Color.White;
            this.lnameLabel.Location = new System.Drawing.Point(8, 124);
            this.lnameLabel.Name = "lnameLabel";
            this.lnameLabel.Size = new System.Drawing.Size(116, 34);
            this.lnameLabel.TabIndex = 5;
            this.lnameLabel.Text = "Last name:";
            this.lnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fnameLabel
            // 
            this.fnameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fnameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fnameLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameLabel.ForeColor = System.Drawing.Color.White;
            this.fnameLabel.Location = new System.Drawing.Point(8, 54);
            this.fnameLabel.Name = "fnameLabel";
            this.fnameLabel.Size = new System.Drawing.Size(120, 34);
            this.fnameLabel.TabIndex = 1;
            this.fnameLabel.Text = "First name:";
            this.fnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // registerLogo
            // 
            this.registerLogo.Image = ((System.Drawing.Image)(resources.GetObject("registerLogo.Image")));
            this.registerLogo.Location = new System.Drawing.Point(22, 38);
            this.registerLogo.Name = "registerLogo";
            this.registerLogo.Size = new System.Drawing.Size(95, 119);
            this.registerLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.registerLogo.TabIndex = 3;
            this.registerLogo.TabStop = false;
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLabel.ForeColor = System.Drawing.Color.White;
            this.registerLabel.Location = new System.Drawing.Point(108, 62);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(282, 66);
            this.registerLabel.TabIndex = 5;
            this.registerLabel.Text = "ARROYO-DEREQUITO\r\n DENTAL CLINIC";
            this.registerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(97)))), ((int)(((byte)(184)))));
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 32);
            this.panel1.TabIndex = 6;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(387, 5);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(22, 22);
            this.close.TabIndex = 34;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(416, 514);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.registerLabel);
            this.Controls.Add(this.registerLogo);
            this.Controls.Add(this.registerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.registerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.registerLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel registerPanel;
        private System.Windows.Forms.Label fnameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label contactNoLabel;
        private System.Windows.Forms.Label mnameLabel;
        private System.Windows.Forms.Label bdayLabel;
        private System.Windows.Forms.Label lnameLabel;
        private System.Windows.Forms.PictureBox registerLogo;
        private System.Windows.Forms.Label addPatientLabel;
        private System.Windows.Forms.Label registerLabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox lnameTextBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox mnameTextBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox fnameTextBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox addrTextBox;
        private System.Windows.Forms.DateTimePicker bdayPicker;
        private Bunifu.Framework.UI.BunifuMaterialTextbox contactNoTextBox;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 addpatientsbtn;
        private System.Windows.Forms.Label close;
    }
}