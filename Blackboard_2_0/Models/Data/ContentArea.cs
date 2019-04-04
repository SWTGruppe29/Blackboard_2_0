using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blackboard_2_0.Models.Data
{
    public class ContentArea
    {
        public int ContentAreaId { get; set; }
        public Folder Folder { get; set; }
        public int FolderId { get; set; }
        public CourseContent CourseContent { get; set; }
        public int CourseContentId { get; set; }
        public string TextBlock { get; set; }
        public List<ContentLink> ContentLinks { get; set; }


    }
}
