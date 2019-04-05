using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blackboard_2_0.Models.Data
{
    public class Assignment
    {
        public int MaxAssigners { get; set; }
        public string Name { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int AssignmentId { get; set; }
        public List<HandIn> HandIns { get; set; }
        public ICollection<Assigners> Assigners { get; set; }
    }
}
