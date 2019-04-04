using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blackboard_2_0.Models.Data
{
    public class CourseContent
    {
        public int CourseContentId { get; set; }
        public string Name { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public List<ContentArea> ContentAreas { get; set; }
        public List<Folder> Folders { get; set; }

    }
}
