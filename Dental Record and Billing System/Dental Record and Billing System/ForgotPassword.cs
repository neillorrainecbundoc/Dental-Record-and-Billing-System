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
    public partial class ForgotPassword : Form
    {
        // Variables
        String username;
        String answer;
        String question;

        /**
         * Constructor
         */
        public ForgotPassword()
        {
            InitializeComponent();
            InitializeValue();
        }

        /**
         * Initialize Field Values
         */ 
        private void InitializeValue()
        {
            question = secret_question_dropdown.selectedValue;
        }

        /**
         * Invoked when X button is clicked
         * 
         * Closed the connection to the database and exits the application.
         */
        private void close_click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**
         * Proceed button
         * 
         * Invoked when proceed button is clicked.
         * Checks if the user answers the secret question right for the user.
         */ 
        private void proceed_click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(answer)) 
            {
                String query = "select count(*) from users where " +
                    "username = '"+username+"' and " +
                    "question = '"+question+"' and " +
                    "answer = '"+answer+"'";

                MySqlCommand cmd = new MySqlCommand(query, Main.dbconnection);
                Object count = cmd.ExecuteScalar();

                if (Convert.ToInt32(count) == 1)
                {
                    // CHANGE PASSWORD HERE
                    this.Hide();
                } else
                {
                    MessageBox.Show("No matching user!");
                }

            } else
            {
                String error_message = "PASSWORD RECOVERY ERROR: \n";
                if(string.IsNullOrEmpty(username))
                {
                    error_message += "\ninvalid username";
                }
                if (string.IsNullOrEmpty(answer))
                {
                    error_message += "\ntype your answer";
                }
                MessageBox.Show(error_message);
            }

            username_textbox.text = "";
            username = "";

            answer_textbox.text = "";
            answer = "";

            secret_question_dropdown.selectedIndex = 0;
            question = secret_question_dropdown.selectedValue;
        }

        /**
         * Username Text Box
         * 
         * Hides username label when user entered user text box.
         */
        private void username_textbox_enter(object sender, EventArgs e)
        {
            username_label.Hide();
        }

        /**
         * Username Text Box
         * 
         * Shows username label when user leaves user text box and has no input on it.
         */
        private void username_textbox_leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(username_textbox.text))
            {
                username_label.Show();
            }
        }

        /**
         * Username Text Box
         * 
         * When user pressed Enter button it will invoke proceed.
         */
        private void username_textbox_keypress(object sender, EventArgs e)
        {
            if (e.GetType() == typeof(KeyPressEventArgs))
            {
                KeyPressEventArgs ke = e as KeyPressEventArgs;
                if (ke.KeyChar == (char)Keys.Enter)
                {
                    this.proceed_click(this, new EventArgs());
                }
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
         * Answer Text Box
         * 
         * Hides answer label when user entered answer text box.
         */
        private void answer_textbox_enter(object sender, EventArgs e)
        {
            answer_label.Hide();
        }

        /**
         * Answer Text Box
         * 
         * Shows answer label when user leaves answer text box and has no input on it.
         */
        private void answer_textbox_leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(answer_textbox.text))
            {
                answer_label.Show();
            }
        }

        /**
         * Answer Text Box
         * 
         * When user pressed Enter button it will invoke proceed.
         */
        private void answer_textbox_keypress(object sender, EventArgs e)
        {
            if (e.GetType() == typeof(KeyPressEventArgs))
            {
                KeyPressEventArgs ke = e as KeyPressEventArgs;
                if (ke.KeyChar == (char)Keys.Enter)
                {
                    this.proceed_click(this, new EventArgs());
                }
            }
        }

        /**
         * Answer Text Box
         * 
         * Invoked during text change in Answer Text Box.
         * User is typing answer
         */
        private void answer_textbox_on_text_change(object sender, EventArgs e)
        {
            answer_label.Hide();
            answer_textbox.text = answer_textbox.text.Replace(Environment.NewLine, "");
            answer = answer_textbox.text;
            if (string.IsNullOrEmpty(answer))
            {
                answer_label.Show();
            }
        }

        /**
         * Secret Question Dropdown
         * 
         * Stores value of question selected
         */ 
        private void secret_question_dropdown_on_item_selected(object sender, EventArgs e)
        {
            question = secret_question_dropdown.selectedValue;
        }
    }
}
