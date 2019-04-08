﻿using System;
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
            Courses = new List<Course>();
        }
        public List<Calendar> Calendars { get; set; }
        public List<Course> Courses { get; set; }

    }
}
