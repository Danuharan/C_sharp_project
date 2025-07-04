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
    internal class StudentController
    {
        public string AddStudent(Student student)
        {
            using (var Dbconn_student = Dbconfig.GetConnection())
            {
                string addStudentQuery = "INSERT INTO Students (StudentName, CourseId) VALUES (@studentname, @courseid)";

                SQLiteCommand insertStudentCommand = new SQLiteCommand(addStudentQuery, Dbconn_student);
                insertStudentCommand.Parameters.AddWithValue("@studentname", student.StudentName);
                insertStudentCommand.Parameters.AddWithValue("@courseid", student.CourseId);

                insertStudentCommand.ExecuteNonQuery();
            }

            return "Student Added Successfully.....";
        }


        public List<Student> GetAllStudents()
        {
            var students = new List<Student>();

            using (var conn = Dbconfig.GetConnection())
            {
                var cmd = new SQLiteCommand(@"
            SELECT s.StudentId, s.StudentName, s.CourseId, c.CourseName
            FROM Students s
            LEFT JOIN Courses c ON s.CourseId = c.CourseId", conn);

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Student student = new Student
                    {
                        StudentId = reader.GetInt32(0),
                        StudentName = reader.GetString(1),
                        CourseId = reader.GetInt32(2),
                        
                    };

                    students.Add(student);
                }
            }

            return students;
        }


        public Student GetStudentById(int id)
        {
            using (var conn = Dbconfig.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM Students WHERE StudentId = @StudentId", conn);
                cmd.Parameters.AddWithValue("@StudentId", id);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Student
                        {
                            StudentId = reader.GetInt32(0),
                            StudentName = reader.GetString(1),
                            CourseId = reader.GetInt32(2)
                        };
                    }
                }
            }

            return null;
        }

        public void UpdateStudent(Student student)
        {
            using (var conn = Dbconfig.GetConnection())
            {
                var command = new SQLiteCommand("UPDATE Students SET StudentName = @StudentName, CourseId = @CourseId WHERE StudentId = @StudentId", conn);
                command.Parameters.AddWithValue("@StudentName", student.StudentName);
                command.Parameters.AddWithValue("@CourseId", student.CourseId);
                command.Parameters.AddWithValue("@StudentId", student.StudentId);
                command.ExecuteNonQuery();
            }
        }


        public void DeleteStudent(int studentId)
        {
            using (var conn = Dbconfig.GetConnection())
            {
                var command = new SQLiteCommand("DELETE FROM Students WHERE StudentId = @Id", conn);
                command.Parameters.AddWithValue("@Id", studentId);
                command.ExecuteNonQuery();
            }
        }
    }
}
