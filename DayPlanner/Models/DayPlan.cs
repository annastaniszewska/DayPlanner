using System;
using System.Collections.Generic;

namespace DayPlanner.Models
{
    public class DayPlan
    {
        public int Id { get; set; }

        public DateTime CurrentDate 
        {
            get
            {
                return DateTime.Now;
            }
        }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public double PlannedDuration 
        {
            get
            {
                return (StartTime - EndTime).TotalMinutes;
            }
        }

        public ICollection<Activity> Activities { get; set; }
    }
}
