using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blackboard_2_0.Models.Data
{
    public class Teacher
    {
        public int Id { get; set; }
        public AuId AuId { get; set; }
        public string  FirstName { get; set; }
        public string  LastName { get; set; }

        public List<Teaches> Teaches { get; set; }

        public List<HandIn> HandIns { get; set; }



    }
}
