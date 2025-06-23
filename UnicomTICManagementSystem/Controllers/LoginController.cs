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
    internal class LoginController
    {
        public string AddUser(User user)                   // TO add new user 
        {
            using (var Dbconn = Dbconfig.GetConnection())
            {
                string addUserQuery = "INSERT INTO Users  (UserName, Password, Role, created_at, updated_at) VALUES (@name, @password, @role, @createdAt, @updatedAt)";
                SQLiteCommand insertUserCommand = new SQLiteCommand(addUserQuery, Dbconn);
                insertUserCommand.Parameters.AddWithValue("@name", user.UserName);
                insertUserCommand.Parameters.AddWithValue("@password", user.Password);
                insertUserCommand.Parameters.AddWithValue("@role", user.Role);
                insertUserCommand.Parameters.AddWithValue("@createdAt", user.created_at);
                insertUserCommand.Parameters.AddWithValue("@updatedAt", user.updated_at); // For new records, these are initially the same
                insertUserCommand.ExecuteNonQuery();
            }

            return "User  Added Successfully.....";
        }



        public List<User> GetAllStudents()               // To view existing user or can view subsequently after user added
        {
            List<User> users = new List<User>();
            string getUsersQuery = "SELECT * FROM Users";

            using (var conn = Dbconfig.GetConnection())
            {

                SQLiteCommand getUsersCommand = new SQLiteCommand(getUsersQuery, conn);
                var reader = getUsersCommand.ExecuteReader();

                while (reader.Read())
                {
                    User user = new User();
                    user.UserId = reader.GetInt32(0);
                    user.UserName = reader.GetString(1);
                    user.Password = reader.GetString(2);
                    user.Role = reader.GetString(3);
                    user.created_at = reader.GetDateTime(4);   //  Use GetDateTime
                    user.updated_at = reader.GetDateTime(5);   //  Use GetDateTime

                    users.Add(user);


                }
            }

            return users;
        }


        public User GetUsertBy_UserId(int user_id)                          // To Get the User By using his/her Primary Key (UserId)
        {
            using (var conn = Dbconfig.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM Users WHERE UserID = @UserID", conn);
                cmd.Parameters.AddWithValue("@UserID", user_id);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new User
                        {
                            UserId = reader.GetInt32(0),
                            UserName = reader.GetString(1),
                            Password = reader.GetString(2),
                            Role = reader.GetString(3),
                            //created_at = reader.GetDateTime(4),   //  Use GetDateTime
                            updated_at = reader.GetDateTime(5)   //  Use GetDateTime
                        };
                    }
                }
            }

            return null;
        }


        public void UpdateUser(User user)                           // To update new user/existing user
        {
            using (var conn = Dbconfig.GetConnection())
            {
                var command = new SQLiteCommand("UPDATE Users SET UserName = @Name, Password = @Password, Role = @Role, updated_at = @updatedAt WHERE UserId = @UserID", conn);
                command.Parameters.AddWithValue("@Name", user.UserName);
                command.Parameters.AddWithValue("@Password", user.Password);
                command.Parameters.AddWithValue("@Role", user.Role);
                command.Parameters.AddWithValue("@UserID", user.UserId);
                command.Parameters.AddWithValue("@updatedAt", user.updated_at);
                command.ExecuteNonQuery();
            }
        }


        public void DeleteUser(int UserId)                    // To update existing user entire field
        {
            using (var conn = Dbconfig.GetConnection())
            {
                var command = new SQLiteCommand("DELETE FROM Users WHERE UserId = @Id", conn);
                command.Parameters.AddWithValue("@Id", UserId);
                command.ExecuteNonQuery();
            }
        }
    }
}
