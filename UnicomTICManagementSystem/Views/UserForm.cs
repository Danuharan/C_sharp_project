using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Controllers;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.Views
{
    public partial class UserForm : Form
    {

        private LoginController _userController;  //these 2 for update
        private int selectedUserId = -1;      //these 2 for update
        public UserForm()
        {
            InitializeComponent();

            _userController = new LoginController();

            comboBox1.Items.Add("Staff");
            comboBox1.Items.Add("Student");
            comboBox1.Items.Add("Lecturer");
            comboBox1.Items.Add("Admin");

            LoadStudents();
        }


        private void LoadStudents()             // Method and below for Grid view - view purpose
        {
            LoginController loginController = new LoginController();
            List<User> users = loginController.GetAllStudents();
            dataGridView1.DataSource = users;

        }

        private void ClearInputs()              //To clear the textbox fields in form
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
        }

        private void ClearForm()
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            selectedUserId = -1;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_ADD_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                UserName = textBox1.Text,
                Password = textBox2.Text,
                Role = comboBox1.SelectedItem.ToString(),
                created_at = DateTime.Now,     //  Set current time
                //updated_at = DateTime.Now      //  Also set for updated_at             this used in update method
            };
            LoginController loginController = new LoginController();
            string getMessage = loginController.AddUser(user);
            MessageBox.Show(getMessage);

           LoadStudents();  //This method called here cz when adding new user then also we can see the user details in gried view (no need to load again)
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    var row = dataGridView1.SelectedRows[0];
                    var userView = row.DataBoundItem as User;

                    if (userView != null)
                    {
                        selectedUserId = userView.UserId;

                        var user = _userController.GetUsertBy_UserId(selectedUserId);
                        if (user != null)
                        {
                            textBox1.Text = user.UserName;
                            textBox2.Text = user.Password;
                            comboBox1.Text = user.Role;
                        }
                    }
                }
                else
                {
                    ClearInputs();
                    selectedUserId = -1;
                }
            }
        }

        private void button2_UPDATE_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Please select a user to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Please enter all formats (User_Name, PasswordPropertyTextAttribute and Role)");
                return;
            }

            var user = new User
            {
                UserId = selectedUserId,
                UserName = textBox1.Text,
                Password = textBox2.Text,
                Role = comboBox1.Text,
                updated_at = DateTime.Now

               
            };

            _userController.UpdateUser(user);
            LoadStudents();
            ClearForm();
            MessageBox.Show("User Updated Successfully");

        }

        private void button3_DELETE_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                _userController.DeleteUser(selectedUserId);
                LoadStudents();
                ClearForm();
                MessageBox.Show("User Deleted Successfully");

            }
        }
    }
}
