using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blackboard_2_0.Models.Data
{
    public class Student
    {
        public int Id { get; set; }
        public AuId AuId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public List<Attends> Attends { get; set; }

        public List<StudentAssigners> Assigners { get; set; }


    }
}
