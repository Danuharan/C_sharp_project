using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Controllers;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.Views
{
    
    public partial class StudentForm : Form
    {
        private readonly CourseController _courseController;
        private readonly StudentController _studentController;
        private string _userRole;

        private int selectedStudentId = -1;
        public StudentForm(string role)
        {
            InitializeComponent();
            _userRole = role;  //  Store the role

            _courseController = new CourseController();
            _studentController = new StudentController();
            LoadCoursesIntoComboBox();
            LoadStudents();
        }

        private void label_form_title_Click(object sender, EventArgs e)
        {

        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            MainForm dashboard = new MainForm(_userRole);  // ✅ Go back with correct role
            dashboard.Show();
            this.Hide();
        
        }

        private void LoadStudents()             
        {
           
            var students = _studentController.GetAllStudents();
            dataGridView2_student.DataSource = students;

        }

        private void ClearInputs()
        {
            textBox2_subname.Text = "";
            comboBox1.Text = "";

        }
        private void LoadCoursesIntoComboBox()
        {
            var courses = _courseController.GetAllCourses();
            comboBox1.DataSource = courses;
            comboBox1.DisplayMember = "CourseName";
            comboBox1.ValueMember = "CourseId";
        }
        private void button2_add_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Please select a course before adding a student.");
                return;
            }

            Student student = new Student
            {
                StudentName = textBox2_subname.Text,
                CourseId = Convert.ToInt32(comboBox1.SelectedValue)
            };

            string getMessage = _studentController.AddStudent(student);
            MessageBox.Show(getMessage);

            LoadStudents();
            ClearInputs();
        }

        private void dataGridView2_student_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2_student.SelectedRows.Count > 0)
            {
                var row = dataGridView2_student.SelectedRows[0];
                var studentView = row.DataBoundItem as Student;

                if (studentView != null)
                {
                    selectedStudentId = studentView.StudentId;

                    var student = _studentController.GetStudentById(selectedStudentId);
                    if (student != null)
                    {
                        textBox2_subname.Text = student.StudentName;
                        comboBox1.SelectedValue = student.CourseId;
                    }
                }
            }
            else
            {
                ClearInputs();
                selectedStudentId = -1;
            }
        }

        private void button2_edit_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == -1)
            {
                MessageBox.Show("Please select a student to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(textBox2_subname.Text))
            {
                MessageBox.Show("Please enter both Student Name and Course.");
                return;
            }

            var student = new Student
            {
                StudentId = selectedStudentId,
                StudentName = textBox2_subname.Text,
                CourseId = Convert.ToInt32(comboBox1.SelectedValue)
            };

            _studentController.UpdateStudent(student);
            LoadStudents();
            ClearInputs();
            MessageBox.Show("Student Updated Successfully");
        }

       
        
   

        private void button2_delete_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == -1)
            {
                MessageBox.Show("Please select a student to delete.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                _studentController.DeleteStudent(selectedStudentId);
                LoadStudents();      // Refresh the grid view
                ClearInputs();      // Clear inputs
                MessageBox.Show("Student Deleted Successfully");
            }
        }
    }
    
}
