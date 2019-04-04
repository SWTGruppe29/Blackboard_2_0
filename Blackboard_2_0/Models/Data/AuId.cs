using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blackboard_2_0.Models.Data
{
    public class AuId
    {
        public int Id { get; set; }
        public string Role { get; set; }
        public Student Student { get; set; }
        public Teacher Teacher { get; set; }
    }
}
