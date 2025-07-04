using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTICManagementSystem.Models;
using UnicomTICManagementSystem.Repositories;

namespace UnicomTICManagementSystem.Controllers
{
    internal class TimetableController
        {
            // Add Timetable
            public string AddTimetable(Timetable timetable)
            {
                using (var conn = Dbconfig.GetConnection())
                {
                    string query = "INSERT INTO Timetables (SubjectName, TimeSlot, RoomName) VALUES (@subject, @timeSlot, @roomName)";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@subject", timetable.SubjectName);
                    cmd.Parameters.AddWithValue("@timeSlot", timetable.TimeSlot);
                    cmd.Parameters.AddWithValue("@roomName", timetable.RoomName);
                    cmd.ExecuteNonQuery();
                }
                return "Timetable Added Successfully!";
            }

            // Get All Timetables
            public List<Timetable> GetAllTimetables()
            {
                List<Timetable> timetables = new List<Timetable>();
                string query = "SELECT * FROM Timetables";

                using (var conn = Dbconfig.GetConnection())
                {
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Timetable timetable = new Timetable
                        {
                            TimetableId = reader.GetInt32(0),
                            SubjectName = reader.GetString(1),
                            TimeSlot = reader.GetString(2),
                            RoomName = reader.GetString(3)
                        };
                        timetables.Add(timetable);
                    }
                }
                return timetables;
            }

            // Get Single Timetable by ID
            public Timetable GetTimetableById(int id)
            {
                using (var conn = Dbconfig.GetConnection())
                {
                    var cmd = new SQLiteCommand("SELECT * FROM Timetables WHERE TimetableId = @id", conn);
                    cmd.Parameters.AddWithValue("@id", id);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Timetable
                            {
                                TimetableId = reader.GetInt32(0),
                                SubjectName = reader.GetString(1),
                                TimeSlot = reader.GetString(2),
                                RoomName = reader.GetString(3)
                            };
                        }
                    }
                }
                return null;
            }

            // Update Timetable
            public string UpdateTimetable(Timetable timetable)
            {
                using (var conn = Dbconfig.GetConnection())
                {
                    var cmd = new SQLiteCommand("UPDATE Timetables SET SubjectName = @subject, TimeSlot = @timeSlot, RoomName = @roomName WHERE TimetableId = @id", conn);
                    cmd.Parameters.AddWithValue("@subject", timetable.SubjectName);
                    cmd.Parameters.AddWithValue("@timeSlot", timetable.TimeSlot);
                    cmd.Parameters.AddWithValue("@roomName", timetable.RoomName);
                    cmd.Parameters.AddWithValue("@id", timetable.TimetableId);
                    cmd.ExecuteNonQuery();
                }
                return "Timetable Updated Successfully!";
            }

            // Delete Timetable
            public string DeleteTimetable(int id)
            {
                using (var conn = Dbconfig.GetConnection())
                {
                    var cmd = new SQLiteCommand("DELETE FROM Timetables WHERE TimetableId = @id", conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
                return "Timetable Deleted Successfully!";
            }
        }
    
}
