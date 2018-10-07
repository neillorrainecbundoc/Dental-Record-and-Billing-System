namespace Dental_Record_and_Billing_System
{
    partial class RestorePatients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestorePatients));
            this.norecordfoundLabel = new System.Windows.Forms.Label();
            this.restoreselectBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.restoreptntsearchLabel = new System.Windows.Forms.Label();
            this.restoresearchTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // norecordfoundLabel
            // 
            this.norecordfoundLabel.BackColor = System.Drawing.Color.White;
            this.norecordfoundLabel.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.norecordfoundLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.norecordfoundLabel.Location = new System.Drawing.Point(23, 219);
            this.norecordfoundLabel.Name = "norecordfoundLabel";
            this.norecordfoundLabel.Size = new System.Drawing.Size(366, 75);
            this.norecordfoundLabel.TabIndex = 37;
            this.norecordfoundLabel.Text = "NO RECORD FOUND";
            this.norecordfoundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // restoreselectBtn
            // 
            this.restoreselectBtn.ActiveBorderThickness = 1;
            this.restoreselectBtn.ActiveCornerRadius = 20;
            this.restoreselectBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(97)))), ((int)(((byte)(184)))));
            this.restoreselectBtn.ActiveForecolor = System.Drawing.Color.White;
            this.restoreselectBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(97)))), ((int)(((byte)(184)))));
            this.restoreselectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.restoreselectBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("restoreselectBtn.BackgroundImage")));
            this.restoreselectBtn.ButtonText = "Restore";
            this.restoreselectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restoreselectBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restoreselectBtn.ForeColor = System.Drawing.Color.White;
            this.restoreselectBtn.IdleBorderThickness = 1;
            this.restoreselectBtn.IdleCornerRadius = 20;
            this.restoreselectBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.restoreselectBtn.IdleForecolor = System.Drawing.Color.White;
            this.restoreselectBtn.IdleLineColor = System.Drawing.Color.White;
            this.restoreselectBtn.Location = new System.Drawing.Point(292, 438);
            this.restoreselectBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.restoreselectBtn.Name = "restoreselectBtn";
            this.restoreselectBtn.Size = new System.Drawing.Size(108, 43);
            this.restoreselectBtn.TabIndex = 33;
            this.restoreselectBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.restoreselectBtn.Click += new System.EventHandler(this.restoreselectBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(388, 346);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // restoreptntsearchLabel
            // 
            this.restoreptntsearchLabel.AutoSize = true;
            this.restoreptntsearchLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restoreptntsearchLabel.ForeColor = System.Drawing.Color.White;
            this.restoreptntsearchLabel.Location = new System.Drawing.Point(14, 49);
            this.restoreptntsearchLabel.Name = "restoreptntsearchLabel";
            this.restoreptntsearchLabel.Size = new System.Drawing.Size(74, 22);
            this.restoreptntsearchLabel.TabIndex = 35;
            this.restoreptntsearchLabel.Text = "Search";
            // 
            // restoresearchTextBox
            // 
            this.restoresearchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.restoresearchTextBox.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restoresearchTextBox.ForeColor = System.Drawing.Color.White;
            this.restoresearchTextBox.HintForeColor = System.Drawing.Color.White;
            this.restoresearchTextBox.HintText = "";
            this.restoresearchTextBox.isPassword = false;
            this.restoresearchTextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(97)))), ((int)(((byte)(184)))));
            this.restoresearchTextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.restoresearchTextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(97)))), ((int)(((byte)(184)))));
            this.restoresearchTextBox.LineThickness = 4;
            this.restoresearchTextBox.Location = new System.Drawing.Point(12, 39);
            this.restoresearchTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.restoresearchTextBox.Name = "restoresearchTextBox";
            this.restoresearchTextBox.Size = new System.Drawing.Size(388, 37);
            this.restoresearchTextBox.TabIndex = 34;
            this.restoresearchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.restoresearchTextBox.OnValueChanged += new System.EventHandler(this.restoresearchTextBox_OnValueChanged);
            this.restoresearchTextBox.Enter += new System.EventHandler(this.restoresearchTextBox_Enter);
            this.restoresearchTextBox.Leave += new System.EventHandler(this.restoresearchTextBox_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(97)))), ((int)(((byte)(184)))));
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 31);
            this.panel1.TabIndex = 38;
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(385, 6);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(22, 22);
            this.close.TabIndex = 33;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // RestorePatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(416, 498);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.norecordfoundLabel);
            this.Controls.Add(this.restoreselectBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.restoreptntsearchLabel);
            this.Controls.Add(this.restoresearchTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "RestorePatients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label norecordfoundLabel;
        private Bunifu.Framework.UI.BunifuThinButton2 restoreselectBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label restoreptntsearchLabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox restoresearchTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label close;
    }
}