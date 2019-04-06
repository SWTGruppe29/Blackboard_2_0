using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Blackboard_2_0.Models.Data
{
    public class Teacher
    {
        [ForeignKey("AuId")]
        [Key]
        [Display(Name = "AU ID")]
        public int Id { get; set; }
        [Display(Name = "AU ID")]
        public AuId AuId { get; set; }
        [Display(Name = "First Name")]
        public string  FirstName { get; set; }
        [Display(Name="Last Name")]
        public string  LastName { get; set; }
        public DateTime Birthday { get; set; }

        public List<Teaches> Teaches { get; set; }

        public List<HandIn> HandIns { get; set; }



    }
}
