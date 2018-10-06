using Bunifu.Framework.UI;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Record_and_Billing_System
{
    public partial class AddServices : Form
    {
        private static String name;
        private static String amount;
        public static String category;
        private static String services;

        private static BunifuMaterialTextbox nameTextBox;
        private static BunifuMaterialTextbox amountTextBox;
        private static BunifuMaterialTextbox categoryTextBox;

        private static Dashboard dashboard;

        public AddServices()
        {
            InitializeComponent();
            addServicesInit();
        }

        public AddServices(Object e)
        {
            dashboard = (Dashboard)e;
            InitializeComponent();
            addServicesInit();
        }

        private void addServicesInit()
        {
            amountTextBox = new BunifuMaterialTextbox();
            categoryTextBox = new BunifuMaterialTextbox();
            bunifuMaterialTextbox2.Enabled = false;
            bunifuMaterialTextbox2.Text = Dashboard.category;
            bunifuMaterialTextbox2.ForeColor = Color.White;

            category = Dashboard.category;
            categoryTextBox.Text = Dashboard.category;
            categoryTextBox.ForeColor = Color.White;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void mnameTextBox_OnValueChanged(object sender, EventArgs e)
        {
            nameTextBox = (BunifuMaterialTextbox)sender;
            nameTextBox.ForeColor = Color.White;
            name = nameTextBox.Text;
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            amountTextBox = (BunifuMaterialTextbox)sender;
            amountTextBox.ForeColor = Color.White;
            amount = amountTextBox.Text;
        }

        private void bunifuMaterialTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void addpatientsbtn_Click(object sender, EventArgs e)
        {
             if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(amount) && !string.IsNullOrEmpty(category))
            {
                MySqlCommand cmd = Main.dbconnection.CreateCommand();
                try
                {
                    String query = "Select id from services where name = '" + category + "'";
                    
                    cmd = new MySqlCommand(query, Main.dbconnection);
                    Object svc_id = cmd.ExecuteScalar();
                    
                    categoryTextBox.Text = "";

                    cmd = Main.dbconnection.CreateCommand();
                    cmd.CommandText = "insert into sub_services(svc_id,name,price,amount) value (?svc_id, ?name, ?price, ?amount)";

                    cmd.Parameters.AddWithValue("@svc_id", Convert.ToString(svc_id));
                    cmd.Parameters.AddWithValue("@price", 0);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@amount", amount);

                    cmd.ExecuteNonQuery();
                    amountTextBox.Text = "";
                    nameTextBox.Text = "";

                    dashboard.fillCategoryDropDownInit(true, category);
                    MessageBox.Show("Services Added!");

                    this.Hide();
                    dashboard.ServicesInitTable(category);
                }
                catch (Exception err)
                {
                    Console.WriteLine("Error services insert into database", err);
                }
            }
            else
            {
                String errFields = "";

                if (string.IsNullOrEmpty(name))
                {
                    errFields += "name";
                }
                if (string.IsNullOrEmpty(amount))
                {
                    errFields += ", amount";
                }

                MessageBox.Show("ERROR: \n\n Add information for " + errFields + " fields.");
            }
        }

        
    }
}
