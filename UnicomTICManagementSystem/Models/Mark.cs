using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Models
{
    internal class Mark
    {
        public int MarkId { get; set; }
        public int StudentId { get; set; }
        public int ExamId { get; set; }
        public int Score { get; set; }
    }


    internal class MarkViewModel
    {
        public int MarkId { get; set; }
        public string StudentName { get; set; }
        public string SubjectName { get; set; }
        public string ExamName { get; set; }
        public int Score { get; set; }
    }
}
