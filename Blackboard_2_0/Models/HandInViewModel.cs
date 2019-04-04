using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Blackboard_2_0.Models.Data
{
    public class HandInViewModel
    {
        public SelectList Students { get; set; }
        public SelectList Assignerses { get; set; }
        public HandIn HandIn { get; set; }
        

        public int  Id { get; set; }

        public string Text { get; set; }

        public bool IsSolo { get; set; } = false;

        public HandInViewModel()
        {
            Students = new SelectList(new List<Student>());
            Assignerses = new SelectList(new List<Assigners>());
            HandIn = new HandIn();
        }

    }
}
