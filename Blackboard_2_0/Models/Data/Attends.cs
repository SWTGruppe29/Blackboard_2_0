using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Blackboard_2_0.Models.Data
{
    public class Attends
    {
        
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public string Status { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }

    }
}
