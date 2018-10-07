namespace Dental_Record_and_Billing_System
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Label();
            this.registerLabel = new System.Windows.Forms.Label();
            this.registerLogo = new System.Windows.Forms.PictureBox();
            this.fnameTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.fnameLabel = new System.Windows.Forms.Label();
            this.MnameTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.LnameTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.addrssTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.contactNoTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.unameTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.pssTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ansTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.signupbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registerLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(97)))), ((int)(((byte)(184)))));
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 24);
            this.panel1.TabIndex = 9;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(655, 1);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(22, 22);
            this.close.TabIndex = 34;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLabel.ForeColor = System.Drawing.Color.White;
            this.registerLabel.Location = new System.Drawing.Point(230, 52);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(282, 66);
            this.registerLabel.TabIndex = 11;
            this.registerLabel.Text = "ARROYO-DEREQUITO\r\n DENTAL CLINIC";
            this.registerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // registerLogo
            // 
            this.registerLogo.Image = ((System.Drawing.Image)(resources.GetObject("registerLogo.Image")));
            this.registerLogo.Location = new System.Drawing.Point(144, 28);
            this.registerLogo.Name = "registerLogo";
            this.registerLogo.Size = new System.Drawing.Size(95, 119);
            this.registerLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.registerLogo.TabIndex = 10;
            this.registerLogo.TabStop = false;
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
            this.fnameTextBox.Location = new System.Drawing.Point(144, 151);
            this.fnameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.fnameTextBox.Name = "fnameTextBox";
            this.fnameTextBox.Size = new System.Drawing.Size(168, 33);
            this.fnameTextBox.TabIndex = 28;
            this.fnameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fnameTextBox.OnValueChanged += new System.EventHandler(this.fnameTextBox_OnValueChanged);
            // 
            // fnameLabel
            // 
            this.fnameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fnameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fnameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameLabel.ForeColor = System.Drawing.Color.White;
            this.fnameLabel.Location = new System.Drawing.Point(12, 154);
            this.fnameLabel.Name = "fnameLabel";
            this.fnameLabel.Size = new System.Drawing.Size(94, 34);
            this.fnameLabel.TabIndex = 21;
            this.fnameLabel.Text = "First name:";
            this.fnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MnameTextBox
            // 
            this.MnameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MnameTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.MnameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MnameTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.MnameTextBox.HintText = "";
            this.MnameTextBox.isPassword = false;
            this.MnameTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(97)))), ((int)(((byte)(184)))));
            this.MnameTextBox.LineIdleColor = System.Drawing.Color.DarkGray;
            this.MnameTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(97)))), ((int)(((byte)(184)))));
            this.MnameTextBox.LineThickness = 3;
            this.MnameTextBox.Location = new System.Drawing.Point(144, 189);
            this.MnameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MnameTextBox.Name = "MnameTextBox";
            this.MnameTextBox.Size = new System.Drawing.Size(168, 33);
            this.MnameTextBox.TabIndex = 30;
            this.MnameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MnameTextBox.OnValueChanged += new System.EventHandler(this.MnameTextBox_OnValueChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 34);
            this.label1.TabIndex = 29;
            this.label1.Text = "Middle name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LnameTextBox
            // 
            this.LnameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LnameTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LnameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LnameTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.LnameTextBox.HintText = "";
            this.LnameTextBox.isPassword = false;
            this.LnameTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(97)))), ((int)(((byte)(184)))));
            this.LnameTextBox.LineIdleColor = System.Drawing.Color.DarkGray;
            this.LnameTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(97)))), ((int)(((byte)(184)))));
            this.LnameTextBox.LineThickness = 3;
            this.LnameTextBox.Location = new System.Drawing.Point(144, 223);
            this.LnameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.LnameTextBox.Name = "LnameTextBox";
            this.LnameTextBox.Size = new System.Drawing.Size(168, 33);
            this.LnameTextBox.TabIndex = 32;
            this.LnameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LnameTextBox.OnValueChanged += new System.EventHandler(this.LnameTextBox_OnValueChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 34);
            this.label2.TabIndex = 31;
            this.label2.Text = "Last name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addrssTextBox
            // 
            this.addrssTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addrssTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.addrssTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addrssTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.addrssTextBox.HintText = "";
            this.addrssTextBox.isPassword = false;
            this.addrssTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(97)))), ((int)(((byte)(184)))));
            this.addrssTextBox.LineIdleColor = System.Drawing.Color.DarkGray;
            this.addrssTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(97)))), ((int)(((byte)(184)))));
            this.addrssTextBox.LineThickness = 3;
            this.addrssTextBox.Location = new System.Drawing.Point(144, 258);
            this.addrssTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.addrssTextBox.Name = "addrssTextBox";
            this.addrssTextBox.Size = new System.Drawing.Size(168, 33);
            this.addrssTextBox.TabIndex = 34;
            this.addrssTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.addrssTextBox.OnValueChanged += new System.EventHandler(this.addrssTextBox_OnValueChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 34);
            this.label3.TabIndex = 33;
            this.label3.Text = "Address :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.contactNoTextBox.Location = new System.Drawing.Point(144, 292);
            this.contactNoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.contactNoTextBox.Name = "contactNoTextBox";
            this.contactNoTextBox.Size = new System.Drawing.Size(168, 33);
            this.contactNoTextBox.TabIndex = 36;
            this.contactNoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.contactNoTextBox.OnValueChanged += new System.EventHandler(this.contactNoTextBox_OnValueChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 34);
            this.label4.TabIndex = 35;
            this.label4.Text = "Contact no:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // unameTextBox
            // 
            this.unameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.unameTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.unameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.unameTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.unameTextBox.HintText = "";
            this.unameTextBox.isPassword = false;
            this.unameTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(97)))), ((int)(((byte)(184)))));
            this.unameTextBox.LineIdleColor = System.Drawing.Color.DarkGray;
            this.unameTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(97)))), ((int)(((byte)(184)))));
            this.unameTextBox.LineThickness = 3;
            this.unameTextBox.Location = new System.Drawing.Point(439, 189);
            this.unameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.unameTextBox.Name = "unameTextBox";
            this.unameTextBox.Size = new System.Drawing.Size(225, 33);
            this.unameTextBox.TabIndex = 38;
            this.unameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.unameTextBox.OnValueChanged += new System.EventHandler(this.unameTextBox_OnValueChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(337, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 34);
            this.label5.TabIndex = 37;
            this.label5.Text = "Username:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pssTextBox
            // 
            this.pssTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pssTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.pssTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pssTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.pssTextBox.HintText = "";
            this.pssTextBox.isPassword = false;
            this.pssTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(97)))), ((int)(((byte)(184)))));
            this.pssTextBox.LineIdleColor = System.Drawing.Color.DarkGray;
            this.pssTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(97)))), ((int)(((byte)(184)))));
            this.pssTextBox.LineThickness = 3;
            this.pssTextBox.Location = new System.Drawing.Point(439, 224);
            this.pssTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.pssTextBox.Name = "pssTextBox";
            this.pssTextBox.Size = new System.Drawing.Size(225, 33);
            this.pssTextBox.TabIndex = 42;
            this.pssTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pssTextBox.OnValueChanged += new System.EventHandler(this.pssTextBox_OnValueChanged);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(337, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 34);
            this.label7.TabIndex = 41;
            this.label7.Text = "Password:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(337, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 41);
            this.label8.TabIndex = 43;
            this.label8.Text = "Security\r\nQuestion:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(337, 311);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 23);
            this.label10.TabIndex = 44;
            this.label10.Text = "Answer:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ansTextBox
            // 
            this.ansTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ansTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ansTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ansTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.ansTextBox.HintText = "";
            this.ansTextBox.isPassword = false;
            this.ansTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(97)))), ((int)(((byte)(184)))));
            this.ansTextBox.LineIdleColor = System.Drawing.Color.DarkGray;
            this.ansTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(97)))), ((int)(((byte)(184)))));
            this.ansTextBox.LineThickness = 3;
            this.ansTextBox.Location = new System.Drawing.Point(441, 301);
            this.ansTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ansTextBox.Name = "ansTextBox";
            this.ansTextBox.Size = new System.Drawing.Size(223, 33);
            this.ansTextBox.TabIndex = 45;
            this.ansTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ansTextBox.OnValueChanged += new System.EventHandler(this.ansTextBox_OnValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "What was your childhood nickname?",
            "What is your favorite movie?",
            "In what town was your first job?"});
            this.comboBox1.Location = new System.Drawing.Point(441, 267);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(223, 24);
            this.comboBox1.TabIndex = 46;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.White;
            this.comboBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Dentist",
            "Nurse"});
            this.comboBox2.Location = new System.Drawing.Point(441, 163);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(223, 25);
            this.comboBox2.TabIndex = 48;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(337, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 34);
            this.label9.TabIndex = 47;
            this.label9.Text = "Position:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(12, 334);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 34);
            this.label11.TabIndex = 49;
            this.label11.Text = "Gender:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(144, 344);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(65, 24);
            this.radioButton1.TabIndex = 51;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(232, 344);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(80, 24);
            this.radioButton2.TabIndex = 52;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // signupbtn
            // 
            this.signupbtn.ActiveBorderThickness = 1;
            this.signupbtn.ActiveCornerRadius = 20;
            this.signupbtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(97)))), ((int)(((byte)(184)))));
            this.signupbtn.ActiveForecolor = System.Drawing.Color.White;
            this.signupbtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(97)))), ((int)(((byte)(184)))));
            this.signupbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signupbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("signupbtn.BackgroundImage")));
            this.signupbtn.ButtonText = "Save";
            this.signupbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupbtn.ForeColor = System.Drawing.Color.White;
            this.signupbtn.IdleBorderThickness = 1;
            this.signupbtn.IdleCornerRadius = 20;
            this.signupbtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.signupbtn.IdleForecolor = System.Drawing.Color.White;
            this.signupbtn.IdleLineColor = System.Drawing.Color.White;
            this.signupbtn.Location = new System.Drawing.Point(559, 360);
            this.signupbtn.Margin = new System.Windows.Forms.Padding(5);
            this.signupbtn.Name = "signupbtn";
            this.signupbtn.Size = new System.Drawing.Size(105, 38);
            this.signupbtn.TabIndex = 53;
            this.signupbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signupbtn.Click += new System.EventHandler(this.signupbtn_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(685, 412);
            this.Controls.Add(this.signupbtn);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ansTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pssTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.unameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.contactNoTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addrssTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LnameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MnameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fnameTextBox);
            this.Controls.Add(this.fnameLabel);
            this.Controls.Add(this.registerLabel);
            this.Controls.Add(this.registerLogo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registerLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label registerLabel;
        private System.Windows.Forms.PictureBox registerLogo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox fnameTextBox;
        private System.Windows.Forms.Label fnameLabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox MnameTextBox;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox LnameTextBox;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox addrssTextBox;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox contactNoTextBox;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox unameTextBox;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox pssTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ansTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private Bunifu.Framework.UI.BunifuThinButton2 signupbtn;
    }
}