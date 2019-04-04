using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blackboard_2_0.Models.Data;

namespace Blackboard_2_0.Models
{
    public class CourseViewModel
    {

        public CourseViewModel()
        {
            Students = new List<Attends>();
            Teachers = new List<Teaches>();
        }
        public List<Attends> Students { get; set; }
        public List<Teaches> Teachers { get; set; }
    }
}
