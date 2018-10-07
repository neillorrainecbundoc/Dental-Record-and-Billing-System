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
    public partial class PatientHistory : Form
    {
        DataGridViewRow row;
        private String searchText;

        public PatientHistory()
        {
            InitializeComponent();
        }

        public PatientHistory(DataGridViewRow dgvr)
        {
            InitializeComponent();
            row = dgvr;
            bunifuImageButton1.Enabled = false;
            label4.Text = row.Cells["First Name"].Value.ToString() + " " + row.Cells["Middle Name"].Value.ToString() + " " + row.Cells["Last Name"].Value.ToString();
            label5.Text = row.Cells["Patient Id"].Value.ToString();
            HistoryInit();
            
        }

        private void HistoryInit()
        {
            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            String query;
            if (string.IsNullOrEmpty(searchText) || string.IsNullOrWhiteSpace(searchText))
            {
                query = "SELECT service_quantity as 'Treatment', addtl_charge as 'Addtl Charge', discount as 'Discount' , totaldue as 'Total', cash_paid as 'Payment', DATE_FORMAT(date_created, '%M %d, %Y') as 'Date' from patient_history where patient_history.p_id = " + row.Cells["Patient Id"].Value.ToString().Replace("ADDC", "");
            }
            else
            {
                query = "SELECT service_quantity as 'Treatment', addtl_charge as 'Addtl Charge', discount as 'Discount' , totaldue as 'Total', cash_paid as 'Payment', DATE_FORMAT(date_created, '%M %d, %Y') as 'Date' from patient_history where patient_history.p_id = " + row.Cells["Patient Id"].Value.ToString().Replace("ADDC", "") + " and (service_quantity like '%" + searchText + "%' or addtl_charge like '%" + searchText + "%' or discount like '%" + searchText + "%' or totaldue like '%" + searchText + "%' or DATE_FORMAT(date_created, '%M %d, %Y %T') like '%" + searchText + "%')";
                
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
            dataGridView1.MultiSelect = false;

            if (dataGridView1.Rows.Count > 0)
            {
                notransfoundLabel.Hide();
            }
            else
            {
                notransfoundLabel.Show();
            }


        }
        //search (patient history)
        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            
            searchText = ((BunifuMaterialTextbox)sender).Text;
            HistoryInit();
        }

        private void bunifuMaterialTextbox1_Enter(object sender, EventArgs e)
        {
            srchlbl.Hide();
        }

        private void bunifuMaterialTextbox1_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(searchText) || string.IsNullOrWhiteSpace(searchText))
            {
                srchlbl.Show();
            }
        }
        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void srchlbl_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
