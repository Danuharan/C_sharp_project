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
    internal class ExamController
    {
        public string AddExam(Exam exam)
        {
            using (var dbConn_exam = Dbconfig.GetConnection())
            {
                string addExamQuery = "INSERT INTO Exams (ExamName, SubjectId) VALUES (@examname, @subjectid)";

                SQLiteCommand insertExamCommand = new SQLiteCommand(addExamQuery, dbConn_exam);
                insertExamCommand.Parameters.AddWithValue("@examname", exam.ExamName);
                insertExamCommand.Parameters.AddWithValue("@subjectid", exam.SubjectId);

                insertExamCommand.ExecuteNonQuery();
            }

            return "Exam Added Successfully.....";
        }



        public List<Exam> GetAllExams()
        {
            var exams = new List<Exam>();

            using (var conn = Dbconfig.GetConnection())
            {
                var cmd = new SQLiteCommand(@"
            SELECT e.ExamId, e.ExamName, e.SubjectId, s.SubjectName
            FROM Exams e
            LEFT JOIN Subjects s ON e.SubjectId = s.SubjectId", conn);

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Exam exam = new Exam
                    {
                        ExamId = reader.GetInt32(0),
                        ExamName = reader.GetString(1),
                        SubjectId = reader.GetInt32(2)

                    };

                    exams.Add(exam);
                }
            }

            return exams;
        }

        public Exam GetExamById(int id)
        {
            using (var conn = Dbconfig.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM Exams WHERE ExamId = @ExamId", conn);
                cmd.Parameters.AddWithValue("@ExamId", id);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Exam
                        {
                            ExamId = reader.GetInt32(0),
                            ExamName = reader.GetString(1),
                            SubjectId = reader.GetInt32(2)
                        };
                    }
                }
            }

            return null;
        }

        public void UpdateExam(Exam exam)
        {
            using (var conn = Dbconfig.GetConnection())
            {
                var command = new SQLiteCommand("UPDATE Exams SET ExamName = @ExamName, SubjectId = @SubjectId WHERE ExamId = @ExamId", conn);
                command.Parameters.AddWithValue("@ExamName", exam.ExamName);
                command.Parameters.AddWithValue("@SubjectId", exam.SubjectId);
                command.Parameters.AddWithValue("@ExamId", exam.ExamId);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteExam(int examId)
        {
            using (var conn = Dbconfig.GetConnection())
            {
                var command = new SQLiteCommand("DELETE FROM Exams WHERE ExamId = @Id", conn);
                command.Parameters.AddWithValue("@Id", examId);
                command.ExecuteNonQuery();
            }
        }
    }
}
