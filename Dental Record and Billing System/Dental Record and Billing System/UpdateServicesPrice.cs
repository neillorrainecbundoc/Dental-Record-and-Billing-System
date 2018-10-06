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
    public partial class UpdateServicesPrice : Form
    {

        private DataGridViewRow row;
        private Dashboard dboard;
        public static String category;
        private String service;

        public UpdateServicesPrice()
        {
            InitializeComponent();
            InitField();
            
        }
        public UpdateServicesPrice(DataGridViewRow e, Dashboard db)
        {
            InitializeComponent();
            dboard = (Dashboard)db;
            InitField();
            row = e;
            dboard = db;

            
            bunifuMaterialTextbox2.Text = row.Cells["Service"].Value.ToString();
            service = bunifuMaterialTextbox2.Text;

            bunifuMaterialTextbox1.ForeColor = Color.Black;
            bunifuMaterialTextbox2.ForeColor = Color.Black;
            bunifuMaterialTextbox3.ForeColor = Color.Black;

            //bunifuMaterialTextbox1.Enabled = false;
           // bunifuMaterialTextbox2.Enabled = false;
        }

        public void InitField()
        {
            bunifuMaterialTextbox1.Text = Dashboard.category;
            category = Dashboard.category;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuMaterialTextbox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void upbtn_Click(object sender, EventArgs e)
        {
                if (!string.IsNullOrEmpty(bunifuMaterialTextbox3.Text))
                {
                    String query = "UPDATE sub_services SET amount = '" + bunifuMaterialTextbox3.Text + "' where name = '" + service + "';";
                    MySqlCommand cmd1 = new MySqlCommand(query, Main.dbconnection);
                    cmd1.ExecuteScalar();
                    dboard.ServicesInitTable(category);
                    MessageBox.Show("Price has been updated!");
                    this.Hide();
                }

                else
                {
                    String errFields = "";

                    if (string.IsNullOrEmpty(bunifuMaterialTextbox3.Text))
                    {
                        errFields += "Price";
                    }

                    MessageBox.Show("ERROR: \n\n Fix information for " + errFields);
                }
        }
    }
}
