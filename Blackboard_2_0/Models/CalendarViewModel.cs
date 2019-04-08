using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blackboard_2_0.Models.Data;

namespace Blackboard_2_0.Models
{
    public class CalendarViewModel
    {
        public CalendarViewModel()
        {
            Calendars = new List<Calendar>();
            
        }
        public List<Calendar> Calendars { get; set; }
        public string CourseName { get; set; }

    }
}
