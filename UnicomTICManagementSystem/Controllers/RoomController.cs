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
    internal class RoomController
    {
        public string AddRoom(Room room)
        {
            using (var conn = Dbconfig.GetConnection())
            {
                string insertQuery = "INSERT INTO Rooms (RoomName, Roomtype) VALUES (@roomName, @roomType)";
                SQLiteCommand cmd = new SQLiteCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@roomName", room.RoomName);
                cmd.Parameters.AddWithValue("@roomType", room.Roomtype);
                cmd.ExecuteNonQuery();
            }
            return "Room Added Successfully!";
        }

        public List<Room> GetAllRooms()
        {
            List<Room> rooms = new List<Room>();
            string query = "SELECT * FROM Rooms";

            using (var conn = Dbconfig.GetConnection())
            {
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Room room = new Room
                    {
                        RoomId = reader.GetInt32(0),
                        RoomName = reader.GetString(1),
                        Roomtype = reader.GetString(2)
                    };
                    rooms.Add(room);
                }
            }
            return rooms;
        }

        public Room GetRoomById(int id)
        {
            using (var conn = Dbconfig.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM Rooms WHERE RoomId = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Room
                        {
                            RoomId = reader.GetInt32(0),
                            RoomName = reader.GetString(1),
                            Roomtype = reader.GetString(2)
                        };
                    }
                }
            }
            return null;
        }

        public void UpdateRoom(Room room)
        {
            using (var conn = Dbconfig.GetConnection())
            {
                var cmd = new SQLiteCommand("UPDATE Rooms SET RoomName = @name, Roomtype = @type WHERE RoomId = @id", conn);
                cmd.Parameters.AddWithValue("@name", room.RoomName);
                cmd.Parameters.AddWithValue("@type", room.Roomtype);
                cmd.Parameters.AddWithValue("@id", room.RoomId);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteRoom(int id)
        {
            using (var conn = Dbconfig.GetConnection())
            {
                var cmd = new SQLiteCommand("DELETE FROM Rooms WHERE RoomId = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
