using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blackboard_2_0.Models.Data;

namespace Blackboard_2_0.Models
{
    public class FolderViewModel
    {
        public FolderViewModel()
        {
            Folders = new List<Folder>();
            ContentAreas = new List<ContentArea>();
            ContentLink = new ContentLink();
        }
        public List<Folder> Folders { get; set; }
        public List<ContentArea> ContentAreas { get; set; }

        public int CourseContentId { get; set; }
        public int FolderId { get; set; }
        public string Foldername { get; set; }

        public ContentLink ContentLink { get; set; }

    }
}
