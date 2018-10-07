using Bunifu.Framework.UI;
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
    public partial class Register : Form
    {

        private static String firstName;
        private static String middleName;
        private static String lastName;
        private static String address;
        private static DateTime birthday;
        private static String contact;

        private static BunifuMaterialTextbox firstNameTextBox;
        private static BunifuMaterialTextbox middleNameTextBox;
        private static BunifuMaterialTextbox lastNameTextBox;
        private static BunifuMaterialTextbox addressTextBox;
        private static BunifuMaterialTextbox contactTextBox;
        private static DateTimePicker birthdayPicker;

        private static Dashboard dashboard;

        public Register()
        {
            InitializeComponent();
            initFields();
        }

        public Register(Object e)
        {
            InitializeComponent();
            initFields();
            dashboard = (Dashboard)e;
        }

        private void initFields()
        {
            firstNameTextBox = new BunifuMaterialTextbox();
            middleNameTextBox = new BunifuMaterialTextbox();
            lastNameTextBox = new BunifuMaterialTextbox();
            addressTextBox = new BunifuMaterialTextbox();
            contactTextBox = new BunifuMaterialTextbox();
            birthdayPicker = new DateTimePicker();
            birthdayPicker.Value = DateTime.Now;
        }

        private void addpatientsbtn_Click(object sender, EventArgs e)
        {
            if (contact.Length == 11 && !string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(middleName) && !string.IsNullOrEmpty(lastName) && !string.IsNullOrEmpty(address) && !string.IsNullOrEmpty(contact))
            {
                MySqlCommand cmd = Main.dbconnection.CreateCommand();
                cmd.CommandText = "insert into patients (firstname, middlename, lastname, address, birthday, contact) value (?firstname, ?middlename, ?lastname, ?address, ?birthday, ?contact)";

                cmd.Parameters.AddWithValue("@firstname", firstName);
                cmd.Parameters.AddWithValue("@middlename", middleName);
                cmd.Parameters.AddWithValue("@lastname", lastName);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@birthday", birthdayPicker.Value);
                cmd.Parameters.AddWithValue("@contact", contact);

                try
                {
                    cmd.ExecuteNonQuery();

                    firstNameTextBox.Text = "";
                    middleNameTextBox.Text = "";
                    lastNameTextBox.Text = "";
                    addressTextBox.Text = "";
                    contactTextBox.Text = "";
                    birthdayPicker.Value = DateTime.Now;

                    MessageBox.Show("Patient Added!");

                    this.Hide();
                    dashboard.PatientInitTable();
                }
                catch (Exception err)
                {
                    Console.WriteLine("Error patient insert into database", err);
                }
            }
            else
            {
                String errFields = "";

                if (string.IsNullOrEmpty(firstName))
                {
                    errFields += "First name ";
                }
                if (string.IsNullOrEmpty(middleName))
                {
                    errFields += "Middle name ";
                }
                if (string.IsNullOrEmpty(lastName))
                {
                    errFields += "Last name ";
                }
                if (string.IsNullOrEmpty(address))
                {
                    errFields += "Address ";
                }
                if (string.IsNullOrEmpty(contact))
                {
                    errFields += "Contact ";
                }
                if (contact.Length != 11)
                {
                    errFields += "Contact length";
                }

                MessageBox.Show("REGISTRATION ERROR: \n\n Add information for " + errFields );
            }

        }

        private void fnameTextBox_OnValueChanged(object sender, EventArgs e)
        {
            firstNameTextBox = (BunifuMaterialTextbox)sender;
            firstNameTextBox.ForeColor = Color.White;
            firstName = firstNameTextBox.Text;
        }

        private void mnameTextBox_OnValueChanged(object sender, EventArgs e)
        {
            middleNameTextBox = (BunifuMaterialTextbox)sender;
            middleNameTextBox.ForeColor = Color.White;
            middleName = middleNameTextBox.Text;
        }

        private void lnameTextBox_OnValueChanged(object sender, EventArgs e)
        {
            lastNameTextBox = (BunifuMaterialTextbox)sender;
            lastNameTextBox.ForeColor = Color.White;
            lastName = lastNameTextBox.Text;
        }

        private void addrTextBox_OnValueChanged(object sender, EventArgs e)
        {
            addressTextBox = (BunifuMaterialTextbox)sender;
            addressTextBox.ForeColor = Color.White;
            address = addressTextBox.Text;
        }

        private void bdayPicker_ValueChanged(object sender, EventArgs e)
        {
            birthdayPicker = (DateTimePicker)sender;
            birthday = birthdayPicker.Value;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contactNoTextBox_OnValueChanged(object sender, EventArgs e)
        {
            if(contactTextBox.Text.Length <= 11)
            {
                contactTextBox = (BunifuMaterialTextbox)sender;
                contactTextBox.ForeColor = Color.White;
                contact = contactTextBox.Text;
            } else
            {
                contactTextBox.Text = contact;
            }
            
        }

        private void contactNoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
          e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
          
        }
    }
}
