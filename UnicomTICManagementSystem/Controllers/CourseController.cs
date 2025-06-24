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
    internal class CourseController
    {
        public string AddCourse (Course course)
        {
            using (var Dbconn_course = Dbconfig.GetConnection())
            {
                string addCourseQuery = "INSERT INTO Courses (CourseName) VALUES (@coursename)";

                SQLiteCommand insertCourseCommand = new SQLiteCommand(addCourseQuery, Dbconn_course);
                insertCourseCommand.Parameters.AddWithValue("@coursename", course.CourseName);
                insertCourseCommand.ExecuteNonQuery();
            }

            return "Course Added Successfully.....";
            
        }


        public List<Course> GetAllCourses()
        {
            List<Course> courses = new List<Course>();
            string getCoursesQuery = "SELECT * FROM Courses";

            using (var conn = Dbconfig.GetConnection())
            {

                SQLiteCommand getCoursesCommand = new SQLiteCommand(getCoursesQuery, conn);
                var reader = getCoursesCommand.ExecuteReader();

                while (reader.Read())
                {
                    Course course = new Course();
                    course.CourseId = reader.GetInt32(0);
                    course.CourseName = reader.GetString(1);
                   

                    courses.Add(course);


                }
            }

            return courses;
        }


        
        public Course GetCourseBy_CourseId(int id)  
        {
            using (var conn = Dbconfig.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM Courses WHERE CourseId = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Course
                        {
                            CourseId = reader.GetInt32(0),
                            CourseName = reader.GetString(1),
                            
                        };
                    }
                }
            }

            return null;
        }


        public void UpdateCourse(Course course)
        {
            using (var conn = Dbconfig.GetConnection())
            {
                var command = new SQLiteCommand("UPDATE Courses SET CourseName = @Name WHERE CourseId = @Id", conn);
                command.Parameters.AddWithValue("@Name", course.CourseName);
                command.Parameters.AddWithValue("@Id", course.CourseId);
                command.ExecuteNonQuery();
            }
        }


        public void DeleteCourse(int courseId)
        {
            using (var conn = Dbconfig.GetConnection())
            {
                var command = new SQLiteCommand("DELETE FROM Courses WHERE CourseId = @Id", conn);
                command.Parameters.AddWithValue("@Id", courseId);
                command.ExecuteNonQuery();
            }
        }

    }
}
