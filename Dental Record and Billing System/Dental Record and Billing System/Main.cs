using Bunifu.Framework.UI;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Dental_Record_and_Billing_System
{
    public partial class Main : Form
    {
        public static MySqlConnection dbconnection;
        private static String databaseName = "dentistdb";
        private static String server = "localhost";
        private static String databaseUid = "root";

        private static BunifuTextbox usernameTextBox;
        private static BunifuTextbox passwordTextBox;
        private static String username;
        private static String password;
       

        public Main()
        {
            setUpDbConnection();
            InitializeComponent();

            usernameTextBox = new BunifuTextbox();
            passwordTextBox = new BunifuTextbox();
            
            usernameLabel.Show();
            panel2.BringToFront();
        }

        private void setUpDbConnection()
        {
            String connectionString = "server=" + server + ";database=" + databaseName + ";uid=" + databaseUid + ";";
            dbconnection = new MySqlConnection(connectionString);
            try
            {
                dbconnection.Open();
                Console.WriteLine("Succesful connection to database");
            }
            catch (Exception err)
            {
                Console.WriteLine("Error connecting to mysql database {0}", err);
                Application.Exit();
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {    
            String query = "select count(*) from users where username='" + username + "' and password ='" + password + "';";
            MySqlCommand cmd = new MySqlCommand(query, dbconnection);
            Object count = cmd.ExecuteScalar();

            if (Convert.ToInt32(count) == 1)
            {
                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                dashboard.label19.Text = userTextBox.text;
            }
            else
            {
                usernameTextBox.text = "";
                passwordTextBox.text = "";
                MessageBox.Show("LOGIN ERROR: \n\n\nPlease check your username/password.");
            }
        }
            
        private void userTextBox_OnTextChange(object sender, EventArgs e)
        {
            usernameLabel.Hide();
            usernameTextBox = (BunifuTextbox)sender;
            usernameTextBox._TextBox.MaxLength = 20;
            usernameTextBox.text = usernameTextBox.text.Replace(Environment.NewLine, "");
            usernameTextBox.Focus();
            usernameTextBox._TextBox.Select(usernameTextBox.text.Length, 0);
            username = usernameTextBox.text;
            if (username == "")
            {
                usernameLabel.Show();
            }
        }

        private void passTextBox_OnTextChange(object sender, EventArgs e)
        {
            passwordLabel.Hide();
            passwordTextBox = (BunifuTextbox)sender;
            passwordTextBox._TextBox.MaxLength = 20;
            passwordTextBox._TextBox.PasswordChar = '*';
            passwordTextBox.text = passwordTextBox.text.Replace(Environment.NewLine, "");
            passwordTextBox.Focus();
            passwordTextBox._TextBox.Select(passwordTextBox.text.Length, 0);
            password = passwordTextBox.text;
            if (password == "")
            {
               passwordLabel.Show();
            }
        }                    
        private void userTextBox_KeyPress(object sender, EventArgs e)
        {
            if (e.GetType() == typeof(KeyPressEventArgs))
            {
                KeyPressEventArgs ke = e as KeyPressEventArgs;
                if(ke.KeyChar == (char)Keys.Enter) {
                    this.loginBtn_Click(this, new EventArgs());
                }
            }
            
        }

        private void passTextBox_KeyPress(object sender, EventArgs e)
        {
            if (e.GetType() == typeof(KeyPressEventArgs))
            {
                KeyPressEventArgs ke = e as KeyPressEventArgs;
                if (ke.KeyChar == (char)Keys.Enter)
                {
                    this.loginBtn_Click(this, new EventArgs());
                }
            }
        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {
            usernameTextBox._TextBox.Select(usernameTextBox.text.Length, 0);
        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {
            passwordTextBox._TextBox.Select(passwordTextBox.text.Length, 0);
        }

        private void userTextBox_Leave(object sender, EventArgs e)
        {
            if(usernameTextBox.text.Length <= 0)
            {
                usernameLabel.Show();
            }
        }

        private void pwTextBox_Enter(object sender, EventArgs e)
        {
            passwordLabel.Hide();
        }

        private void pwTextBox_Leave(object sender, EventArgs e)
        {
            if(passwordTextBox.text.Length <= 0)
            {
                passwordLabel.Show();
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            panel2.BringToFront();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            dbconnection.Close();
            Console.WriteLine("Database connection closed.");
            Application.Exit();
        }

        private void fpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword fp = new ForgotPassword();
            fp.Show();
        }
    }
}
