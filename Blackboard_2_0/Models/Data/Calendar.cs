using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Blackboard_2_0.Models.Data
{
    public class Calendar
    {
        [Key]
        public int  EventId { get; set; }
        
        [Display(Name = "Course name")]


        public int CourseId { get; set; }
        public List<Course> Course { get; set; }

        [Display(Name = "Event date")]
        public DateTime EventDate { get; set; }
        public string Type { get; set; }

        [Display(Name = "Event name")]
        public string EventName { get; set; }





    }
}
