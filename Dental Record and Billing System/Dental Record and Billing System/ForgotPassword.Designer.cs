namespace Dental_Record_and_Billing_System
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.forgot_password_header = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Label();
            this.forgot_password_label = new System.Windows.Forms.Label();
            this.username_textbox = new Bunifu.Framework.UI.BunifuTextbox();
            this.horizontal_line = new System.Windows.Forms.Label();
            this.secret_question_label = new System.Windows.Forms.Label();
            this.answer_textbox = new Bunifu.Framework.UI.BunifuTextbox();
            this.proceed_button = new Bunifu.Framework.UI.BunifuThinButton2();
            this.secret_question_dropdown = new Bunifu.Framework.UI.BunifuDropdown();
            this.username_label = new System.Windows.Forms.Label();
            this.answer_label = new System.Windows.Forms.Label();
            this.forgot_password_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // forgot_password_header
            // 
            this.forgot_password_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(97)))), ((int)(((byte)(184)))));
            this.forgot_password_header.Controls.Add(this.close);
            this.forgot_password_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.forgot_password_header.Location = new System.Drawing.Point(0, 0);
            this.forgot_password_header.Name = "forgot_password_header";
            this.forgot_password_header.Size = new System.Drawing.Size(366, 24);
            this.forgot_password_header.TabIndex = 8;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(338, 1);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(22, 22);
            this.close.TabIndex = 34;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_click);
            // 
            // forgot_password_label
            // 
            this.forgot_password_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgot_password_label.ForeColor = System.Drawing.Color.White;
            this.forgot_password_label.Location = new System.Drawing.Point(119, 41);
            this.forgot_password_label.Name = "forgot_password_label";
            this.forgot_password_label.Size = new System.Drawing.Size(133, 25);
            this.forgot_password_label.TabIndex = 39;
            this.forgot_password_label.Text = "Forgot Password";
            this.forgot_password_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // username_textbox
            // 
            this.username_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.username_textbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.username_textbox.ForeColor = System.Drawing.Color.White;
            this.username_textbox.Icon = ((System.Drawing.Image)(resources.GetObject("username_textbox.Icon")));
            this.username_textbox.Location = new System.Drawing.Point(61, 84);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(250, 30);
            this.username_textbox.TabIndex = 41;
            this.username_textbox.text = "";
            this.username_textbox.OnTextChange += new System.EventHandler(this.username_textbox_on_text_change);
            this.username_textbox.KeyPress += new System.EventHandler(this.username_textbox_keypress);
            this.username_textbox.Enter += new System.EventHandler(this.username_textbox_enter);
            this.username_textbox.Leave += new System.EventHandler(this.username_textbox_leave);
            // 
            // horizontal_line
            // 
            this.horizontal_line.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horizontal_line.ForeColor = System.Drawing.Color.White;
            this.horizontal_line.Location = new System.Drawing.Point(27, 128);
            this.horizontal_line.Name = "horizontal_line";
            this.horizontal_line.Size = new System.Drawing.Size(316, 25);
            this.horizontal_line.TabIndex = 42;
            this.horizontal_line.Text = "_____________________________________________";
            this.horizontal_line.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secret_question_label
            // 
            this.secret_question_label.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secret_question_label.ForeColor = System.Drawing.Color.White;
            this.secret_question_label.Location = new System.Drawing.Point(119, 164);
            this.secret_question_label.Name = "secret_question_label";
            this.secret_question_label.Size = new System.Drawing.Size(133, 25);
            this.secret_question_label.TabIndex = 43;
            this.secret_question_label.Text = "Secret Question";
            this.secret_question_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answer_textbox
            // 
            this.answer_textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.answer_textbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.answer_textbox.ForeColor = System.Drawing.Color.White;
            this.answer_textbox.Icon = ((System.Drawing.Image)(resources.GetObject("answer_textbox.Icon")));
            this.answer_textbox.Location = new System.Drawing.Point(61, 232);
            this.answer_textbox.Name = "answer_textbox";
            this.answer_textbox.Size = new System.Drawing.Size(250, 30);
            this.answer_textbox.TabIndex = 45;
            this.answer_textbox.text = "";
            this.answer_textbox.OnTextChange += new System.EventHandler(this.answer_textbox_on_text_change);
            this.answer_textbox.KeyPress += new System.EventHandler(this.answer_textbox_keypress);
            this.answer_textbox.Enter += new System.EventHandler(this.answer_textbox_enter);
            this.answer_textbox.Leave += new System.EventHandler(this.answer_textbox_leave);
            // 
            // proceed_button
            // 
            this.proceed_button.ActiveBorderThickness = 1;
            this.proceed_button.ActiveCornerRadius = 20;
            this.proceed_button.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(94)))), ((int)(((byte)(189)))));
            this.proceed_button.ActiveForecolor = System.Drawing.Color.White;
            this.proceed_button.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(94)))), ((int)(((byte)(189)))));
            this.proceed_button.BackColor = System.Drawing.Color.Gray;
            this.proceed_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("proceed_button.BackgroundImage")));
            this.proceed_button.ButtonText = "Proceed";
            this.proceed_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.proceed_button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceed_button.ForeColor = System.Drawing.Color.White;
            this.proceed_button.IdleBorderThickness = 1;
            this.proceed_button.IdleCornerRadius = 20;
            this.proceed_button.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.proceed_button.IdleForecolor = System.Drawing.Color.White;
            this.proceed_button.IdleLineColor = System.Drawing.Color.White;
            this.proceed_button.Location = new System.Drawing.Point(123, 278);
            this.proceed_button.Margin = new System.Windows.Forms.Padding(5);
            this.proceed_button.Name = "proceed_button";
            this.proceed_button.Size = new System.Drawing.Size(129, 43);
            this.proceed_button.TabIndex = 46;
            this.proceed_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.proceed_button.Click += new System.EventHandler(this.proceed_click);
            // 
            // secret_question_dropdown
            // 
            this.secret_question_dropdown.BackColor = System.Drawing.Color.DimGray;
            this.secret_question_dropdown.BorderRadius = 3;
            this.secret_question_dropdown.DisabledColor = System.Drawing.Color.White;
            this.secret_question_dropdown.ForeColor = System.Drawing.Color.White;
            this.secret_question_dropdown.Items = new string[] {
        "What was your childhood nickname?",
        "What is your favorite movie?",
        "In what town was your first job?"};
            this.secret_question_dropdown.Location = new System.Drawing.Point(44, 201);
            this.secret_question_dropdown.Name = "secret_question_dropdown";
            this.secret_question_dropdown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.secret_question_dropdown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(97)))), ((int)(((byte)(184)))));
            this.secret_question_dropdown.selectedIndex = 0;
            this.secret_question_dropdown.Size = new System.Drawing.Size(283, 25);
            this.secret_question_dropdown.TabIndex = 47;
            // 
            // username_label
            // 
            this.username_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.ForeColor = System.Drawing.Color.White;
            this.username_label.Location = new System.Drawing.Point(100, 90);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(77, 20);
            this.username_label.TabIndex = 48;
            this.username_label.Text = "Username";
            // 
            // answer_label
            // 
            this.answer_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.answer_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer_label.ForeColor = System.Drawing.Color.White;
            this.answer_label.Location = new System.Drawing.Point(100, 238);
            this.answer_label.Name = "answer_label";
            this.answer_label.Size = new System.Drawing.Size(77, 20);
            this.answer_label.TabIndex = 49;
            this.answer_label.Text = "Answer";
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(366, 342);
            this.Controls.Add(this.answer_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.proceed_button);
            this.Controls.Add(this.answer_textbox);
            this.Controls.Add(this.secret_question_label);
            this.Controls.Add(this.horizontal_line);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.forgot_password_label);
            this.Controls.Add(this.forgot_password_header);
            this.Controls.Add(this.secret_question_dropdown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPassword";
            this.forgot_password_header.ResumeLayout(false);
            this.forgot_password_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel forgot_password_header;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label forgot_password_label;
        private Bunifu.Framework.UI.BunifuTextbox username_textbox;
        private System.Windows.Forms.Label horizontal_line;
        private System.Windows.Forms.Label secret_question_label;
        private Bunifu.Framework.UI.BunifuTextbox answer_textbox;
        private Bunifu.Framework.UI.BunifuThinButton2 proceed_button;
        private Bunifu.Framework.UI.BunifuDropdown secret_question_dropdown;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label answer_label;
    }
}