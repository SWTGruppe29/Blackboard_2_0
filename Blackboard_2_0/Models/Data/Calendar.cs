using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Blackboard_2_0.Models.Data
{
    public class Calendar
    {
        public int  EventId { get; set; }
        
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public Course Course { get; set; }

        [ForeignKey("Course")]
        public string CourseName { get; set; }

        public DateTime EventDate { get; set; }
        public string Type { get; set; }
        public string EventName { get; set; }





    }
}
