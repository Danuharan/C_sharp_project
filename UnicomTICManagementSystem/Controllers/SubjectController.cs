using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTICManagementSystem.Models;
using UnicomTICManagementSystem.Repositories;

namespace UnicomTICManagementSystem.Controllers
{
    internal class SubjectController
    {

        public string AddSubject(Subject subject)
        {
            using (var Dbconn_course = Dbconfig.GetConnection())
            {
                string addSubjectQuery = "INSERT INTO Subjects (SubjectName, CourseId) VALUES (@SubjectName, @CourseId)";

                SQLiteCommand insertCourseCommand = new SQLiteCommand(addSubjectQuery, Dbconn_course);
               
                insertCourseCommand.Parameters.AddWithValue("@SubjectName", subject.SubjectName);
                insertCourseCommand.Parameters.AddWithValue("@CourseId", subject.CourseId);
                insertCourseCommand.ExecuteNonQuery();
                

            }

            return "Subject Added Successfully.....";

        }

        public List<Subject> GetAllSubjects()
        {
            var subjects = new List<Subject>();

            using (var conn = Dbconfig.GetConnection())
            {

                var cmd = new SQLiteCommand(@"
                    SELECT s.SubjectId, s.SubjectName, s.CourseId, cou.CourseName AS CourseName
                    FROM Subjects s
                    LEFT JOIN Courses cou ON s.CourseId = cou.CourseId", conn);

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Subject subject = new Subject
                    {
                        SubjectId = reader.GetInt32(0),
                        SubjectName = reader.GetString(1),
                        CourseId = reader.GetInt32(2),
                        //CourseName = reader.GetString(3)
                        CourseName = reader.IsDBNull(3) ? "Unknown" : reader.GetString(3)
                    
                }
                ;
                    subjects.Add(subject);

                }
            }

            return subjects;
        }
        public Subject GetSubjectBy_SubjectId(int id)
        {
            using (var conn = Dbconfig.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM Subjects WHERE SubjectId = @SubjectId", conn);
                cmd.Parameters.AddWithValue("@SubjectId", id);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Subject
                        {
                            SubjectId = reader.GetInt32(0),
                            SubjectName = reader.GetString(1),
                            CourseId = reader.GetInt32(2)

                        };
                    }
                }
            }

            return null;
        }

        public void UpdateSubject(Subject subject)
        {
            using (var conn = Dbconfig.GetConnection())
            {
                var command = new SQLiteCommand("UPDATE Subjects SET SubjectName = @SubjectName, CourseId = @CourseId WHERE SubjectId = @SubjectId", conn);
                command.Parameters.AddWithValue("@SubjectName", subject.SubjectName);
                command.Parameters.AddWithValue("@CourseId", subject.CourseId);
                command.Parameters.AddWithValue("@SubjectId", subject.SubjectId);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteSubject(int subjectId)
        {
            using (var conn = Dbconfig.GetConnection())
            {
                var command = new SQLiteCommand("DELETE FROM Subjects WHERE SubjectId = @Id", conn);
                command.Parameters.AddWithValue("@Id", subjectId);
                command.ExecuteNonQuery();
            }
        }
    }
}
