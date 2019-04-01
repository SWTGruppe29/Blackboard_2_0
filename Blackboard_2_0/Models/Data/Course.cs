using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blackboard_2_0.Models.Data
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }

        public List<Assignment> Assignments { get; set; }

        public List<Teaches> Teachers { get; set; }


    }
}
