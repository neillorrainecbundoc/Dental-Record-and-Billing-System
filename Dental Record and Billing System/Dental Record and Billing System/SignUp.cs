using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using MySql.Data.MySqlClient;

namespace Dental_Record_and_Billing_System
{
    public partial class SignUp : Form
    {
        private static String fname;
        private static String mname;
        private static String lname;
        private static String address;
        private static String contact;
        private static String gender;
        private static String position;
        private static String uname;
        private static String pword;
        private static String seque;
        private static String ans;

        private static BunifuMaterialTextbox firstNameTextBox;
        private static BunifuMaterialTextbox middleNameTextBox;
        private static BunifuMaterialTextbox lastNameTextBox;
        private static BunifuMaterialTextbox addressTextBox;
        private static BunifuMaterialTextbox contactTextBox;
        private static RadioButton genderRadioButton;
        private static ComboBox positions;
        private static BunifuMaterialTextbox usernameTextBox;
        private static BunifuMaterialTextbox passwordTextBox;
        private static ComboBox secuques;
        private static BunifuMaterialTextbox answerTextBox;

        private static Dashboard dashboard;

        public SignUp()
        {
            InitializeComponent();
            SignUpInit();
        }

        public SignUp(Object e)
        {
            InitializeComponent();
            dashboard = (Dashboard)e;
            SignUpInit();
        }

        public void SignUpInit()
        {
            firstNameTextBox = new BunifuMaterialTextbox();
            middleNameTextBox = new BunifuMaterialTextbox();
            lastNameTextBox = new BunifuMaterialTextbox();
            addressTextBox = new BunifuMaterialTextbox();
            contactTextBox = new BunifuMaterialTextbox();
            genderRadioButton = new RadioButton();
            positions = new ComboBox();
            usernameTextBox = new BunifuMaterialTextbox();
            passwordTextBox = new BunifuMaterialTextbox();
            secuques = new ComboBox();
            answerTextBox = new BunifuMaterialTextbox();

        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            if (contact.Length == 11 && !string.IsNullOrEmpty(fname) && !string.IsNullOrEmpty(mname) && !string.IsNullOrEmpty(lname) && !string.IsNullOrEmpty(address) && !string.IsNullOrEmpty(contact) && !string.IsNullOrEmpty(gender) && !string.IsNullOrEmpty(position) && !string.IsNullOrEmpty(uname) && !string.IsNullOrEmpty(pword) && !string.IsNullOrEmpty(seque) && !string.IsNullOrEmpty(ans))
            {
                MySqlCommand cmd = Main.dbconnection.CreateCommand();
                cmd.CommandText = "insert into users (firstname, middlename, lastname, address, contact, gender, position, username, password, secretques, answer) value (?firstname, ?middlename, ?lastname, ?address, ?contact, ?gender, ?position, ?username, ?password, ?secretques, ?answer)";

                cmd.Parameters.AddWithValue("@firstname", fname);
                cmd.Parameters.AddWithValue("@middlename", mname);
                cmd.Parameters.AddWithValue("@lastname", lname);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@contact", contact);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@position", position);
                cmd.Parameters.AddWithValue("@username", uname);
                cmd.Parameters.AddWithValue("@password", pword);
                cmd.Parameters.AddWithValue("@secretques", seque);
                cmd.Parameters.AddWithValue("@answer", ans);


                try
                {
                    cmd.ExecuteNonQuery();
                    dashboard.SignupInitTable();

                    firstNameTextBox.Text = "";
                    middleNameTextBox.Text = "";
                    lastNameTextBox.Text = "";
                    addressTextBox.Text = "";
                    contactTextBox.Text = "";
                    genderRadioButton.Text = "";
                    usernameTextBox.Text = "";
                    passwordTextBox.Text = "";
                    answerTextBox.Text = "";

                    if (radioButton1.Checked)
                    {
                        gender = "Male";
                    }
                    if (radioButton2.Checked)
                    {
                        gender = "Female";
                    }

                    MessageBox.Show("Account Added!");

                    this.Hide();
                }
                catch (Exception err)
                {
                    Console.WriteLine("Error account insert into database", err);
                }
            }
            else
            {
                String errFields = "";

                if (string.IsNullOrEmpty(fname))
                {
                    errFields += "First name ";
                }
                if (string.IsNullOrEmpty(mname))
                {
                    errFields += "Middle name ";
                }
                if (string.IsNullOrEmpty(lname))
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
                if (string.IsNullOrEmpty(gender))
                {
                    errFields += "Gender";
                }
                if (string.IsNullOrEmpty(position))
                {
                    errFields += "Position";
                }
                if (string.IsNullOrEmpty(uname))
                {
                    errFields += "Username";
                }
                if (string.IsNullOrEmpty(pword))
                {
                    errFields += "Password";
                }
                if (string.IsNullOrEmpty(seque))
                {
                    errFields += "Security Question";
                }
                if (string.IsNullOrEmpty(ans))
                {
                    errFields += "Answer";
                }

                MessageBox.Show("REGISTRATION ERROR: \n\n Add information for " + errFields);
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void fnameTextBox_OnValueChanged(object sender, EventArgs e)
        {
            firstNameTextBox = (BunifuMaterialTextbox)sender;
            firstNameTextBox.ForeColor = Color.White;
            fname = firstNameTextBox.Text;
        }

        private void MnameTextBox_OnValueChanged(object sender, EventArgs e)
        {
            middleNameTextBox = (BunifuMaterialTextbox)sender;
            middleNameTextBox.ForeColor = Color.White;
            mname = middleNameTextBox.Text;
        }

        private void LnameTextBox_OnValueChanged(object sender, EventArgs e)
        {
            lastNameTextBox = (BunifuMaterialTextbox)sender;
            lastNameTextBox.ForeColor = Color.White;
            lname = lastNameTextBox.Text;
        }

        private void addrssTextBox_OnValueChanged(object sender, EventArgs e)
        {
            addressTextBox = (BunifuMaterialTextbox)sender;
            addressTextBox.ForeColor = Color.White;
            address = addressTextBox.Text;
        }

        private void contactNoTextBox_OnValueChanged(object sender, EventArgs e)
        {
            contactTextBox = (BunifuMaterialTextbox)sender;
            if (contactTextBox.Text.Length <= 11)
            {
                contactTextBox.ForeColor = Color.White;
                contact = contactTextBox.Text;
           }
            else
            {
                contactTextBox.Text = contact;
            }
        }

        private void contactNoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            genderRadioButton = (RadioButton)sender;
            gender = genderRadioButton.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            genderRadioButton = (RadioButton)sender;
            gender = genderRadioButton.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            positions = (ComboBox)sender;
            position = positions.Text;
        }

        private void unameTextBox_OnValueChanged(object sender, EventArgs e)
        {
            usernameTextBox = (BunifuMaterialTextbox)sender;
            usernameTextBox.ForeColor = Color.White;
            uname = usernameTextBox.Text;
        }

        private void pssTextBox_OnValueChanged(object sender, EventArgs e)
        {
            passwordTextBox = (BunifuMaterialTextbox)sender;
            passwordTextBox.ForeColor = Color.White;
            pword = passwordTextBox.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            secuques = (ComboBox)sender;
            seque = secuques.Text;
        }

        private void ansTextBox_OnValueChanged(object sender, EventArgs e)
        {
            answerTextBox = (BunifuMaterialTextbox)sender;
            answerTextBox.ForeColor = Color.White;
            ans = answerTextBox.Text;
        }
    }
}
