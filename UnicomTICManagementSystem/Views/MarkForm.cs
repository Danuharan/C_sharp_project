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
    public partial class MarkForm : Form
    {
        private StudentController _studentController = new StudentController();
        private SubjectController _subjectController = new SubjectController();
        private ExamController _examController = new ExamController();
        private MarkController _markController = new MarkController();

        private int selectedMarkId = -1;
        private string _userRole;

        public MarkForm(string role)
        {
            InitializeComponent();
            _userRole = role;

            LoadStudents();
            LoadSubjects();
            LoadExams();
            LoadMarks();
        }

        //  Load Students for ComboBox1
        private void LoadStudents()
        {
            var students = _studentController.GetAllStudents();
            comboBox1.DataSource = students;
            comboBox1.DisplayMember = "StudentName";
            comboBox1.ValueMember = "StudentId";
        }

        //  Load Subjects for ComboBox3 (Optional, just for display)
        private void LoadSubjects()
        {
            var subjects = _subjectController.GetAllSubjects();
            comboBox3.DataSource = subjects;
            comboBox3.DisplayMember = "SubjectName";
            comboBox3.ValueMember = "SubjectId";
        }

        //  Load Exams for ComboBox2
        private void LoadExams()
        {
            var exams = _examController.GetAllExams();
            comboBox2.DataSource = exams;
            comboBox2.DisplayMember = "ExamName";
            comboBox2.ValueMember = "ExamId";
        }

        //  Load Marks GridView
        private void LoadMarks()
        {
            var marks = _markController.GetAllMarks();
            dataGridView2_exam_marks.DataSource = marks;
        }

        //  Clear Input Fields
        private void ClearInputs()
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            textBox2_subname.Text = "";
            selectedMarkId = -1;
        }

        //  Add Mark Button
        private void button2_add_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null || comboBox2.SelectedValue == null || string.IsNullOrWhiteSpace(textBox2_subname.Text))
            {
                MessageBox.Show("Please fill all fields (Student, Exam, Score).");
                return;
            }

            Mark mark = new Mark
            {
                StudentId = Convert.ToInt32(comboBox1.SelectedValue),
                ExamId = Convert.ToInt32(comboBox2.SelectedValue),
                Score = Convert.ToInt32(textBox2_subname.Text)
            };

            _markController.AddMark(mark);
            LoadMarks();
            ClearInputs();
            MessageBox.Show("Mark Added Successfully!");
        }

        //  Update Mark Button
        private void button2_edit_Click(object sender, EventArgs e)
        {
            if (selectedMarkId == -1)
            {
                MessageBox.Show("Please select a mark to update.");
                return;
            }

            Mark mark = new Mark
            {
                MarkId = selectedMarkId,
                StudentId = Convert.ToInt32(comboBox1.SelectedValue),
                ExamId = Convert.ToInt32(comboBox2.SelectedValue),
                Score = Convert.ToInt32(textBox2_subname.Text)
            };

            _markController.UpdateMark(mark);
            LoadMarks();
            ClearInputs();
            MessageBox.Show("Mark Updated Successfully!");
        }

        //  GridView Selection Changed


        //  Back to Dashboard
        private void button1_Click(object sender, EventArgs e)
        {
            ExamForm examForm = new ExamForm(_userRole);
            examForm.Show();
            this.Hide();
        }

        private void dataGridView2_exam_marks_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dataGridView2_exam_marks.SelectedRows.Count > 0)
            {
                var row = dataGridView2_exam_marks.SelectedRows[0];
                var markView = row.DataBoundItem as MarkViewModel;

                if (markView != null)
                {
                    selectedMarkId = markView.MarkId;

                    // Fetch full Mark by ID (to get StudentId, ExamId)
                    var mark = _markController.GetMarkById(selectedMarkId);
                    if (mark != null)
                    {
                        // Set Student
                        comboBox1.SelectedValue = mark.StudentId;

                        // Set Exam
                        comboBox2.SelectedValue = mark.ExamId;

                        // Set Score
                        textBox2_subname.Text = mark.Score.ToString();
                    }
                }
            }
            else
            {
                ClearInputs();
            }
        }
    }


}
