using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blackboard_2_0.Models.Data
{
    public class ContentLink
    {
        public int ContentLinkId { get; set; }
        public ContentArea ContentArea { get; set; }
        public int ContentAreaId { get; set; }
        public string Type { get; set; }
        public string ContentUri { get; set; }

    }
}
