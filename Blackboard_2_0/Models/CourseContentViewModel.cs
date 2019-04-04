using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blackboard_2_0.Models.Data;

namespace Blackboard_2_0.Models
{
    public class CourseContentViewModel
    {
        public CourseContentViewModel()
        {
            Course=new Course();
        }

        public Course Course { get; set; }
        public List<Folder> Folders { get; set; }
        public List<ContentArea> ContentAreas { get; set; }
    }
}
