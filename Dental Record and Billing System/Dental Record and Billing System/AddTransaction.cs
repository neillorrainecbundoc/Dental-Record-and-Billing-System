using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Record_and_Billing_System
{
    public partial class AddTransaction : Form
    {
        private double basePay = 0;
        private double addtlCharge = 0;
        private decimal qty = 1;
        private string treatment;
        private string category;
        private static Dashboard dashboard;

        public AddTransaction()
        {
            InitializeComponent();
            ServicesInit();
            TreatmentInit(category);
        }

        public AddTransaction(Object e)
        {
            InitializeComponent();
            ServicesInit();
            TreatmentInit(category);
            dashboard = (Dashboard)e;
            numericUpDown1.Value = (decimal) 1;
            numericUpDown1.ReadOnly = true;
            basepayTextBox.Enabled = false;
        }
        //dropdown treatment
        private void TreatmentInit(String category)
        {
            treatmentDropDown.Clear();
            String query = "SELECT sb.name from sub_services sb join services s on sb.svc_id = s.id where s.name = '" + category + "'";
            MySqlCommand cmd = new MySqlCommand(query, Main.dbconnection);

            try {
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    treatmentDropDown.AddItem(reader.GetString(0));
                }
                treatmentDropDown.selectedIndex = 0;
                treatment = treatmentDropDown.selectedValue;
                reader.Close();

                query = "SELECT amount from sub_services where name = '" + treatment + "'";
                cmd = new MySqlCommand(query, Main.dbconnection);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    basepayTextBox.Text = reader.GetString(0);
                }
                    
                reader.Close();
            } catch(Exception e)
            {
                Console.WriteLine("Error {0}", e);
            }
        }

        private void basepayTextBox_OnValueChanged(object sender, EventArgs e)
        {
            basepayTextBox.ForeColor = Color.WhiteSmoke;
            basepayTextBox.Text = basepayTextBox.Text.Replace(Environment.NewLine, "");
            if (!Regex.IsMatch(basepayTextBox.Text, "^\\d+(\\.?)\\d*$"))
            {
                if (!string.IsNullOrEmpty(basepayTextBox.Text))
                {
                    MessageBox.Show("Enter DIGITS only.");
                    basepayTextBox.Text = "";
                }
            } else
            {
                basePay = double.Parse(basepayTextBox.Text);
            }
        }

        private void additionalTextBox_OnValueChanged(object sender, EventArgs e)
        {
           /* additionalTextBox.ForeColor = Color.White;
            additionalTextBox.Text = additionalTextBox.Text.Replace(Environment.NewLine, "");
            if (!Regex.IsMatch(additionalTextBox.Text, "^\\d+(\\.?)\\d*$"))
            {
                if (!string.IsNullOrEmpty(additionalTextBox.Text))
                {
                    MessageBox.Show("Enter DIGITS only.");
                    additionalTextBox.Text = "";
                }
            }
            else
            {
                addtlCharge = double.Parse(additionalTextBox.Text);
            }*/
        }

        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {
          /*  bunifuCustomTextbox1.ForeColor = Color.White;
            note = bunifuCustomTextbox1.Text;*/
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            qty = numericUpDown1.Value;
            if(qty <= 0)
            {
                numericUpDown1.Value = 1;
                qty = 1;
            }
        }
        //dropdown treatment
        private void treatmentDropDown_onItemSelected(object sender, EventArgs e)
        {
            treatment = treatmentDropDown.selectedValue;

            String query = "SELECT amount from sub_services where name = '" + treatment + "'";
            MySqlCommand cmd = new MySqlCommand(query, Main.dbconnection);
            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();

                int count = 0;
                while (reader.Read())
                {
                    basepayTextBox.Text = reader.GetInt32(0).ToString();
                    count++;
                }
                if (count == 0) basepayTextBox.Text = "";
                reader.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine("Error {0}", err);
            }
        }
        //button
        private void addBtn_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(treatment) || string.IsNullOrEmpty(treatment))
            {
                MessageBox.Show("Please select treatment.");
            } else
            {
                dashboard.addTransaction(treatment, qty, basePay, addtlCharge);
                this.Hide();
            }
            
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //dropdown category
        private void ServicesInit()
        {
            String query = "SELECT name from services";
            MySqlCommand cmd = new MySqlCommand(query, Main.dbconnection);

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    bunifuDropdown1.AddItem(reader.GetString(0));
                }
                reader.Close();

                bunifuDropdown1.selectedIndex = 0;
                category = bunifuDropdown1.selectedValue;
                TreatmentInit(category);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error {0}", e);
            }
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {
            category = bunifuDropdown1.selectedValue;
            TreatmentInit(category);
        }

        



    }
 }
