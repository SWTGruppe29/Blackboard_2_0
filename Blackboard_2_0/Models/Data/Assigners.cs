using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Blackboard_2_0.Models.Data
{
    public class Assigners
    {
        [Key]
        public int AssignersId { get; set; }
        public List<HandIn> HandIns { get; set; }
        public List<StudentAssigners> Students { get; set; }
        public string Name { get; set; }
        public Assignment Assignment { get; set; }
        public int AssignmentId { get; set; }
    }
}
