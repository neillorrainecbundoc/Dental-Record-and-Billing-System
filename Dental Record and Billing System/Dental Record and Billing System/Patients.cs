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
    public partial class Patients : Form
    {
        private static String searchText;
        private static Dashboard dashboard;

        public Patients()
        {
            InitializeComponent();
            PatientInitTable();
        }

        public Patients(Object e)
        {
            InitializeComponent();
            PatientInitTable();
            dashboard = (Dashboard)e;
        }

        private void PatientInitTable()
        {
            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            String query;
            if (string.IsNullOrEmpty(searchText) || string.IsNullOrWhiteSpace(searchText))
            {
                query = "SELECT concat('ADDC', lpad(id, 4, '0')) as 'Patient ID', concat(firstname, ' ', middlename, ' ', lastname) as Name from patients where isDeleted = false";
            }
            else
            {
                query = "SELECT concat('ADDC', lpad(id, 4, '0')) as 'Patient ID', concat(firstname, ' ', middlename, ' ', lastname) as Name from patients where isDeleted = false and (firstname like '%" + searchText + "%' or middlename like '%" + searchText + "%' or lastname like '%" + searchText + "%')";
            }
            MyDA.SelectCommand = new MySqlCommand(query, Main.dbconnection);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;

            dataGridView1.DataSource = bSource;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns["Name"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns["Patient ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (dataGridView1.Rows.Count > 0)
            {
                label2.Hide();
            }
            else
            {
                label2.Show();
            }
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            searchText = ((BunifuMaterialTextbox)sender).Text;
            bunifuMaterialTextbox1.ForeColor = Color.White;
            PatientInitTable();
        }

        private void bunifuMaterialTextbox1_Enter(object sender, EventArgs e)
        {
            label1.Hide();
        }

        private void bunifuMaterialTextbox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchText))
            {
                label1.Show();
            }
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                int index = dataGridView1.SelectedRows[i].Index;
                DataGridViewRow patient = dataGridView1.Rows[index];
                String id = patient.Cells["Patient ID"].Value.ToString();
                String name = patient.Cells["Name"].Value.ToString();
                dashboard.setPatient(name, id);
            }
            this.Hide();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
