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
    }
}
