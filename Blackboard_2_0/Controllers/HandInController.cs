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
                    model.CourseId = assignment.CourseId;
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
        public IActionResult StudentHandIn(int id, [Bind("Text,StudentId,CourseId")] HandInViewModel handIn)
        {
            if (ModelState.IsValid)
            {
                //Create group for student
                Assigners student = new Assigners();
                _context.Assignerses.Add(student);
                _context.SaveChanges();

                // add student to group
                StudentAssigners group = new StudentAssigners();
                group.StudentId = handIn.StudentId;
                group.AssignersId = student.AssignersId;
                _context.StudentAssignerses.Add(group);
                //
                HandIn hi = new HandIn();
                hi.AssignersId = student.AssignersId;
                hi.AssignmentId = id;
                hi.Text = handIn.Text;
                _context.HandIns.Add(hi);
                _context.SaveChanges();
                return RedirectToAction("Details", "Course",new{id = handIn.CourseId});
            }

            return View();
        }

        public IActionResult ViewHandInsForAssignment(int id)
        {
            List<HandIn> handIns = _context.HandIns.Where(h => h.AssignmentId == id).Include(h => h.Assignment).ToList();
            return View(handIns);
        }

        public IActionResult Grade(int AssignersId, int AssignmentId)
        {
            GradeViewModel model = new GradeViewModel();
            HandIn hi = _context.HandIns.Where(x => x.AssignersId == AssignersId & x.AssignmentId == AssignmentId).Include(x => x.Assignment).FirstOrDefault();
            if (hi != null)
            {
                model.HandIn = hi;
                model.GraderSelectList = new SelectList(_context.Teachers.Where(t => t.Teaches.Exists(x => x.CourseId == hi.Assignment.CourseId)), "Id", "Id");
                return View(model);
            }

            return NotFound();
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Grade(int AssignersId, int AssignmentId, [Bind("GraderId,Grade,AssignersId,AssignmentId,Text", nameof(GradeViewModel.HandIn))] GradeViewModel model)
        {
            if (ModelState.IsValid)
            {
                _context.Update(model.HandIn);
                _context.SaveChanges();
                return RedirectToAction("ViewHandInsForAssignment", new {id = model.HandIn.AssignmentId});
            }
            return View(model);
        }


        public IActionResult GroupHandIn(int id)
        {
            //var groups=_context.Assignerses.Where(c=>c.)

            return View();
        }

        public IActionResult CreateGroup(int id)
        {
            Assigners group = new Assigners();
            //group.Name
            _context.Assignerses.Add(group);
            _context.SaveChanges();
            return RedirectToAction("GroupHandIn", id);
        }


    }
}