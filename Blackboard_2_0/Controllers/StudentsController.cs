using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Blackboard_2_0.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Students()
        {
            return View();
        }
    }
}