using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blackboard_2_0.Models.Data;

namespace Blackboard_2_0.Models
{
    public class GroupHandinViewModel
    {
        public List<Assigners> Assigners { get; set; }
        public int AssignmentId { get; set; }
        public int MaxAssigners { get; set; }
        public int CourseId { get; set; }

    }
}
