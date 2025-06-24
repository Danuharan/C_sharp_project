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
                            CourseId INTEGER PRIMARY KEY AUTOINCREMENT,
                            CourseName TEXT
                        );

                        CREATE TABLE IF NOT EXISTS Subjects (
                            SubjectId INTEGER PRIMARY KEY AUTOINCREMENT,
                            SubjectName TEXT,
                            CourseId INTEGER,
                            FOREIGN KEY(CourseId) REFERENCES Courses(CourseId)
                        );

                        CREATE TABLE IF NOT EXISTS Students (
                            StudentId INTEGER PRIMARY KEY AUTOINCREMENT,
                            StudentName TEXT,
                            CourseId INTEGER,
                            FOREIGN KEY(CourseId) REFERENCES Courses(CourseId)
                        );

                        CREATE TABLE IF NOT EXISTS Exams (
                            ExamId INTEGER PRIMARY KEY AUTOINCREMENT,
                            ExamName TEXT,
                            SubjectId INTEGER,
                            FOREIGN KEY(SubjectId) REFERENCES Subjects(SubjectId)
                        );

                        CREATE TABLE IF NOT EXISTS Marks (
                            MarkId INTEGER PRIMARY KEY AUTOINCREMENT,
                            StudentId INTEGER,
                            ExamId INTEGER,
                            Score INTEGER,
                            FOREIGN KEY(StudentId) REFERENCES Students(StudentId),
                            FOREIGN KEY(ExamId) REFERENCES Exams(ExamId)
                        );

                        CREATE TABLE IF NOT EXISTS Rooms (
                            RoomId INTEGER PRIMARY KEY AUTOINCREMENT,
                            RoomName TEXT,
                            RoomType TEXT
                        );

                        CREATE TABLE IF NOT EXISTS Timetables (
                            TimetableId INTEGER PRIMARY KEY AUTOINCREMENT,
                            SubjectId INTEGER,
                            TimeSlot TEXT,
                            RoomId INTEGER,
                            FOREIGN KEY(SubjectId) REFERENCES Subjects(SubjectId),
                            FOREIGN KEY(RoomId) REFERENCES Rooms(RoomId)
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
