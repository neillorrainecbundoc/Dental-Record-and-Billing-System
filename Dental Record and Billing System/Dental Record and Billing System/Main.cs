using Bunifu.Framework.UI;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Dental_Record_and_Billing_System
{
    public partial class Main : Form
    {
        // Database Configurations
        public static MySqlConnection dbconnection;
        private String databaseName = "dentistdb";
        private String server = "localhost";
        private String databaseUid = "root";
        // Variable
        private String username;
        private String password;

        /**
         * Constructor
         */ 
        public Main()
        {
            InitializeDatabase();
            InitializeComponent();
            InitializeObjectConfigurations();
        }

        /**
         * Initialize MYSQL database connection
         */ 
        private void InitializeDatabase()
        {
            String connectionString = 
                "server=" + server + ";" +
                "database=" + databaseName + ";" +
                "uid=" + databaseUid + ";";
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

        /**
         * Object Configurations
         */ 
        private void InitializeObjectConfigurations()
        {
            // Username Text Box
            username_textbox._TextBox.MaxLength = 20;

            // Password Text Box
            password_textbox._TextBox.MaxLength = 20;
            password_textbox._TextBox.PasswordChar = '*';
        }

        /**
         * Invoked when Main form is closed.
         * 
         * Closed the connection to the database and exits the application.
         */ 
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            dbconnection.Close();
            Console.WriteLine("Database connection closed.");
            Application.Exit();
        }

        /**
         * Invoked when X button is clicked
         * 
         * Closed the connection to the database and exits the application.
         */
        private void close_click(object sender, EventArgs e)
        {
            this.Close();
            this.Main_FormClosed(this, new FormClosedEventArgs(new CloseReason()));
        }

        /**
         * Invoked when _ button is clicked
         * 
         * Minimizes the form.
         */ 
        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /**
        * Invoked when Login Button is clicked.
        * 
        * User logins to the system. 
        * User must enter valid username and password.
        */
        private void login_button_click(object sender, EventArgs e)
        {
            String query = "select count(*) from users where " +
                "username='" + username + "' and " +
                "password ='" + password + "';";

            MySqlCommand cmd = new MySqlCommand(query, dbconnection);
            Object count = cmd.ExecuteScalar();

            if (Convert.ToInt32(count) == 1)
            {
                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                dashboard.username_dashboard_label.Text = username_textbox.text;
            }
            else
            {
                username = "";
                username_textbox.text = "";
                username_label.Show();

                password = "";
                password_textbox.text = "";
                password_label.Show();
                MessageBox.Show("LOGIN ERROR: \n\n\nPlease check your username/password.");
            }
        }

        /**
         * Username Text Box
         * 
         * Invoked during text change in User Text Box.
         * User is typing username.
         */ 
        private void username_textbox_on_text_change(object sender, EventArgs e)
        {
            username_label.Hide();
            username_textbox.text = username_textbox.text.Replace(Environment.NewLine, "");
            username = username_textbox.text;
            if (string.IsNullOrEmpty(username))
            {
                username_label.Show();
            }
        }

        /**
         * Username Text Box
         * 
         * When user pressed Enter button it will invoke login.
         */ 
        private void username_textbox_keypress(object sender, EventArgs e)
        {
            if (e.GetType() == typeof(KeyPressEventArgs))
            {
                KeyPressEventArgs ke = e as KeyPressEventArgs;
                if (ke.KeyChar == (char)Keys.Enter)
                {
                    this.login_button_click(this, new EventArgs());
                }
            }
        }

        /**
         * Username Text Box
         * 
         * Hides username label when user entered username text box.
         */
        private void username_textbox_enter(object sender, EventArgs e)
        {
            username_label.Hide();
        }

        /**
         * Username Text Box
         * 
         * Shows username label when user leaves username text box and has no input on it.
         */
        private void username_textbox_leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username_textbox.text))
            {
                username_label.Show();
            }
        }

        /**
         * Password Text Box
         * 
         * Invoked during text change in Password Text Box.
         * User is typing password.
         */
        private void password_textbox_on_text_change(object sender, EventArgs e)
        {
            password_label.Hide();
            password_textbox.text = password_textbox.text.Replace(Environment.NewLine, "");
            password = password_textbox.text;
            if (string.IsNullOrEmpty(password))
            {
                password_label.Show();
            }
        }

        /**
         * Password Text Box
         * 
         * When user pressed Enter button it will invoke login.
         */
        private void password_textbox_keypress(object sender, EventArgs e)
        {
            if (e.GetType() == typeof(KeyPressEventArgs))
            {
                KeyPressEventArgs ke = e as KeyPressEventArgs;
                if (ke.KeyChar == (char)Keys.Enter)
                {
                    this.login_button_click(this, new EventArgs());
                }
            }
        }

        /**
         * Password Text Box
         * 
         * Hides password label when user entered password text box.
         */ 
        private void password_textbox_enter(object sender, EventArgs e)
        {
            password_label.Hide();
        }

        /*
         * Password Text Box
         * 
         * Shows password label when user leaves password text box and has no input on it.
         */ 
        private void password_textbox_leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(password_textbox.text))
            {
                password_label.Show();
            }
        }

        /*
         * Forgot Password
         * 
         * Invokes when user clicks the link for forgot password.
         **/ 
        private void forgot_password_link_clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword fp = new ForgotPassword();
            fp.Show();
        }
    }
}
