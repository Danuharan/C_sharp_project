using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UnicomTICManagementSystem.Repositories
{
    internal static class Migration
    {
        public static void CreateTables()
        {
            using (var getDbConn = Dbconfig.GetConnection())
            {                                                                                           // To Create tables in DB
                string CreateTables = @"                                                       
                        CREATE TABLE IF NOT EXISTS Users (
                            UserId INTEGER PRIMARY KEY AUTOINCREMENT,
                            UserName TEXT,
                            Password TEXT,
                            Role TEXT,
                            created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
                            updated_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
                        );

                        CREATE TABLE IF NOT EXISTS Courses (
                            CourseID INTEGER PRIMARY KEY AUTOINCREMENT,
                            CourseName TEXT
                        );

                        CREATE TABLE IF NOT EXISTS Subjects (
                            SubjectID INTEGER PRIMARY KEY AUTOINCREMENT,
                            SubjectName TEXT,
                            CourseID INTEGER,
                            FOREIGN KEY(CourseID) REFERENCES Courses(CourseID)
                        );

                        CREATE TABLE IF NOT EXISTS Students (
                            StudentID INTEGER PRIMARY KEY AUTOINCREMENT,
                            Name TEXT,
                            CourseID INTEGER,
                            FOREIGN KEY(CourseID) REFERENCES Courses(CourseID)
                        );

                        CREATE TABLE IF NOT EXISTS Exams (
                            ExamID INTEGER PRIMARY KEY AUTOINCREMENT,
                            ExamName TEXT,
                            SubjectID INTEGER,
                            FOREIGN KEY(SubjectID) REFERENCES Subjects(SubjectID)
                        );

                        CREATE TABLE IF NOT EXISTS Marks (
                            MarkID INTEGER PRIMARY KEY AUTOINCREMENT,
                            StudentID INTEGER,
                            ExamID INTEGER,
                            Score INTEGER,
                            FOREIGN KEY(StudentID) REFERENCES Students(StudentID),
                            FOREIGN KEY(ExamID) REFERENCES Exams(ExamID)
                        );

                        CREATE TABLE IF NOT EXISTS Rooms (
                            RoomID INTEGER PRIMARY KEY AUTOINCREMENT,
                            RoomName TEXT,
                            RoomType TEXT
                        );

                        CREATE TABLE IF NOT EXISTS Timetables (
                            TimetableID INTEGER PRIMARY KEY AUTOINCREMENT,
                            SubjectID INTEGER,
                            TimeSlot TEXT,
                            RoomID INTEGER,
                            FOREIGN KEY(SubjectID) REFERENCES Subjects(SubjectID),
                            FOREIGN KEY(RoomID) REFERENCES Rooms(RoomID)
                        );
                    
                ";

                //string createTriggerQuery = @"
                //            CREATE TRIGGER IF NOT EXISTS update_Users_updated_at
                //            AFTER UPDATE ON Users
                //            FOR EACH ROW
                //            BEGIN
                //                UPDATE Users SET updated_at = CURRENT_TIMESTAMP WHERE UserID = OLD.UserID;
                //            END;";

                SQLiteCommand command = new SQLiteCommand(CreateTables, getDbConn);
                command.ExecuteNonQuery();
                MessageBox.Show("Successfully table created...");


                //using (SQLiteCommand cmd = new SQLiteCommand(createTriggerQuery, getDbConn))
                //{
                //    cmd.ExecuteNonQuery();
                //}
            }
        }
    }
}
