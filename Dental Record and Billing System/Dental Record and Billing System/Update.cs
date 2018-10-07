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
    public partial class Update : Form
    {
        private DataGridViewRow row;
        private Dashboard dboard;
        private String patientId;
        private String contact;

        public Update()
        {
            InitializeComponent();
        }

            public Update(DataGridViewRow e, Dashboard db)
            {
                InitializeComponent();
                row = e;
                dboard = db;

                patientId = row.Cells["Patient Id"].Value.ToString().Replace("ADDC", "");
                fnameTextBox.Text = row.Cells["First Name"].Value.ToString();
                mnameTextBox.Text = row.Cells["Middle Name"].Value.ToString();
                lnameTextBox.Text = row.Cells["Last Name"].Value.ToString();
                addrTextBox.Text = row.Cells["Address"].Value.ToString();
                contactNoTextBox.Text = row.Cells["Contact #"].Value.ToString();
                bdayPicker.Value = DateTime.Parse(row.Cells["Birthday"].Value.ToString());

                fnameTextBox.ForeColor = Color.White;
                mnameTextBox.ForeColor = Color.White;
                lnameTextBox.ForeColor = Color.White;
                addrTextBox.ForeColor = Color.White;
                contactNoTextBox.ForeColor = Color.White;

                fnameTextBox.Enabled = false;
                mnameTextBox.Enabled = false;
                lnameTextBox.Enabled = false;
                bdayPicker.Enabled = false;
            }

        private void addPatientBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void fnameTextBox_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Update_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void upbtn_Click(object sender, EventArgs e)
        {
            if (contactNoTextBox.Text.Length == 11 && !string.IsNullOrEmpty(addrTextBox.Text) && !string.IsNullOrEmpty(contactNoTextBox.Text))
            {
                String query = "UPDATE patients SET address = '" + addrTextBox.Text + "', contact = '" + contactNoTextBox.Text + "' where id = " + patientId + ";";
                MySqlCommand cmd1 = new MySqlCommand(query, Main.dbconnection);
                cmd1.ExecuteScalar();
                dboard.PatientInitTable();
                MessageBox.Show("Patient updated!");
                this.Hide();
            } else
            {
                String errFields = "";

                if (string.IsNullOrEmpty(addrTextBox.Text))
                {
                    errFields += "Address ";
                }
                if (string.IsNullOrEmpty(contactNoTextBox.Text))
                {
                    errFields += "Contact ";
                }
                if (contactNoTextBox.Text.Length != 11)
                {
                    errFields += "Contact length";
                }

                MessageBox.Show("UPDATE PATIENT ERROR: \n\n Fix information for " + errFields);
            }
            
            
        }

        private void contactNoTextBox_OnValueChanged(object sender, EventArgs e)
        {
            if (contactNoTextBox.Text.Length <= 11)
            {
                contactNoTextBox = (BunifuMaterialTextbox)sender;
                contactNoTextBox.ForeColor = Color.White;
                contact = contactNoTextBox.Text;
            }
            else
            {
                contactNoTextBox.Text = contact;
            }
        }

        private void contactNoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void addrTextBox_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
