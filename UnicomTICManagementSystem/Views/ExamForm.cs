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
    public partial class ExamForm : Form
    {
        private readonly ExamController _examController;
        private readonly SubjectController _subjectController;
        private string _userRole;

        private int selectedExamId = -1;
        public ExamForm(string role)
        {
            InitializeComponent();
            _userRole = role;

            _subjectController = new SubjectController();
            LoadSubjectsIntoComboBox();
            _examController = new ExamController();
            LoadExams();
        }

        private void LoadExams()
        {

            var exams = _examController.GetAllExams();
            dataGridView2_exam_marks.DataSource = exams;

        }

        private void ClearInputs()
        {
            textBox2_examname.Text = "";
            comboBox1.Text = "";

        }

        private void LoadSubjectsIntoComboBox()
        {
            var subjects = _subjectController.GetAllSubjects();
            comboBox1.DataSource = subjects;
            comboBox1.DisplayMember = "SubjectName";
            comboBox1.ValueMember = "SubjectId";
        }
        private void label_form_title_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MarkForm markForm = new MarkForm(_userRole);   //  Pass role here
            markForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm dashboard = new MainForm(_userRole);  //  Go back with correct role
            dashboard.Show();
            this.Hide();
        }

        private void button2_add_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Please select a subject before adding an exam.");
                return;
            }

            Exam exam = new Exam
            {
                ExamName = textBox2_examname.Text,
                SubjectId = Convert.ToInt32(comboBox1.SelectedValue)
            };

            string getMessage = _examController.AddExam(exam);
            MessageBox.Show(getMessage);

            LoadExams();
            ClearInputs();
        }

        private void dataGridView2_exam_marks_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2_exam_marks.SelectedRows.Count > 0)
            {
                var row = dataGridView2_exam_marks.SelectedRows[0];
                var examView = row.DataBoundItem as Exam;

                if (examView != null)
                {
                    selectedExamId = examView.ExamId;

                    var exam = _examController.GetExamById(selectedExamId);
                    if (exam != null)
                    {
                        textBox2_examname.Text = exam.ExamName;
                        comboBox1.SelectedValue = exam.SubjectId;
                    }
                }
            }
            else
            {
                ClearInputs();
                selectedExamId = -1;
            }
        }

        private void button2_edit_Click(object sender, EventArgs e)
        {
            if (selectedExamId == -1)
            {
                MessageBox.Show("Please select an exam to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(textBox2_examname.Text))
            {
                MessageBox.Show("Please enter both Exam Name and Subject.");
                return;
            }

            var exam = new Exam
            {
                ExamId = selectedExamId,
                ExamName = textBox2_examname.Text,
                SubjectId = Convert.ToInt32(comboBox1.SelectedValue)
            };

            _examController.UpdateExam(exam);
            LoadExams();
            ClearInputs();
            MessageBox.Show("Exam Updated Successfully");
        }

        private void textBox2_examname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
