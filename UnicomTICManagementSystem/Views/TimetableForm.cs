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
    public partial class TimetableForm : Form
    {
        private TimetableController _timetableController = new TimetableController();
        private int selectedTimetableId = -1;
        private string _userRole;

        public TimetableForm(string role)
        {
            InitializeComponent();
            _userRole = role;

            LoadSubjectNames();
            LoadTimeSlots();
            LoadRoomNames();
            LoadTimetables();
        }

        private void LoadSubjectNames()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Java");
            comboBox1.Items.Add("C#");
            comboBox1.Items.Add("MongoDB");
            comboBox1.Items.Add("PostgreSQL");
        }

        private void LoadTimeSlots()
        {
            comboBox2.Items.Clear();
            comboBox2.Items.Add("8.00 AM - 10.00 AM");
            comboBox2.Items.Add("10.30 AM - 12.30 PM");
            comboBox2.Items.Add("1.30 PM - 3.30 PM");
            comboBox2.Items.Add("4.00 PM - 6.00 PM");
        }

        private void LoadRoomNames()
        {
            comboBox3.Items.Clear();
            comboBox3.Items.Add("Lap1");
            comboBox3.Items.Add("Lap2");
            comboBox3.Items.Add("Hall1");
            comboBox3.Items.Add("Hall2");
        }

        private void LoadTimetables()
        {
            List<Timetable> timetables = _timetableController.GetAllTimetables();
            dataGridView2_TimeTable.DataSource = timetables;
        }

        private void ClearInputs()
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            selectedTimetableId = -1;
        }

        // Add Button
        private void button2_add_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null || comboBox3.SelectedItem == null)
            {
                MessageBox.Show("Please select Subject, TimeSlot, and Room.");
                return;
            }

            Timetable timetable = new Timetable
            {
                SubjectName = comboBox1.SelectedItem.ToString(),
                TimeSlot = comboBox2.SelectedItem.ToString(),
                RoomName = comboBox3.SelectedItem.ToString()
            };

            string getMessage = _timetableController.AddTimetable(timetable);
            MessageBox.Show(getMessage);

            LoadTimetables();
            ClearInputs();
        }

        // Edit Button
        private void button2_edit_Click(object sender, EventArgs e)
        {
            if (selectedTimetableId == -1)
            {
                MessageBox.Show("Please select a timetable to update.");
                return;
            }

            Timetable timetable = new Timetable
            {
                TimetableId = selectedTimetableId,
                SubjectName = comboBox1.SelectedItem?.ToString(),
                TimeSlot = comboBox2.SelectedItem?.ToString(),
                RoomName = comboBox3.SelectedItem?.ToString()
            };

            string getMessage = _timetableController.UpdateTimetable(timetable);
            MessageBox.Show(getMessage);

            LoadTimetables();
            ClearInputs();
        }

        // Delete Button
        private void button2_delete_Click(object sender, EventArgs e)
        {
            if (selectedTimetableId == -1)
            {
                MessageBox.Show("Please select a timetable to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this timetable?", "Confirm Delete", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                string getMessage = _timetableController.DeleteTimetable(selectedTimetableId);
                MessageBox.Show(getMessage);

                LoadTimetables();
                ClearInputs();
            }
        }

        // GridView Row Selection Changed
        private void dataGridView2_TimeTable_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2_TimeTable.SelectedRows.Count > 0)
            {
                var row = dataGridView2_TimeTable.SelectedRows[0];
                int timetableId = Convert.ToInt32(row.Cells["TimetableId"].Value);

                Timetable selectedTimetable = _timetableController.GetTimetableById(timetableId);

                if (selectedTimetable != null)
                {
                    selectedTimetableId = selectedTimetable.TimetableId;

                    // Set Subject
                    int subjectIndex = comboBox1.FindStringExact(selectedTimetable.SubjectName);
                    if (subjectIndex >= 0)
                        comboBox1.SelectedIndex = subjectIndex;

                    // Set TimeSlot
                    int timeSlotIndex = comboBox2.FindStringExact(selectedTimetable.TimeSlot);
                    if (timeSlotIndex >= 0)
                        comboBox2.SelectedIndex = timeSlotIndex;

                    // Set RoomName
                    int roomIndex = comboBox3.FindStringExact(selectedTimetable.RoomName);
                    if (roomIndex >= 0)
                        comboBox3.SelectedIndex = roomIndex;
                }
            }
            else
            {
                ClearInputs();
            }
        }

        // Back Button
        private void button1_Click(object sender, EventArgs e)
        {
            MainForm dashboard = new MainForm(_userRole);
            dashboard.Show();
            this.Hide();
        }
    }
}
