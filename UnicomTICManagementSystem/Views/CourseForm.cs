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
    public partial class CourseForm : Form
    {
        public CourseForm()
        {
            InitializeComponent();
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
        }
    }
}
