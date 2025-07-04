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
        public partial class RoomForm : Form
        {
            private RoomController _roomController;
            private int selectedRoomId = -1;
            private string _userRole;

            public RoomForm(string role)
            {
                InitializeComponent();
                _userRole = role;

                _roomController = new RoomController();

                LoadRoomNames();
                LoadRoomTypes();
                LoadRooms();
            }

            private void LoadRoomNames()
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Lap1");
                comboBox1.Items.Add("Lap2");
                comboBox1.Items.Add("Hall1");
                comboBox1.Items.Add("Hall2");
            }

            private void LoadRoomTypes()
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Lab");
                comboBox2.Items.Add("Lecture Hall");
            }

            private void LoadRooms()
            {
                List<Room> rooms = _roomController.GetAllRooms();
                dataGridView2_Room.DataSource = rooms;
            }

            private void ClearInputs()
            {
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                selectedRoomId = -1;
            }

            private void button2_add_Click(object sender, EventArgs e)
            {
                if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
                {
                    MessageBox.Show("Please select both Room Name and Room Type.");
                    return;
                }

                Room room = new Room
                {
                    RoomName = comboBox1.SelectedItem.ToString(),
                    Roomtype = comboBox2.SelectedItem.ToString()
                };

                string msg = _roomController.AddRoom(room);
                MessageBox.Show(msg);

                LoadRooms();
                ClearInputs();
            }


            private void dataGridView2_Room_SelectionChanged(object sender, EventArgs e)
            {
            }

            private void button1_Click(object sender, EventArgs e)
            {
                MainForm dashboard = new MainForm(_userRole);
                dashboard.Show();
                this.Hide();
            }

        private void dataGridView2_Room_SelectionChanged_1(object sender, EventArgs e)
        {

            if (dataGridView2_Room.SelectedRows.Count > 0)
            {
                var row = dataGridView2_Room.SelectedRows[0];
                int roomId = Convert.ToInt32(row.Cells[0].Value);  // Assuming first column is RoomId

                Room room = _roomController.GetRoomById(roomId);
                if (room != null)
                {
                    selectedRoomId = room.RoomId;

                    // Set ComboBoxes
                    int roomNameIndex = comboBox1.FindStringExact(room.RoomName);
                    if (roomNameIndex >= 0)
                        comboBox1.SelectedIndex = roomNameIndex;

                    int roomTypeIndex = comboBox2.FindStringExact(room.Roomtype);
                    if (roomTypeIndex >= 0)
                        comboBox2.SelectedIndex = roomTypeIndex;
                }
            }
            else
            {
                ClearInputs();
            }
        }

        private void button2_edit_Click_1(object sender, EventArgs e)
        {

            if (selectedRoomId == -1)
            {
                MessageBox.Show("Please select a room to update.");
                return;
            }

            Room room = new Room
            {
                RoomId = selectedRoomId,
                RoomName = comboBox1.SelectedItem?.ToString(),
                Roomtype = comboBox2.SelectedItem?.ToString()
            };

            _roomController.UpdateRoom(room);
            MessageBox.Show("Room Updated Successfully!");

            LoadRooms();
            ClearInputs();
        }

        private void button2_delete_Click_1(object sender, EventArgs e)
        {
            if (selectedRoomId == -1)
            {
                MessageBox.Show("Please select a room to delete.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this room?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                _roomController.DeleteRoom(selectedRoomId);
                MessageBox.Show("Room Deleted Successfully!");

                LoadRooms();
                ClearInputs();
            }
        }
    }
    }