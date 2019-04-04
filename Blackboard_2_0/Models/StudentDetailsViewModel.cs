using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blackboard_2_0.Models.Data;

namespace Blackboard_2_0.Models
{
    public class StudentDetailsViewModel
    {
        public Student Student { get; set; }
        public List<Attends> Attends { get; set; }
    }
}
