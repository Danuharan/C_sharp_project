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
    internal class MarkController
    {
        //  Get Marks for GridView (with names)
        public List<MarkViewModel> GetAllMarks()
        {
            var marks = new List<MarkViewModel>();

            using (var conn = Dbconfig.GetConnection())
            {
                var cmd = new SQLiteCommand(@"
                    SELECT 
                        m.MarkId,
                        s.StudentName,
                        sub.SubjectName,
                        e.ExamName,
                        m.Score
                    FROM Marks m
                    JOIN Students s ON m.StudentId = s.StudentId
                    JOIN Exams e ON m.ExamId = e.ExamId
                    JOIN Subjects sub ON e.SubjectId = sub.SubjectId", conn);

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    marks.Add(new MarkViewModel
                    {
                        MarkId = reader.GetInt32(0),
                        StudentName = reader.GetString(1),
                        SubjectName = reader.GetString(2),
                        ExamName = reader.GetString(3),
                        Score = reader.GetInt32(4)
                    });
                }
            }

            return marks;
        }

        //  Get Single Mark by MarkId (for Edit)
        public Mark GetMarkById(int id)
        {
            using (var conn = Dbconfig.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT MarkId, StudentId, ExamId, Score FROM Marks WHERE MarkId = @MarkId", conn);
                cmd.Parameters.AddWithValue("@MarkId", id);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Mark
                        {
                            MarkId = reader.GetInt32(0),
                            StudentId = reader.GetInt32(1),
                            ExamId = reader.GetInt32(2),
                            Score = reader.GetInt32(3)
                        };
                    }
                }
            }
            return null;
        }

        //  Add New Mark
        public void AddMark(Mark mark)
        {
            using (var conn = Dbconfig.GetConnection())
            {
                var cmd = new SQLiteCommand(
                    "INSERT INTO Marks (StudentId, ExamId, Score) VALUES (@studentId, @examId, @score)", conn);
                cmd.Parameters.AddWithValue("@studentId", mark.StudentId);
                cmd.Parameters.AddWithValue("@examId", mark.ExamId);
                cmd.Parameters.AddWithValue("@score", mark.Score);
                cmd.ExecuteNonQuery();
            }
        }

        //  Update Existing Mark
        public void UpdateMark(Mark mark)
        {
            using (var conn = Dbconfig.GetConnection())
            {
                var cmd = new SQLiteCommand(
                    "UPDATE Marks SET StudentId = @studentId, ExamId = @examId, Score = @score WHERE MarkId = @markId", conn);
                cmd.Parameters.AddWithValue("@studentId", mark.StudentId);
                cmd.Parameters.AddWithValue("@examId", mark.ExamId);
                cmd.Parameters.AddWithValue("@score", mark.Score);
                cmd.Parameters.AddWithValue("@markId", mark.MarkId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}