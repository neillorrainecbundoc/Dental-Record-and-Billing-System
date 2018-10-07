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
    public partial class RestorePatients : Form
    {
        String searchText;
        Dashboard d;

        public RestorePatients()
        {
            InitializeComponent();
            PatientInit();
        }

        public RestorePatients(Object e)
        {
            InitializeComponent();
            PatientInit();
            d = (Dashboard)e;
        }

        private void PatientInit()
        {
            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            String query;
            if (string.IsNullOrEmpty(searchText) || string.IsNullOrWhiteSpace(searchText))
            {
                query = "SELECT concat('ADDC', lpad(id, 4, '0')) as 'Patient ID', concat(firstname, ' ', middlename, ' ', lastname) as 'Name' from patients where isDeleted = true;";
            }
            else
            {
                query = "SELECT concat('ADDC', lpad(id, 4, '0')) as 'Patient ID', concat(firstname, ' ', middlename, ' ', lastname) as 'Name' from patients where isDeleted = true and (firstname like '%"+searchText+"%' or middlename like '%"+searchText+"%' or lastname like '%"+searchText+"%');";
            }
            MyDA.SelectCommand = new MySqlCommand(query, Main.dbconnection);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;

            dataGridView1.DataSource = bSource;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.MultiSelect = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (dataGridView1.Rows.Count > 0)
            {
                norecordfoundLabel.Hide();
            }
            else
            {
                norecordfoundLabel.Show();
            }
        }

        private void restoresearchTextBox_Enter(object sender, EventArgs e)
        {
            restoreptntsearchLabel.Hide();
        }

        private void restoresearchTextBox_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(searchText) || string.IsNullOrWhiteSpace(searchText)) {
                restoreptntsearchLabel.Show();
            }
        }

        private void restoresearchTextBox_OnValueChanged(object sender, EventArgs e)
        {
            searchText = ((BunifuMaterialTextbox)sender).Text;
            PatientInit();
        }

        private void restoreselectBtn_Click(object sender, EventArgs e)
        {
            var selectedRows = dataGridView1.SelectedRows.OfType<DataGridViewRow>()
                    .Where(row => !row.IsNewRow)
                    .ToArray();

            foreach (var row in selectedRows)
            {
                String id = dataGridView1.Rows[row.Index].Cells["Patient ID"].Value.ToString().Replace("ADDC", "");
                String query = "UPDATE patients SET isDeleted = false where id = " + id;
                MySqlCommand cmd = new MySqlCommand(query, Main.dbconnection);
                cmd.ExecuteScalar();
                dataGridView1.Rows.Remove(row);
            }

            dataGridView1.ClearSelection();
            d.PatientInitTable();
            this.Hide();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
