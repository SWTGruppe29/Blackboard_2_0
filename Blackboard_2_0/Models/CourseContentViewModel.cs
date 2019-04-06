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
            ContentAreas = new List<ContentArea>();
            Folders = new List<Folder>();
            CourseContent = new CourseContent();
            Course = new Course();
            ContentArea = new ContentArea();
            ContentLink = new ContentLink();
            

        }

        public List<ContentArea> ContentAreas { get; set; }
        public ContentArea ContentArea { get; set; }
        public List<Folder> Folders { get; set; }
        public CourseContent CourseContent { get; set; }
        public Course Course { get; set; }
        public ContentLink ContentLink { get; set; }    


    }

}
