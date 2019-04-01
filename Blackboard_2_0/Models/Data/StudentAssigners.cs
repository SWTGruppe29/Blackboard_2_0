using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blackboard_2_0.Models.Data
{
    public class StudentAssigners
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int AssignersId { get; set; }
        public Assigners Assigners { get; set; }
    }
}
