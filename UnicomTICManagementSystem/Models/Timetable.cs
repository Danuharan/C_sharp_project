﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Models
{
    internal class Timetable
    {
        public int TimetableId { get; set; }
        public string SubjectName { get; set; }
        public string TimeSlot { get; set; }
        public string RoomName { get; set; }
    }
}
