using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Blackboard_2_0.Models.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Blackboard_2_0.Controllers
{
    public class HandInController : Controller
    {
        private readonly BbContext _context;

        public HandInController(BbContext context)
        {
            _context = context;
        }

        public IActionResult StudentHandIn(int id)
        {
            HandInViewModel model = new HandInViewModel();
            Assignment assignment = _context.Assignments.Find(id);

            if (assignment != null)
            {
                if (assignment.MaxAssigners == 1)
                {
                    model.IsSolo = true;
                    model.Id = assignment.CourseId;
                    model.Students = new SelectList(_context.Students.Where(s => s.Attends.Exists(x => x.CourseId == assignment.CourseId)), "Id", "Id");
                    model.Assignerses = null;
                    return View(model);
                }
                else
                {
                    //THOMAS...
                }
                
            }

            return NotFound();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult StudentHandIn(int id, [Bind("Text,Id")] HandInViewModel handIn)
        {
            if (ModelState.IsValid)
            {
                //Create group for student
                Assigners student = new Assigners();
                _context.Assignerses.Add(student);
                _context.SaveChanges();

                HandIn hi = new HandIn();
                hi.AssignersId = student.AssignersId;
                hi.AssignmentId = id;
                hi.Text = handIn.Text;
                _context.HandIns.Add(hi);
                _context.SaveChanges();
                return RedirectToAction("Details", "Course",new{id = handIn.Id});
            }

            return View();
        }

        public IActionResult ViewHandInsForAssignment(int id)
        {
            List<HandIn> handIns = _context.HandIns.Where(h => h.AssignmentId == id).Include(h => h.Assignment).ToList();
            return View(handIns);
        }

        public IActionResult Grade(HandIn handIn)
        {
            return View();
        }
    }
}