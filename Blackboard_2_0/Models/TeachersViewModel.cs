using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blackboard_2_0.Models.Data;

namespace Blackboard_2_0.Models
{
    public class TeachersViewModel
    {
        public TeachersViewModel()
        {
            Courses = new List<Teaches>();
            HandIns = new List<HandIn>();
        }

        public List<Teaches> Courses { get; set; }
        public List<HandIn> HandIns { get; set; }
    }
}
