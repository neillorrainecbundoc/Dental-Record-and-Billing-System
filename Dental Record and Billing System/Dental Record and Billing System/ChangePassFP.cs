using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Bunifu.Framework.UI;

namespace Dental_Record_and_Billing_System
{
    public partial class ChangePassFP : Form
    {
        private String AccountId;

        public ChangePassFP()
        {
            InitializeComponent();
        }
        public ChangePassFP(String id)
        {
            InitializeComponent();
            
            bunifuMaterialTextbox2.ForeColor = Color.White;
            bunifuMaterialTextbox1.ForeColor = Color.White;
            bunifuMaterialTextbox2.isPassword = true;
            bunifuMaterialTextbox1.isPassword = true;
            AccountId = id;
        }

        private void upbtn_Click(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox2.Text == bunifuMaterialTextbox1.Text)
                if (!string.IsNullOrEmpty(bunifuMaterialTextbox2.Text))
                {
                    String query = "UPDATE users SET password = '" + bunifuMaterialTextbox2.Text + "'where id = '" + AccountId + "';";
                    MySqlCommand cmd1 = new MySqlCommand(query, Main.dbconnection);
                    cmd1.ExecuteScalar();
                    MessageBox.Show(query);
                    MessageBox.Show("Password has been changed");
                    this.Hide();
                }

                else
                {
                    String errFields = "";

                    if (string.IsNullOrEmpty(bunifuMaterialTextbox2.Text))
                    {
                        errFields += "password";
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

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {
            bunifuMaterialTextbox2.isPassword = true;
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            bunifuMaterialTextbox1.isPassword = true;
        }
    }
}
