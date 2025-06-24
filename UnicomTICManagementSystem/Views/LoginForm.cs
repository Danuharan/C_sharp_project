using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Repositories;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UnicomTICManagementSystem.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            {                                                               // To add items in ComboBox_Role
            comboBox_Role.Items.Add("Staff");
            comboBox_Role.Items.Add("Student");
            comboBox_Role.Items.Add("Lecturer");
            comboBox_Role.Items.Add("Admin");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void tUsername_Click(object sender, EventArgs e)
        {
            if (tUsername.Text == "Username")
            {
                tUsername.Text = "";                                        //  To set text box blank when ready to type
                tUsername.ForeColor = Color.Black;                          //  To set text color as black
            }
        }

        private void tPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void tPassword_Click(object sender, EventArgs e)
        {
            if (tPassword.Text == "Password")
            {
                tPassword.Text = "";                                        //  To set text box blank when ready to type
                tPassword.ForeColor = Color.Black;                          //  To set text color as black
            }
        }

        private void comboBox_Role_Click(object sender, EventArgs e)
        {
            if (comboBox_Role.Text == "Role")
            {
                comboBox_Role.Text = "";                                        //  To set text box blank when ready to type
                comboBox_Role.ForeColor = Color.Black;                          //  To set text color as black
            }

            
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            {
                tUsername.Select(0, 0);                                         // To avoid automatically select text at startup
                this.ActiveControl = lblDummy; // or txtDummy  (It's basically a placeholder to absorb initial focus so that the username TextBox doesn't have the blinking cursor or highlighted text at startup.)
            }
        }

        private void comboBox_Role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_Login_Click(object sender, EventArgs e)
        {
    //==================== Below coding for User Login ======================================
            {
                string username = tUsername.Text.Trim();
                string password = tPassword.Text.Trim();
                string role = comboBox_Role.Text.Trim();

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
                {
                    MessageBox.Show("Please enter Username, Password, and select a Role.");
                    return;
                }

                using (var conn_login = Dbconfig.GetConnection())
                {
                    //conn_login.Open();
                    string query = @"SELECT COUNT(*) FROM Users 
                         WHERE UserName = @username AND Password = @password AND Role = @role";

                    using (var cmd = new SQLiteCommand(query, conn_login))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@role", role);

                        int userCount = Convert.ToInt32(cmd.ExecuteScalar());   // ExecuteScalar() --> Runs the query and returns one value only

                        if (userCount > 0)
                        {
                            MessageBox.Show("Login Successful!");
                            // open main form or dashboard here
                           

                            string selectedText = comboBox_Role.SelectedItem?.ToString(); // To pass the Role to MainForm welcom [Role] msg...

                            if (!string.IsNullOrEmpty(selectedText))
                            {
                                MainForm form2 = new MainForm(selectedText);
                                form2.ToDisplayRole = selectedText; // Pass the selected text to MainForm
                                form2.Show(); // To Show the selected text to MainForm (ex. If student login --> welcome Student!)
                                this.Hide();                    // Hide the current form (LoginForm)
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid credentials. Please check Username, Password, or Role.");
                        }
                    }
                }
            }

            
        }
    }
}
