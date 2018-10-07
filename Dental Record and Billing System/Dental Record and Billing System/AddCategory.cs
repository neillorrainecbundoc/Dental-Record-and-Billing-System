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
    /**
     * Category
     * 
     * specifies the category for a specific service that can be offered to a patient
     **/
    public partial class AddCategory : Form
    {

        private static Dashboard dashboard;
        private static String category;

        private static BunifuMaterialTextbox categoryTextBox;

        public AddCategory()
        {
            InitializeComponent();
            addCategoryInit();
        }
        public AddCategory(Object e)
        {
            InitializeComponent();
            dashboard = (Dashboard)e;
            addCategoryInit();
        } 
        private void addCategoryInit()
        {
            categoryTextBox = new BunifuMaterialTextbox();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {
            categoryTextBox = (BunifuMaterialTextbox)sender;
            categoryTextBox.ForeColor = Color.White;
            category = categoryTextBox.Text;
        }

        private void addpatientsbtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(category))
            {
                MySqlCommand cmd = Main.dbconnection.CreateCommand();
                cmd.CommandText = "insert into services (name) value (?name)";

                cmd.Parameters.AddWithValue("@name", category);

                try
                {
                    cmd.ExecuteNonQuery();

                    categoryTextBox.Text = "";

                    MessageBox.Show("Category Added!");

                    this.Hide();
                    dashboard.fillCategoryDropDownInit(false, "");
                }
                catch (Exception err)
                {
                    Console.WriteLine("Error category insert into database", err);
                }
            }
            else
            {
                String errFields = "";

                if (string.IsNullOrEmpty(category))
                {
                    errFields +="name";
                }
                MessageBox.Show("ERROR: \n\n Add category for " + errFields + " fields.");
            }

        }
}
}
