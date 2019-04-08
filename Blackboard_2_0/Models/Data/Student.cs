using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Blackboard_2_0.Models.Data
{
    public class Student
    {
        [ForeignKey("AuId")]
        [Key]
        [Display(Name = "AU ID")]
        public int Id { get; set; }
        public AuId AuId { get; set; }
        [Display(Name="First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime EnrolledDate { get; set; }
        public DateTime GraduationDate { get; set; }
        public List<Attends> Attends { get; set; }
        public List<StudentAssigners> Assigners { get; set; }
    }
}
