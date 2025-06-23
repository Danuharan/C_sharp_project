using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnicomTICManagementSystem.Views
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public string ToDisplayRole
        {
            set
            {

                label_Rolebased_welcome.Text = value;
            }
        }
        private void label_Rolebased_welcome_Click(object sender, EventArgs e)
        {

        }

        private void DB_course_sub_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)          
        {                                                                                   // Below if statements decide which are going to show in panel...
            if (label_Rolebased_welcome.Text == "Student") // Case-sensitive comparison
            {
                DB_timetable.Visible = false; 
                DB_student.Visible = false; 
                DB_course_sub.Visible = false; 
                DB_exam_marks.Visible = false; 
                DB_User.Visible = false;
            }
            
            else if (label_Rolebased_welcome.Text == "Staff")
            {
                DB_student.Visible = false;
                DB_course_sub.Visible = false;
                DB_view_timetable.Visible = false;
                DB_view_marks.Visible = false;
                DB_User.Visible = false;

            }

            else if (label_Rolebased_welcome.Text == "Lecturer")                    
            {
                DB_student.Visible = false;
                DB_course_sub.Visible = false;
                DB_view_timetable.Visible = false;
                DB_view_marks.Visible = false;
                DB_User.Visible = false;

            }
        }

        private void DB_course_sub_Click(object sender, EventArgs e)
        {
            CourseForm form3 = new CourseForm();  // To show CourseForm
            form3.Show();               
            
        }

        private void DB_User_Click(object sender, EventArgs e)
        {
            UserForm form_user_register = new UserForm();  // To show UserForm (User Registration in initally by admin)
            form_user_register.Show();

            this.Hide();                    // Hide the current form (MainForm)
        }
    }
    
}
