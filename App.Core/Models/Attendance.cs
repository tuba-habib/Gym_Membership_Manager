using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Models
{
    public class Attendance
    {
        public string Id { get; set; }
        public string MemberId { get; set; }
        public string MemberName { get; set; }
        public DateTime CheckInDate { get; set; }
        public TimeSpan CheckInTime { get; set; }
        public string Notes { get; set; }
    }
}
