using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Blackboard_2_0.Models.Data
{
    public class GradeViewModel
    {
        public SelectList GraderSelectList { get; set; }
        public int GraderId { get; set; }

        public HandIn HandIn { get; set; }

        public int AssignmentId { get; set; }
    }
}
