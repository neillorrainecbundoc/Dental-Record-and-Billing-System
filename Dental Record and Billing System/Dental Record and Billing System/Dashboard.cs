using Bunifu.Framework.UI;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Record_and_Billing_System
{
    public partial class Dashboard : Form
    {
        public static String category;
        private static String searchText;
        private static String searchServices;
        private static String fromtimeSelected;
        private static String totimeSelected;
        private static Boolean dropdownusername = false;
        
        private static DateTime ebirthday;
        private static DateTimePicker birthdayPicker;
        private Boolean isBalance = false;
        private String balance_id = "";

        public Dashboard()
        {
            InitializeComponent();
            PatientInitTable();
            AppointmentInitTable();
            panel4.BringToFront();
            THinitTable();
            SignupInitTable();
            bunifuThinButton22.IdleFillColor = Color.FromArgb(189, 94, 189);
            fillCategoryDropDownInit(false, "");
            bunifuImageButton5.Enabled = false;
            bunifuImageButton2.Enabled = false;
            bunifuImageButton7.Enabled = false;
            savepymntBtn.Enabled = false;
            disableEnableTime();
            label1.Text = "0";
        }

        // Grid Views patient
        public void PatientInitTable()
        {
            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            String query;
            if (string.IsNullOrEmpty(searchText) || string.IsNullOrWhiteSpace(searchText))
            {
                query = "SELECT concat('ADDC', lpad(id, 4, '0')) as 'Patient ID', firstname as 'First Name', middlename as 'Middle Name', lastname as 'Last Name', address as 'Address', DATE_FORMAT(birthday, '%M %d, %Y') as 'Birthday', contact as 'Contact #' from patients where isDeleted = false";
            }
            else
            {
                query = "SELECT concat('ADDC', lpad(id, 4, '0')) as 'Patient ID', firstname as 'First Name', middlename as 'Middle Name', lastname as 'Last Name', address as 'Address', DATE_FORMAT(birthday, '%M %d, %Y') as 'Birthday', contact as 'Contact #' from patients where isDeleted = false and (firstname like '%" + searchText + "%' or middlename like '%" + searchText + "%' or lastname like '%" + searchText + "%' or address like '%" + searchText + "%' or DATE_FORMAT(birthday, '%M %d, %Y') like '%" + searchText + "%' or contact like '%" + searchText + "%')";
            }
            MyDA.SelectCommand = new MySqlCommand(query, Main.dbconnection);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;

            patientGridView.DataSource = bSource;
            patientGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            patientGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            patientGridView.BackgroundColor = Color.White;
            patientGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            patientGridView.Columns["First Name"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            patientGridView.Columns["Middle Name"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            patientGridView.Columns["Last Name"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            patientGridView.Columns["Address"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            patientGridView.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            patientGridView.DefaultCellStyle.SelectionForeColor = Color.Black;
            patientGridView.ReadOnly = true;
            patientGridView.RowHeadersVisible = false;
            patientGridView.AllowUserToResizeColumns = false;
            patientGridView.AllowUserToResizeRows = false;
            patientGridView.AllowUserToDeleteRows = false;
            patientGridView.AllowUserToAddRows = false;
            patientGridView.MultiSelect = true;
            patientGridView.ShowEditingIcon = true;
            patientGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (patientGridView.Rows.Count > 0)
            {
                noRecordFoundLabel.Hide();
            }
            else
            {
                noRecordFoundLabel.Show();
            }
        }

        // GridView Services 
        public void ServicesInitTable(String category)
        {
            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            String query;
            if (string.IsNullOrEmpty(searchServices) || string.IsNullOrWhiteSpace(searchServices))
            {
                query = "SELECT  sub_services.name, sub_services.amount from sub_services join services on sub_services.svc_id = services.id where services.name = '" + category + "'";
            }
            else
            {
                query = "SELECT  sub_services.name, sub_services.amount from sub_services join services on sub_services.svc_id = services.id where services.name = '" + category + "' and (sub_services.name like '%" + searchServices + "%' or sub_services.amount  like '%" + searchServices + "%')";
            }

            MyDA.SelectCommand = new MySqlCommand(query, Main.dbconnection);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;

            servicesGridView.DataSource = bSource;
            servicesGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            servicesGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            servicesGridView.BackgroundColor = Color.White;
            servicesGridView.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            servicesGridView.DefaultCellStyle.SelectionForeColor = Color.Black;
            servicesGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            servicesGridView.ReadOnly = true;
            servicesGridView.RowHeadersVisible = false;
            servicesGridView.AllowUserToResizeColumns = false;
            servicesGridView.AllowUserToResizeRows = false;
            servicesGridView.AllowUserToDeleteRows = false;
            servicesGridView.AllowUserToAddRows = false;
            servicesGridView.MultiSelect = false;
            servicesGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (servicesGridView.Rows.Count > 0)
            {
                noRecordFoundLabelSvc.Hide();
            }
            else
            {
                noRecordFoundLabelSvc.Show();
            }
        }

        // Buttons (Patient)
        //add
        private void addPatientBtn_Click(object sender, EventArgs e)
        {
            Register register = new Register(this);
            register.Show();

        }
        //delete
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deletePatientBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Are you sure you want to delete the record?", "Warning!", MessageBoxButtons.YesNo);
            if (dialogresult == DialogResult.Yes)
            {

                for (int i = 0; i < patientGridView.SelectedRows.Count; i++)
                {   
                    int index = patientGridView.SelectedRows[i].Index;
                    DataGridViewRow patient = patientGridView.Rows[index];
                    String id = patient.Cells["Patient Id"].Value.ToString();
                    id = id.Replace("ADDC", "");
                    String query = "UPDATE patients SET isDeleted = true where id like " + id;
                    MySqlCommand cmd = new MySqlCommand(query, Main.dbconnection);
                    cmd.ExecuteNonQuery();
                }
                PatientInitTable();
            }

        }

        //search (patient)
        private void searchTextBox_OnValueChanged(object sender, EventArgs e)
        {
            searchTextBox = (BunifuMaterialTextbox)sender;
            searchText = searchTextBox.Text;
            PatientInitTable();
        }

        private void searchTextBox_Enter(object sender, EventArgs e)
        {
            searchPatientLabel.Hide();
        }

        private void searchTextBox_Leave(object sender, EventArgs e)
        {
            if (searchTextBox.Text.Length == 0)
            {
                searchPatientLabel.Show();
            }
        }

        // Payment
        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            AddTransaction addTransaction = new AddTransaction(this);
            addTransaction.Show();
        }

        //Transaction // name and id
        public void setPatient(String name, String id)
        {
            label3.Text = name;
            ptntpaymentLabel.Text = id;
            bunifuImageButton2.Enabled = true;
            bunifuImageButton5.Enabled = true;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        { // show patient list
            Patients patients = new Patients(this);
            patients.Show();
        }

        // Dashboard Button
        private void patientLogo_Click_1(object sender, EventArgs e)
        {

            servicesLogo.IdleFillColor = Color.DimGray;
            paymentLogo.IdleFillColor = Color.DimGray;
            bunifuThinButton22.IdleFillColor = Color.DimGray;
            bunifuThinButton24.IdleFillColor = Color.DimGray;
            patientLogo.IdleFillColor = Color.FromArgb(189, 94, 189);
            bunifuThinButton212.IdleFillColor = Color.DimGray;
            bunifuThinButton215.IdleFillColor = Color.DimGray;
            patientPanel.BringToFront();
        }

        private void servicesLogo_Click_1(object sender, EventArgs e)
        {

            servicesLogo.IdleFillColor = Color.FromArgb(189, 94, 189);
            paymentLogo.IdleFillColor = Color.DimGray;
            bunifuThinButton22.IdleFillColor = Color.DimGray;
            bunifuThinButton24.IdleFillColor = Color.DimGray;
            patientLogo.IdleFillColor = Color.DimGray;
            bunifuThinButton212.IdleFillColor = Color.DimGray;
            bunifuThinButton215.IdleFillColor = Color.DimGray;
            servicesPanel.BringToFront();
            ServicesInitTable(category);
        }

        private void paymentLogo_Click_1(object sender, EventArgs e)
        {

            paymentGridView.Columns.Clear();
            paymentGridView.Rows.Clear();

            servicesLogo.IdleFillColor = Color.DimGray;
            paymentLogo.IdleFillColor = Color.FromArgb(189, 94, 189);
            bunifuThinButton22.IdleFillColor = Color.DimGray;
            bunifuThinButton24.IdleFillColor = Color.DimGray;
            patientLogo.IdleFillColor = Color.DimGray;
            bunifuThinButton212.IdleFillColor = Color.DimGray;
            bunifuThinButton215.IdleFillColor = Color.DimGray;
            paymentPanel.BringToFront();
            label3.Text = "";
            ptntpaymentLabel.Text = "";
            label1.Text = "0.00";
            isBalance = false;
            balance_id = "";
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

            servicesLogo.IdleFillColor = Color.DimGray;
            paymentLogo.IdleFillColor = Color.DimGray;
            bunifuThinButton22.IdleFillColor = Color.FromArgb(189, 94, 189);
            bunifuThinButton24.IdleFillColor = Color.DimGray;
            patientLogo.IdleFillColor = Color.DimGray;
            bunifuThinButton212.IdleFillColor = Color.DimGray;
            bunifuThinButton215.IdleFillColor = Color.DimGray;
            panel4.BringToFront();
            AppointmentInitTable();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            servicesLogo.IdleFillColor = Color.DimGray;
            paymentLogo.IdleFillColor = Color.DimGray;
            bunifuThinButton22.IdleFillColor = Color.DimGray;
            bunifuThinButton24.IdleFillColor = Color.FromArgb(189, 94, 189);
            patientLogo.IdleFillColor = Color.DimGray;
            bunifuThinButton212.IdleFillColor = Color.DimGray;
            bunifuThinButton215.IdleFillColor = Color.DimGray;
            panel7.BringToFront();
            BalanceInitTable();
        }

        private void bunifuThinButton212_Click(object sender, EventArgs e)
        {
            servicesLogo.IdleFillColor = Color.DimGray;
            paymentLogo.IdleFillColor = Color.DimGray;
            bunifuThinButton22.IdleFillColor = Color.DimGray;
            bunifuThinButton24.IdleFillColor = Color.DimGray;
            patientLogo.IdleFillColor = Color.DimGray;
            bunifuThinButton212.IdleFillColor = Color.FromArgb(189, 94, 189);
            bunifuThinButton215.IdleFillColor = Color.DimGray;
            panel10.BringToFront();
        }


        private void bunifuThinButton215_Click(object sender, EventArgs e)
        {
            servicesLogo.IdleFillColor = Color.DimGray;
            paymentLogo.IdleFillColor = Color.DimGray;
            bunifuThinButton22.IdleFillColor = Color.DimGray;
            bunifuThinButton24.IdleFillColor = Color.DimGray;
            patientLogo.IdleFillColor = Color.DimGray;
            bunifuThinButton212.IdleFillColor = Color.DimGray;
            bunifuThinButton215.IdleFillColor = Color.FromArgb(189, 94, 189);
            panel11.BringToFront();
        }

        //Payment
        private void cashTextBox_TextChanged(object sender, EventArgs e)
        {
            cashTextBox.Text = cashTextBox.Text.Replace(Environment.NewLine, "");
            if (string.IsNullOrEmpty(cashTextBox.Text) || string.IsNullOrWhiteSpace(cashTextBox.Text))
            {
                label2.Text = "";
                label11.Text = "";
                savepymntBtn.Enabled = false;
            }
            if (!Regex.IsMatch(cashTextBox.Text, "^\\d+(\\.?)\\d*$"))
            {
                if (!string.IsNullOrEmpty(cashTextBox.Text))
                {
                    MessageBox.Show("Enter DIGITS only.");
                    cashTextBox.Text = "";
                    label2.Text = "";
                    label11.Text = "";
                    savepymntBtn.Enabled = false;
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(cashTextBox.Text) && !string.IsNullOrWhiteSpace(cashTextBox.Text))
                {
                    double due = double.Parse(label1.Text);
                    double cash = double.Parse(cashTextBox.Text);
                    double dis = 0;
                    if (!string.IsNullOrEmpty(discount.Text) && !string.IsNullOrWhiteSpace(discount.Text))
                    {
                      dis = double.Parse(discount.Text);
                    }
                    double addtl = 0; 
                    if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text))
                    {
                        addtl = double.Parse(textBox1.Text);
                    }
                    due = due + addtl;
                    label2.Text = (cash + dis - due).ToString();
                    if((cash + dis - due) < 0)
                    {
                        label2.Text = "0";
                        label11.Text = ((cash - due + dis) * -1).ToString();
                    } else
                    {
                        label2.Text = (cash + dis - due).ToString();
                        label11.Text = "0";
                    }
                    savepymntBtn.Enabled = true;
                }
                else
                {
                    label2.Text = "";
                    label11.Text = "";
                    savepymntBtn.Enabled = false;
                }
            }
        }

        //Transaction
        public void addTransaction(string treatment, decimal qty, double basePay, double addtlCharge)
        {

            paymentGridView.ColumnCount = 3;
            paymentGridView.Columns[0].Name = "Treatment";
            paymentGridView.Columns[1].Name = "Quantity";
            paymentGridView.Columns[2].Name = "Amount";

            double subtotal = (basePay) * (decimal.ToDouble(qty));
            paymentGridView.Rows.Add(treatment, qty, subtotal);

            paymentGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            paymentGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            paymentGridView.BackgroundColor = Color.White;
            paymentGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            paymentGridView.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            paymentGridView.DefaultCellStyle.SelectionForeColor = Color.Black;
            paymentGridView.ReadOnly = true;
            paymentGridView.RowHeadersVisible = false;
            paymentGridView.AllowUserToResizeColumns = false;
            paymentGridView.AllowUserToResizeRows = false;
            paymentGridView.AllowUserToDeleteRows = false;
            paymentGridView.AllowUserToAddRows = false;
            paymentGridView.MultiSelect = true;
            paymentGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            double total = Double.Parse(label1.Text) + subtotal;
            label1.Text = total.ToString();
        }

        //deletebutton payment
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Are you sure you want to delete the record?", "Warning!", MessageBoxButtons.YesNo);
            if (dialogresult == DialogResult.Yes)
            {

                var selectedRows = paymentGridView.SelectedRows.OfType<DataGridViewRow>()
                    .Where(row => !row.IsNewRow)
                    .ToArray();

                foreach (var row in selectedRows)
                {
                    double subtotal = Double.Parse(row.Cells[3].Value.ToString());
                    double total = Double.Parse(label1.Text) - subtotal;
                    label1.Text = total.ToString();
                    paymentGridView.Rows.Remove(row);
                }

                paymentGridView.ClearSelection();
            }
        }

        //Patient History
        private void patientGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            var selectedRows = ((DataGridView)sender).SelectedRows.OfType<DataGridViewRow>()
                    .Where(row => !row.IsNewRow)
                    .ToArray();

            foreach (var row in selectedRows)
            {
                Console.WriteLine("Row ==> {0}", row.Index);
                PatientHistory ph = new PatientHistory(patientGridView.Rows[row.Index]);
                ph.Show();
            }
        }

        //restore
        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            RestorePatients rp = new RestorePatients(this);
            rp.Show();
        }

        //Logout
        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }

        //update(patient)
        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {

            var selectedRows = patientGridView.SelectedRows.OfType<DataGridViewRow>()
                   .Where(row => !row.IsNewRow)
                   .ToArray();

            int count = selectedRows.Length;
            if (count == 1)
            {
                foreach (var row in selectedRows)
                {

                    Update up = new Update(row, this);
                    up.Show();

                }

            }
            else
            {
                MessageBox.Show("Select only 1 patient to update.");
            }
        }

        //searchservicestextbox
        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            searchServices = ((BunifuMaterialTextbox)sender).Text;
            ServicesInitTable(category);

        }

        private void bunifuMaterialTextbox1_Enter(object sender, EventArgs e)
        {
            label4.Hide();
        }

        private void bunifuMaterialTextbox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchServices) || string.IsNullOrWhiteSpace(searchServices))
            {
                label4.Show();
            }
        }

        //date and time
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Date.Text = DateTime.Now.ToLongDateString();
            Time.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time.Text = DateTime.Now.ToLongTimeString();
        }

        //TOOLTIP LABELBUTTON
        private void patientPanel_Paint(object sender, PaintEventArgs e)
        {
            toolTip1.SetToolTip(addPatientBtn, "Add Patient");
            toolTip1.SetToolTip(bunifuImageButton6, "Update Patient");
            toolTip1.SetToolTip(deletePatientBtn, "Delete");
            toolTip1.SetToolTip(bunifuImageButton3, "Archive Patients");
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            toolTip1.SetToolTip(bunifuImageButton4, "Search");
        }

        private void servicesPanel_Paint(object sender, PaintEventArgs e)
        {
            toolTip1.SetToolTip(bunifuImageButton9, "Add Category");
            toolTip1.SetToolTip(bunifuImageButton8, "Add Services");
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            toolTip1.SetToolTip(bunifuImageButton10, "Proceed to Payment");
        }

        //Appointment iteeeeey!!
        private void bunifuImageButton4_Click_1(object sender, EventArgs e)
        {
            PatientAppointment PA = new PatientAppointment(this);
            PA.Show();
        }

        public void setPatientAppointment(string name, String id)
        {
            label12.Text = name;
            label15.Text = id;
        }

        public void AppointmentInitTable()
        {
            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            String query;
            query = "SELECT  concat('ADDC', lpad(p.id, 4, '0')) as 'Patient ID', concat(p.firstname, ' ', p.middlename, ' ', p.lastname) as 'Name' , DATE_FORMAT(a.dates, '%M %d, %Y') as 'Date', concat(a.fromTimeSelected, '-', a.toTimeSelected) as 'Time' from appointments a join patients p on a.k_id = p.id where isDone = false";

            MyDA.SelectCommand = new MySqlCommand(query, Main.dbconnection);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;

            appointmentdatagridview.DataSource = bSource;
            appointmentdatagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            appointmentdatagridview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            appointmentdatagridview.BackgroundColor = Color.White;
            appointmentdatagridview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            appointmentdatagridview.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            appointmentdatagridview.DefaultCellStyle.SelectionForeColor = Color.Black;
            appointmentdatagridview.ReadOnly = true;
            appointmentdatagridview.RowHeadersVisible = false;
            appointmentdatagridview.AllowUserToResizeColumns = false;
            appointmentdatagridview.AllowUserToResizeRows = false;
            appointmentdatagridview.AllowUserToDeleteRows = false;
            appointmentdatagridview.AllowUserToAddRows = false;
            appointmentdatagridview.MultiSelect = true;
            appointmentdatagridview.ShowEditingIcon = true;
            appointmentdatagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (appointmentdatagridview.Rows.Count > 0)
            {
                label14.Hide();
            }
            else
            {
               label14.Show();
            }
        }

        private void addpatientsbtn_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(label15.Text) && !string.IsNullOrEmpty(dateTimePicker1.Value.ToLongDateString()) && !string.IsNullOrEmpty(fromtimeSelected) && !string.IsNullOrEmpty(totimeSelected))
            {
                MySqlCommand cmd = Main.dbconnection.CreateCommand();
                cmd.CommandText = "insert into appointments (k_id, dates, fromTimeSelected, toTimeSelected) value (?k_id, ?dates, ?fromTimeSelected, ?toTimeSelected)";

                cmd.Parameters.AddWithValue("@k_id", label15.Text.Replace("ADDC", ""));
                cmd.Parameters.AddWithValue("@dates", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@fromTimeSelected", fromtimeSelected);
                cmd.Parameters.AddWithValue("@toTimeSelected", totimeSelected);
                cmd.Parameters.AddWithValue("@isDone", Boolean.FalseString);

                try
                {
                    cmd.ExecuteNonQuery();

                    label12.Text = "";
                    label15.Text = "";
                    dateTimePicker1.Value = DateTime.Now;
                    totimeSelected = null;
                    fromtimeSelected = null;

                    MessageBox.Show("Appointment Added!");
                    AppointmentInitTable();
                }
                catch (Exception err)
                {
                    Console.WriteLine("Error appointment insert into database {0}", err);
                }
            }
            else
            {
                String errFields = "";

                if (string.IsNullOrEmpty(label15.Text))
                {
                    errFields += "Patient ID";
                }
                if (string.IsNullOrEmpty(dateTimePicker1.Value.ToLongDateString()))
                {
                    errFields += ", Date";
                }
                if (string.IsNullOrEmpty(fromtimeSelected) || string.IsNullOrEmpty(totimeSelected))
                {
                    errFields += ", Time";
                }
                MessageBox.Show("ERROR: \n\n Add information for " + errFields + " fields.");
            }
            

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            if(bunifuThinButton25.Enabled)
            {
                bunifuThinButton25.IdleFillColor = Color.FromArgb(189, 94, 189);
                bunifuThinButton26.IdleFillColor = Color.Gray;
                bunifuThinButton27.IdleFillColor = Color.Gray;
                bunifuThinButton28.IdleFillColor = Color.Gray;
                bunifuThinButton29.IdleFillColor = Color.Gray;
                bunifuThinButton210.IdleFillColor = Color.Gray;
                bunifuThinButton211.IdleFillColor = Color.Gray;
                fromtimeSelected = "9:00";
                totimeSelected = "10:00";
            }
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            if (bunifuThinButton26.Enabled)
            {
                bunifuThinButton25.IdleFillColor = Color.Gray;
                bunifuThinButton26.IdleFillColor = Color.FromArgb(189, 94, 189);
                bunifuThinButton27.IdleFillColor = Color.Gray;
                bunifuThinButton28.IdleFillColor = Color.Gray;
                bunifuThinButton29.IdleFillColor = Color.Gray;
                bunifuThinButton210.IdleFillColor = Color.Gray;
                bunifuThinButton211.IdleFillColor = Color.Gray;
                fromtimeSelected = "10:00";
                totimeSelected = "11:00";
            }
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            if (bunifuThinButton27.Enabled)
            {
                bunifuThinButton25.IdleFillColor = Color.Gray;
                bunifuThinButton26.IdleFillColor = Color.Gray;
                bunifuThinButton27.IdleFillColor = Color.FromArgb(189, 94, 189);
                bunifuThinButton28.IdleFillColor = Color.Gray;
                bunifuThinButton29.IdleFillColor = Color.Gray;
                bunifuThinButton210.IdleFillColor = Color.Gray;
                bunifuThinButton211.IdleFillColor = Color.Gray;
                fromtimeSelected = "11:00";
                totimeSelected = "12:00";
            }
        }

        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            if (bunifuThinButton28.Enabled)
            {
                bunifuThinButton25.IdleFillColor = Color.Gray;
                bunifuThinButton26.IdleFillColor = Color.Gray;
                bunifuThinButton27.IdleFillColor = Color.Gray;
                bunifuThinButton28.IdleFillColor = Color.FromArgb(189, 94, 189);
                bunifuThinButton29.IdleFillColor = Color.Gray;
                bunifuThinButton210.IdleFillColor = Color.Gray;
                bunifuThinButton211.IdleFillColor = Color.Gray;
                fromtimeSelected = "1:00";
                totimeSelected = "2:00";
            }
        }

        private void bunifuThinButton29_Click(object sender, EventArgs e)
        {
            if (bunifuThinButton29.Enabled)
            {
                bunifuThinButton25.IdleFillColor = Color.Gray;
                bunifuThinButton26.IdleFillColor = Color.Gray;
                bunifuThinButton27.IdleFillColor = Color.Gray;
                bunifuThinButton28.IdleFillColor = Color.Gray;
                bunifuThinButton29.IdleFillColor = Color.FromArgb(189, 94, 189);
                bunifuThinButton210.IdleFillColor = Color.Gray;
                bunifuThinButton211.IdleFillColor = Color.Gray;
                fromtimeSelected = "2:00";
                totimeSelected = "3:00";
            }
        }

        private void bunifuThinButton210_Click(object sender, EventArgs e)
        {
            if (bunifuThinButton210.Enabled)
            {
                bunifuThinButton25.IdleFillColor = Color.Gray;
                bunifuThinButton26.IdleFillColor = Color.Gray;
                bunifuThinButton27.IdleFillColor = Color.Gray;
                bunifuThinButton28.IdleFillColor = Color.Gray;
                bunifuThinButton29.IdleFillColor = Color.Gray;
                bunifuThinButton210.IdleFillColor = Color.FromArgb(189, 94, 189);
                bunifuThinButton211.IdleFillColor = Color.Gray;
                fromtimeSelected = "3:00";
                totimeSelected = "4:00";
            }
        }

        private void bunifuThinButton211_Click(object sender, EventArgs e)
        {
            if (bunifuThinButton211.Enabled)
            {
                bunifuThinButton25.IdleFillColor = Color.Gray;
                bunifuThinButton26.IdleFillColor = Color.Gray;
                bunifuThinButton27.IdleFillColor = Color.Gray;
                bunifuThinButton28.IdleFillColor = Color.Gray;
                bunifuThinButton29.IdleFillColor = Color.Gray;
                bunifuThinButton210.IdleFillColor = Color.Gray;
                bunifuThinButton211.IdleFillColor = Color.FromArgb(189, 94, 189);
                fromtimeSelected = "4:00";
                totimeSelected = "5:00";
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value < DateTime.Today)
            {
                dateTimePicker1.Value = DateTime.Today;
            }

            disableEnableTime();
        }

        private void disableEnableTime()
        {
            // 9 am
            string query;
            query = "SELECT count(*) from appointments where DATE(dates) = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' and fromTimeSelected = '9:00'";
            MySqlCommand cmd = new MySqlCommand(query, Main.dbconnection);
            Object count = cmd.ExecuteScalar();

            if (Convert.ToInt32(count) > 0)
            {
                bunifuThinButton25.Enabled = false;
            } else
            {
                bunifuThinButton25.Enabled = true;
            }

            // 10am
            query = "SELECT count(*) from appointments where DATE(dates) = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' and fromTimeSelected = '10:00'";
            cmd = new MySqlCommand(query, Main.dbconnection);
            count = cmd.ExecuteScalar();

            if (Convert.ToInt32(count) > 0)
            {
                bunifuThinButton26.Enabled = false;
            } else
            {
                bunifuThinButton26.Enabled = true;
            }

            // 11am
            query = "SELECT count(*) from appointments where DATE(dates) = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' and fromTimeSelected = '11:00'";
            cmd = new MySqlCommand(query, Main.dbconnection);
            count = cmd.ExecuteScalar();

            if (Convert.ToInt32(count) > 0)
            {
                bunifuThinButton27.Enabled = false;
            }
            else
            {
                bunifuThinButton27.Enabled = true;
            }

            // 1pm
            query = "SELECT count(*) from appointments where DATE(dates) = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' and fromTimeSelected = '1:00'";
            cmd = new MySqlCommand(query, Main.dbconnection);
            count = cmd.ExecuteScalar();

            if (Convert.ToInt32(count) > 0)
            {
                bunifuThinButton28.Enabled = false;
            }
            else
            {
                bunifuThinButton28.Enabled = true;
            }

            // 2pm
            query = "SELECT count(*) from appointments where DATE(dates) = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' and fromTimeSelected = '2:00'";
            cmd = new MySqlCommand(query, Main.dbconnection);
            count = cmd.ExecuteScalar();

            if (Convert.ToInt32(count) > 0)
            {
                bunifuThinButton29.Enabled = false;
            }
            else
            {
                bunifuThinButton29.Enabled = true;
            }

            // 3pm
            query = "SELECT count(*) from appointments where DATE(dates) = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' and fromTimeSelected = '3:00'";
            cmd = new MySqlCommand(query, Main.dbconnection);
            count = cmd.ExecuteScalar();

            if (Convert.ToInt32(count) > 0)
            {
                bunifuThinButton210.Enabled = false;
            }
            else
            {
                bunifuThinButton210.Enabled = true;
            }

            // 4pm
            query = "SELECT count(*) from appointments where DATE(dates) = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "' and fromTimeSelected = '4:00'";
            cmd = new MySqlCommand(query, Main.dbconnection);
            count = cmd.ExecuteScalar();

            if (Convert.ToInt32(count) > 0)
            {
                bunifuThinButton211.Enabled = false;
            }
            else
            {
                bunifuThinButton211.Enabled = true;
            }

        }
        //services category
        public void fillCategoryDropDownInit(Boolean addRefresh, String choiceCategory)
        {
            bunifuDropdown1.Clear();
            String query = "SELECT name from services";
            MySqlCommand cmd = new MySqlCommand(query, Main.dbconnection);

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                int i = 0;
                int index = 0;
                while (reader.Read())
                {
                    String cat = reader.GetString(0);
                    bunifuDropdown1.AddItem(cat);
                    if(cat.Equals(choiceCategory)) {
                        index = i;
                    }
                    i++;
                }
                reader.Close();

                if(!addRefresh)
                {
                    bunifuDropdown1.selectedIndex = 0;
                    category = bunifuDropdown1.selectedValue;
                } else
                {
                    bunifuDropdown1.selectedIndex = index;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error {0}", e);
            }
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {
            category = bunifuDropdown1.selectedValue;
            ServicesInitTable(category);
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            AddServices addservices = new AddServices(this);
            addservices.Show();
        }
        
        private void bunifuImageButton9_Click_1(object sender, EventArgs e)
        {
            AddCategory addcategory = new AddCategory(this);
            addcategory.Show();
        }

        private void discount_TextChanged(object sender, EventArgs e)
        {
            discount.Text = discount.Text.Replace(Environment.NewLine, "");
            if (string.IsNullOrEmpty(discount.Text) || string.IsNullOrWhiteSpace(discount.Text))
            {
                discount.Text = "";
            }
            if (!Regex.IsMatch(discount.Text, "^\\d+(\\.?)\\d*$"))
            {
                if (!string.IsNullOrEmpty(discount.Text))
                {
                    MessageBox.Show("Enter DIGITS only.");
                    discount.Text = "";
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Replace(Environment.NewLine, "");
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "";
            }
            if (!Regex.IsMatch(textBox1.Text, "^\\d+(\\.?)\\d*$"))
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Enter DIGITS only.");
                    textBox1.Text = "";
                }
            }
        }

        //Balance DataGridView
        public void BalanceInitTable()
        {
            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            String query;
            if (string.IsNullOrEmpty(searchText) || string.IsNullOrWhiteSpace(searchText))
            {
                query = "Select concat('ADDC', lpad(p.id,4, '0')) as 'Patient ID', concat(p.firstname, ' ', p.middlename, ' ', p.lastname) as 'Name',  b.ph_id as 'Transaction ID', ph.service_quantity as 'Treatment', ph.totaldue as 'Total Due', b.total_balance as 'Balance' from balance b inner join patients p on b.p_id = p.id inner join patient_history ph on b.ph_id = ph.id and total_balance > 0; ";
            }
            else
            {
                query = "Select concat('ADDC', lpad(p.id,4, '0')) as 'Patient ID', concat(p.firstname, ' ', p.middlename, ' ', p.lastname) as 'Name', b.ph_id as 'Transaction ID', ph.service_quantity as 'Treatment', ph.totaldue as 'Total Due', b.total_balance as 'Balance' from balance b inner join patients p on b.p_id = p.id inner join patient_history ph on b.ph_id = ph.id and total_balance > 0 and (p.firstname like '%" + searchText + "%' or p.middlename like '%" + searchText + "%' or p.lastname like '%" + searchText + "%')";
            }
            MyDA.SelectCommand = new MySqlCommand(query, Main.dbconnection);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;

            balanceDataGrid.DataSource = bSource;
            balanceDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            balanceDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            balanceDataGrid.BackgroundColor = Color.White;
            balanceDataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            balanceDataGrid.Columns["Patient ID"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            balanceDataGrid.Columns["Name"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            balanceDataGrid.Columns["Transaction ID"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            balanceDataGrid.Columns["Treatment"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            balanceDataGrid.Columns["Total Due"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            balanceDataGrid.Columns["Balance"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            balanceDataGrid.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            balanceDataGrid.DefaultCellStyle.SelectionForeColor = Color.Black;
            balanceDataGrid.ReadOnly = true;
            balanceDataGrid.RowHeadersVisible = false;
            balanceDataGrid.AllowUserToResizeColumns = false;
            balanceDataGrid.AllowUserToResizeRows = false;
            balanceDataGrid.AllowUserToDeleteRows = false;
            balanceDataGrid.AllowUserToAddRows = false;
            balanceDataGrid.MultiSelect = true;
            balanceDataGrid.ShowEditingIcon = true;
            balanceDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (balanceDataGrid.Rows.Count > 0)
            {
                label20.Hide();
            }
            else
            {
                label20.Show();
            }
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {
            searchTextBox = (BunifuMaterialTextbox)sender;
            searchText = searchTextBox.Text;
            BalanceInitTable();
        }

        private void bunifuMaterialTextbox2_Enter(object sender, EventArgs e)
        {
            srchlbl.Hide();        }

        private void bunifuMaterialTextbox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchText) || string.IsNullOrWhiteSpace(searchText))
            {
                srchlbl.Show();
            }
        }

        private void bunifuImageButton10_Click(object sender, EventArgs e)
        {
            String id = "0";
            String ph_id = "0";
            for (int i = 0; i < balanceDataGrid.SelectedRows.Count; i++)
            {
                int index = balanceDataGrid.SelectedRows[i].Index;
                DataGridViewRow balance = balanceDataGrid.Rows[index];
                id = balance.Cells["Patient ID"].Value.ToString();
                id = id.Replace("ADDC", "");
                ph_id = balance.Cells["Transaction ID"].Value.ToString();
            }
            isBalance = true;
            servicesLogo.IdleFillColor = Color.DimGray;
            paymentLogo.IdleFillColor = Color.FromArgb(189, 94, 189);
            bunifuThinButton22.IdleFillColor = Color.DimGray;
            bunifuThinButton24.IdleFillColor = Color.DimGray;
            patientLogo.IdleFillColor = Color.DimGray;
            paymentPanel.BringToFront();
            label3.Text = "";
            ptntpaymentLabel.Text = "";
            label1.Text = "0.00";

            String query = "SELECT b.id, concat('ADDC', lpad(p.id,4, '0')), concat(p.firstname, ' ', p.middlename, ' ', p.lastname), ph.service_quantity, ph.addtl_charge, ph.discount, ph.totaldue, b.total_balance from balance b inner join patient_history ph on b.ph_id = ph.id inner join patients p on p.id = b.p_id where ph.id = '" + ph_id + "'";
            MySqlCommand cmd = new MySqlCommand(query, Main.dbconnection);

            try
            {
                MySqlDataReader reader = cmd.ExecuteReader();
                String pid = "";
                String pname = "";
                string service_quantity = "";
                string addtl_charge = "";
                string discount = "";
                string totaldue = "";
                string balance = "";

                while (reader.Read())
                {
                    balance_id = reader.GetString(0);
                    pid = reader.GetString(1);
                    pname = reader.GetString(2);
                    service_quantity = reader.GetString(3);
                    addtl_charge = reader.GetString(4);
                    discount = reader.GetString(5);
                    totaldue = reader.GetString(6);
                    balance = reader.GetString(7);
                }
                reader.Close();

                paymentGridView.ColumnCount = 4;
                paymentGridView.Columns[0].Name = "Treatment";
                paymentGridView.Columns[1].Name = "Amount";
                paymentGridView.Columns[2].Name = "Additional Charge";
                paymentGridView.Columns[3].Name = "Discount";
                label1.Text = balance;
                label3.Text = pname;
                ptntpaymentLabel.Text = pid;

                paymentGridView.Rows.Add(service_quantity, totaldue, addtl_charge, discount);
                paymentGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                paymentGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                paymentGridView.BackgroundColor = Color.White;
                paymentGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                paymentGridView.DefaultCellStyle.SelectionBackColor = Color.LightGray;
                paymentGridView.DefaultCellStyle.SelectionForeColor = Color.Black;
                paymentGridView.ReadOnly = true;
                paymentGridView.RowHeadersVisible = false;
                paymentGridView.AllowUserToResizeColumns = false;
                paymentGridView.AllowUserToResizeRows = false;
                paymentGridView.AllowUserToDeleteRows = false;
                paymentGridView.AllowUserToAddRows = false;
                paymentGridView.MultiSelect = true;
                paymentGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            }
            catch (Exception err)
            {
                Console.WriteLine("Error {0}", err);
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            var selectedRows = appointmentdatagridview.SelectedRows.OfType<DataGridViewRow>()
                    .Where(row => !row.IsNewRow)
                    .ToArray();
            
            int count = selectedRows.Length;

            if (count == 1)
            {
                foreach (var row in selectedRows)
                {
                  //string id = row.Cells["Appointment ID"].Value.ToString();
                    string name = row.Cells["Name"].Value.ToString();
                    string pid = row.Cells["Patient ID"].Value.ToString();

                    isBalance = false;
                    servicesLogo.IdleFillColor = Color.DimGray;
                    paymentLogo.IdleFillColor = Color.FromArgb(189, 94, 189);
                    bunifuThinButton22.IdleFillColor = Color.DimGray;
                    bunifuThinButton24.IdleFillColor = Color.DimGray;
                    patientLogo.IdleFillColor = Color.DimGray;
                    paymentPanel.BringToFront();

                    label3.Text = name;
                    ptntpaymentLabel.Text = pid;
                    setPatient(name, pid);
                    paymentGridView.Columns.Clear();
                    paymentGridView.Rows.Clear();

                }
            }
            else
            {
                MessageBox.Show("Select only 1 appointment.");
            }
        }

        private void savepymntBtn_Click_1(object sender, EventArgs e)
        {
            string patient_id = ptntpaymentLabel.Text.Replace("ADDC", "");
            if (!isBalance)
            {
                string svc_qnt = "";
                for (int i = 0; i < paymentGridView.Rows.Count; i++)
                {
                    svc_qnt = svc_qnt + paymentGridView.Rows[i].Cells[0].Value.ToString() + "(" +
                              paymentGridView.Rows[i].Cells[1].Value.ToString() + ")";
                    if (i < paymentGridView.Rows.Count - 1)
                    {
                        svc_qnt = svc_qnt + ",\n";
                    }
                }

                string addtl = "0";
                if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    addtl = textBox1.Text;
                }
                string disc = "0";
                if (!string.IsNullOrEmpty(discount.Text) && !string.IsNullOrWhiteSpace(discount.Text))
                {
                    disc = discount.Text;
                }
                String query = "INSERT INTO patient_history(p_id, service_quantity, addtl_charge, discount, totaldue, cash_paid) VALUES('"
                        + patient_id + "', '"
                        + svc_qnt + "', '"
                        + addtl + "', '"
                        + disc + "' ,' "
                        + label1.Text + "','"
                        + double.Parse(cashTextBox.Text) + "')";

                MySqlCommand cmd1 = new MySqlCommand(query, Main.dbconnection);
                cmd1.ExecuteScalar();

                query = "SELECT LAST_INSERT_ID()";
                cmd1 = new MySqlCommand(query, Main.dbconnection);
                Object count = cmd1.ExecuteScalar();

                String query2 = "INSERT INTO balance(p_id, ph_id, total_balance) VALUES ('"
                    + patient_id + "','"
                    + Convert.ToInt32(count) + "', '"
                    + label11.Text + "')";

                cmd1 = new MySqlCommand(query2, Main.dbconnection);
                cmd1.ExecuteScalar();

                MessageBox.Show("Transaction Saved!");
                label1.Text = "";
                label2.Text = "";
                textBox1.Text = "";
                cashTextBox.Text = "";
                discount.Text = "";
                label11.Text = "";
                label3.Text = "";
                ptntpaymentLabel.Text = "";
                bunifuImageButton5.Enabled = false;
                bunifuImageButton2.Enabled = false;
                paymentGridView.Rows.Clear();
            }
            else
            {
                String query = "UPDATE balance SET total_balance = '" + label11.Text + "' where id = '" + balance_id + "'";
                MySqlCommand cmd1 = new MySqlCommand(query, Main.dbconnection);
                cmd1.ExecuteScalar();

                MessageBox.Show("Balance updated!");
                label1.Text = "";
                label2.Text = "";
                textBox1.Text = "";
                cashTextBox.Text = "";
                discount.Text = "";
                label11.Text = "";
                label3.Text = "";
                ptntpaymentLabel.Text = "";
                bunifuImageButton5.Enabled = false;
                bunifuImageButton2.Enabled = false;
                paymentGridView.Rows.Clear();
            }

            String queryAll = "UPDATE appointments SET isDone = true where id like " + patient_id;
            MySqlCommand cmd2 = new MySqlCommand(queryAll, Main.dbconnection);
            cmd2.ExecuteNonQuery();
            AppointmentInitTable();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (dropdownusername)
            {
                dropdownusername = false;
                panel9.SendToBack();
            }
            else
            {
                dropdownusername = true;
                panel9.BringToFront();
            }
        }

        //minidashboard
        private void bunifuThinButton214_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main mn = new Main();
            mn.Show();
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            SignUp sg = new SignUp(this);
            sg.Show();
        }

        //transaction history :))
        public void THinitTable()
        {
            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            String query = "SELECT service_quantity as 'Services', addtl_charge as 'Addtl Charge', discount as 'Discount', totaldue as 'Total Due',  DATE_FORMAT(date_created, '%M %d, %Y') as 'Date', TIME_FORMAT(date_created, '%r') as 'Time' from patient_history ";
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
            dataGridView1.Columns["Services"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.MultiSelect = true;
            dataGridView1.ShowEditingIcon = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (dataGridView1.Rows.Count > 0)
            {
                label22.Hide();
            }
            else
            {
                label22.Show();
            }
        }

        //account
        public void SignupInitTable()
        {

            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            String query = "SELECT concat(firstname, ' ', middlename, ' ', lastname) as 'Name', address as 'Address', contact as 'Contact #', gender as 'Gender', position as 'Position' from users";
            MyDA.SelectCommand = new MySqlCommand(query, Main.dbconnection);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;

            dataGridView2.DataSource = bSource;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView2.Columns["Name"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView2.Columns["Address"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView2.Columns["Contact #"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView2.Columns["Position"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            dataGridView2.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.MultiSelect = true;
            dataGridView2.ShowEditingIcon = true;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            if (dataGridView2.Rows.Count > 0)
            {
                label22.Hide();
                MessageBox.Show("!!!!!!!!!!");
            }
            else
            {
                label22.Show();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
   
