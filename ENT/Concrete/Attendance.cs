using System;
using System.Collections.Generic;
using System.Text;

namespace ENT.Concrete
{
    public class Attendance
    {
        public int AttendanceId { get; set; }
        public string ReasonForDeparture { get; set; }
        public DateTime DepartureDate { get; set; }
        public int TotalDuration { get; set; }
        public DateTime JoinDate { get; set; }
        public int UserId { get; set; }
    }
}
