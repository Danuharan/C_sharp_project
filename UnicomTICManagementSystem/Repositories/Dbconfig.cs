using System;
using System.Collections.Generic;
using System.Data.SQLite;     //This enables to use SQLite in our C# code.
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Repositories
{
    internal class Dbconfig
    {
        private static string connectionString = "Data Source = unicomtic.db;Version=3;";

        // Get a database connection (Just open existing DB)
        public static SQLiteConnection GetConnection()
        {
            var connection = new SQLiteConnection(connectionString);
            connection.Open();
            return connection;
        }

        //Windows Form app can successfully connect to SQLite database (unicomtic.db)



        // Create tables
        //public static void CreateTables()
        //{
        //    using (var conn = new SQLiteConnection(connectionString))
        //    {
        //        conn.Open();
        //        using (var cmd = new SQLiteCommand(conn))
        //        {
        //            cmd.CommandText = @"
        //                CREATE TABLE IF NOT EXISTS Users (
        //                    UserID INTEGER PRIMARY KEY AUTOINCREMENT,
        //                    Username TEXT,
        //                    Password TEXT,
        //                    Role TEXT
        //                );

        //                CREATE TABLE IF NOT EXISTS Courses (
        //                    CourseID INTEGER PRIMARY KEY AUTOINCREMENT,
        //                    CourseName TEXT
        //                );

        //                CREATE TABLE IF NOT EXISTS Subjects (
        //                    SubjectID INTEGER PRIMARY KEY AUTOINCREMENT,
        //                    SubjectName TEXT,
        //                    CourseID INTEGER,
        //                    FOREIGN KEY(CourseID) REFERENCES Courses(CourseID)
        //                );

        //                CREATE TABLE IF NOT EXISTS Students (
        //                    StudentID INTEGER PRIMARY KEY AUTOINCREMENT,
        //                    Name TEXT,
        //                    CourseID INTEGER,
        //                    FOREIGN KEY(CourseID) REFERENCES Courses(CourseID)
        //                );

        //                CREATE TABLE IF NOT EXISTS Exams (
        //                    ExamID INTEGER PRIMARY KEY AUTOINCREMENT,
        //                    ExamName TEXT,
        //                    SubjectID INTEGER,
        //                    FOREIGN KEY(SubjectID) REFERENCES Subjects(SubjectID)
        //                );

        //                CREATE TABLE IF NOT EXISTS Marks (
        //                    MarkID INTEGER PRIMARY KEY AUTOINCREMENT,
        //                    StudentID INTEGER,
        //                    ExamID INTEGER,
        //                    Score INTEGER,
        //                    FOREIGN KEY(StudentID) REFERENCES Students(StudentID),
        //                    FOREIGN KEY(ExamID) REFERENCES Exams(ExamID)
        //                );

        //                CREATE TABLE IF NOT EXISTS Rooms (
        //                    RoomID INTEGER PRIMARY KEY AUTOINCREMENT,
        //                    RoomName TEXT,
        //                    RoomType TEXT
        //                );

        //                CREATE TABLE IF NOT EXISTS Timetables (
        //                    TimetableID INTEGER PRIMARY KEY AUTOINCREMENT,
        //                    SubjectID INTEGER,
        //                    TimeSlot TEXT,
        //                    RoomID INTEGER,
        //                    FOREIGN KEY(SubjectID) REFERENCES Subjects(SubjectID),
        //                    FOREIGN KEY(RoomID) REFERENCES Rooms(RoomID)
        //                );
        //            ";
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //}
    }
}

        
