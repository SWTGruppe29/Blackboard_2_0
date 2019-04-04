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
            GradeViewModel model = new GradeViewModel();
            HandIn hi = _context.HandIns
                .Where(h => h.AssignersId == handIn.AssignersId & h.AssignmentId == handIn.AssignmentId)
                .Include(h => h.Assignment)
                .First();
            model.AssignmentId = hi.AssignmentId;
            model.GraderSelectList = new SelectList(_context.Teachers.Where(t => t.Teaches.Exists(x => x.CourseId == hi.Assignment.CourseId)),"Id","Id");  
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Grade([Bind("HandIn.GraderId,HandIn.Grade")]GradeViewModel model)
        {
            if (ModelState.IsValid)
            {
                _context.HandIns.Update(model.HandIn);
                return RedirectToAction("ViewHandInsForAssignment", new {id = model.AssignmentId});
            }
            return View(model);
        }
    }
}