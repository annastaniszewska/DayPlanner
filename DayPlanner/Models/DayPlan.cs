using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DayPlanner.Models
{
    public class DayPlan
    {
        public int Id { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public ICollection<Activity> Activities { get; set; }

        public DayPlan()
        {
            Activities = new Collection<Activity>();
        }
    }
}
