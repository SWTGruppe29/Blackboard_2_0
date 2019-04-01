using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blackboard_2_0.Models.Data
{
    public class Teaches
    {
        public int CourseId { get; set; }
        public Course Course { get; set; }

        public int AuId { get; set; }
        public Teacher Teacher { get; set; }

        public string Role { get; set; }

    }
}
