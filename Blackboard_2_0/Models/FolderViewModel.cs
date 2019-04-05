using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blackboard_2_0.Models.Data;

namespace Blackboard_2_0.Models
{
    public class FolderViewModel
    {
        public List<Folder> Folders { get; set; }
        public List<ContentArea> ContentAreas { get; set; }

        public int CourseContentId { get; set; }

    }
}
