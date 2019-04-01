using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Blackboard_2_0.Models.Data
{
    public class Grader
    {
        public int AuId { get; set; }
        public Teacher Teacher { get; set; }
        public int AssignmentId { get; set; }
        public Assignment Assignment { get; set; }

    }
}
