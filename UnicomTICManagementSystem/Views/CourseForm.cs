using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Controllers;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.Views
{
    public partial class CourseForm : Form
    {
        private CourseController _courseController;  //these 2 for update
        private int selectedCourseId = -1;      //these 2 for update

        private readonly SubjectController _subjectController;
        private int selectedSubjectId = -1;

        private string _userRole;
        public CourseForm(string role)
        {
            InitializeComponent();
            _userRole = role;
            label_Rolebased_welcome.Text = role;

            _courseController = new CourseController();
            LoadCourses();
            _subjectController = new SubjectController();

            LoadCoursesIntoComboBox();
        }

       
        private void LoadCourses()             // method and below for view courses
        {
            //CourseController courseController = new CourseController();
            //List<Course> courses = courseController.GetAllCourses();
            var courses = _courseController.GetAllCourses();
            dataGridView1_course.DataSource = courses;

        }


        private void LoadSubjects()             // method and below for view courses
        {
            //CourseController courseController = new CourseController();
            //List<Course> courses = courseController.GetAllCourses();
            var subjects = _subjectController.GetAllSubjects();
            dataGridView2_subject.DataSource = subjects;

        }

        private void LoadCoursesIntoComboBox()
        {
            var courses = _courseController.GetAllCourses();
            comboBox1.DataSource = courses;
            comboBox1.DisplayMember = "CourseName";
            comboBox1.ValueMember = "CourseId";
        }
        private void ClearInputs()
        {
            textBox_course.Text = "";

        }

        private void ClearInputs2()
        {
            textBox2_subname.Text = "";
            comboBox1.Text = "";

        }
        private void ClearForm()
        {
            textBox_course.Clear();
            selectedCourseId = -1;
            comboBox1.SelectedIndex = -1;

        }

        private void ClearForm2()
        {
            textBox2_subname.Clear();
            selectedSubjectId = -1;

        }

        private void button1_add_Click(object sender, EventArgs e)
        {
            Course course = new Course
            {
                CourseName = textBox_course.Text
            };
            CourseController courseController = new CourseController();
            string getMessage = courseController.AddCourse(course);
            MessageBox.Show(getMessage);

            LoadCourses();
        }

        private void dataGridView1_course_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
      
        
        private void dataGridView1_course_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1_course.SelectedRows.Count > 0)
            {
                var row = dataGridView1_course.SelectedRows[0];
                var courseView = row.DataBoundItem as Course;

                if (courseView != null)
                {
                    selectedCourseId = courseView.CourseId;

                    var course = _courseController.GetCourseBy_CourseId(selectedCourseId);
                    if (course != null)
                    {
                        textBox_course.Text = course.CourseName;
                        
                    }
                }
            }
            else
            {
                ClearInputs();
                selectedCourseId = -1;
            }
        }

        private void button1_edit_Click(object sender, EventArgs e)
        {
            if (selectedCourseId == -1)
            {
                MessageBox.Show("Please select a course to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox_course.Text))
            {
                MessageBox.Show("Please enter the course Name.");
                return;
            }

            var course = new Course
            {
                CourseId = selectedCourseId,
                CourseName = textBox_course.Text,
                
            };

            _courseController.UpdateCourse(course);
            LoadCourses();
            ClearForm();
            MessageBox.Show("Course Updated Successfully");

        }

        private void button1_delete_Click(object sender, EventArgs e)
        {
            if (selectedCourseId == -1)
            {
                MessageBox.Show("Please select a course to delete.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this course?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                _courseController.DeleteCourse(selectedCourseId);
                LoadCourses();
                ClearForm();
                MessageBox.Show("Course Deleted Successfully");

            }
        }

        private void label_Rolebased_welcome_Click(object sender, EventArgs e)
        {

        }

        private void CourseForm_Load_1(object sender, EventArgs e)
        {
            {
                label_Rolebased_welcome.Text = _userRole;

                if (_userRole == "Student" || _userRole == "Staff" || _userRole == "Lecturer")
                {
                    
                    button1_add.Visible = false;
                    button1_edit.Visible = false;
                    button1_delete.Visible = false;

                    button2_add.Visible = false;
                    button2_edit.Visible = false;
                    button2_delete.Visible = false;
                }

                LoadSubjects();
            }
        }

        private void button2_add_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Please select a course before adding a subject.");
                return;
            }

            Subject subject = new Subject
            {
                SubjectName = textBox2_subname.Text,
                CourseId = Convert.ToInt32(comboBox1.SelectedValue)
            };

            string getMessage = _subjectController.AddSubject(subject);
            MessageBox.Show(getMessage);

            LoadSubjects();
            ClearInputs2();
        }

        private void dataGridView2_subject_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2_subject.SelectedRows.Count > 0)
            {
                var row = dataGridView2_subject.SelectedRows[0];
                var subjectView = row.DataBoundItem as Subject;

                if (subjectView != null)
                {
                    selectedSubjectId = subjectView.SubjectId;

                    var subject = _subjectController.GetSubjectBy_SubjectId(selectedSubjectId);
                    if (subject != null)
                    {
                        textBox2_subname.Text = subject.SubjectName;
                        comboBox1.SelectedValue = subject.CourseId;

                    }
                }
            }
            else
            {
                ClearInputs2();
                selectedSubjectId = -1;
            }
        }

        private void button2_edit_Click(object sender, EventArgs e)
        {
            if (selectedSubjectId == -1)
            {
                MessageBox.Show("Please select a subject to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(textBox2_subname.Text))
            {
                MessageBox.Show("Please enter the Both Fields..");
                return;
            }

            var subject = new Subject
            {
                SubjectId = selectedSubjectId,
                SubjectName = textBox2_subname.Text,
                CourseId = Convert.ToInt32(comboBox1.SelectedValue)

            };

            _subjectController.UpdateSubject(subject);
            LoadSubjects();
            ClearForm2();
            MessageBox.Show("Subject Updated Successfully");
        }

        private void button2_delete_Click(object sender, EventArgs e)
        {
            
            if (selectedSubjectId == -1)
            {
                MessageBox.Show("Please select a subject to delete.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this subject?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                _subjectController.DeleteSubject(selectedSubjectId);
                LoadSubjects();         // Refresh the grid view
                ClearForm2();           // Clear inputs
                MessageBox.Show("Subject Deleted Successfully");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm dashboard = new MainForm(_userRole);  //  Pass correct role back
            dashboard.Show();
            this.Hide();  //  Hide this CourseForm
        }

        private void dataGridView2_subject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
