using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blackboard_2_0.Models.Data
{
    public class HandIn
    {
        public int AssignmentId { get; set; }
        public Assignment Assignment { get; set; }
        public string Grade { get; set; }
        public int AssignersId { get; set; }
        public Assigners Assigners { get; set; } 
        public int? GraderId { get; set; }
        public Teacher Grader { get; set; }

        public string Text { get; set; }


    }
}
