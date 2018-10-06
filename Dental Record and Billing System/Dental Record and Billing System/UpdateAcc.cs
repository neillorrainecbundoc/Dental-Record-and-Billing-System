using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using MySql.Data.MySqlClient;

namespace Dental_Record_and_Billing_System
{
    public partial class UpdateAcc : Form
    {
        private DataGridViewRow row;
        private Dashboard dboard;
        private String AccountId;

        public UpdateAcc()
        {
            InitializeComponent();
        }

        public UpdateAcc(DataGridViewRow e, Dashboard db)
        {
            InitializeComponent();
            row = e;
            dboard = db;

            AccountId = row.Cells["Account Id"].Value.ToString().Replace("ACCID", "");
            bunifuMaterialTextbox1.Text = row.Cells["Username"].Value.ToString();
            
            bunifuMaterialTextbox2.ForeColor = Color.White;
            bunifuMaterialTextbox3.ForeColor = Color.White;

            bunifuMaterialTextbox1.Enabled = false;
        }

        private void upbtn_Click(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox2.Text == bunifuMaterialTextbox3.Text)
                if (!string.IsNullOrEmpty(bunifuMaterialTextbox2.Text))
                {
                    String query = "UPDATE users SET password = '" + bunifuMaterialTextbox2.Text + "'where id = " + AccountId + ";";
                    MySqlCommand cmd1 = new MySqlCommand(query, Main.dbconnection);
                    cmd1.ExecuteScalar();
                    dboard.SignupInitTable();
                    MessageBox.Show("Account updated!");
                    this.Hide();
                }

                else
                {
                    String errFields = "";

                    if (string.IsNullOrEmpty(bunifuMaterialTextbox2.Text))
                    {
                        errFields += "|password|";
                    }

                    MessageBox.Show("ERROR: \n\n Fix information for " + errFields);
                }
            else
            {
                MessageBox.Show("Password doesn't match.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
