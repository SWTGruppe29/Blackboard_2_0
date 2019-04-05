using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blackboard_2_0.Models.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Blackboard_2_0.Models
{
    public class AddStudentToGroupViewModel
    {
        public SelectList Attends { get; set; } = new SelectList(new List<Attends>());
        public int AssignersId { get; set; }
        public string StudentId { get; set; }
        public int AssignmentId { get; set; }
    }
}
