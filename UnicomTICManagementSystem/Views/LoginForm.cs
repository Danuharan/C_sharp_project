using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            

            string selectedText = comboBox_Role.SelectedItem?.ToString(); // To pass the Role to MainForm welcom [Role] msg...

            if (!string.IsNullOrEmpty(selectedText))
            {
                MainForm form2 = new MainForm();
                form2.ToDisplayRole = selectedText; // Pass the selected text to MainForm
                form2.Show(); // To Show the MainForm

                this.Hide();                    // Hide the current form (LoginForm)
            }
        }
    }
}
