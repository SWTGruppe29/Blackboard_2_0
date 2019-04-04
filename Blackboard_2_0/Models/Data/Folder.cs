using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blackboard_2_0.Models.Data
{
    public class Folder
    {
        public int FolderId { get; set; }
        public string FolderName { get; set; }
        public int CourseContentId { get; set; }
        public CourseContent CourseContent { get; set; }
        public List<ContentArea> ContentAreas { get; set; }
    }
}
