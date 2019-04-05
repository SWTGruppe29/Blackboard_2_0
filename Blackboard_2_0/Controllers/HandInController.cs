using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Threading.Tasks;
using Blackboard_2_0.Models;
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

        public IActionResult HandIn(int id)
        {
            HandInViewModel model = new HandInViewModel();
            Assignment assignment = _context.Assignments.Find(id);

            if (assignment != null)
            {
                if (assignment.MaxAssigners == 1)
                {
                    model.IsSolo = true;
                    model.CourseId = assignment.CourseId;

                    var students = _context.Students.Where(s => s.Attends.Exists(x => x.CourseId == assignment.CourseId)).ToList();
                    var studentsHandin = _context.Assignerses.Where(a => a.AssignmentId == id)
                        .Include(s => s.Students).ToList();

                    foreach (var group in studentsHandin)
                    {
                        foreach (var student in group.Students)
                        {
                            students.Remove(student.Student);
                        }
                    }

                    IEnumerable<SelectListItem> selectList = from s in students
                        select new SelectListItem
                        {
                            Value = s.Id.ToString(),
                            Text = s.FirstName + " " + s.LastName
                        };

                    model.Students = new SelectList(selectList, "Value", "Text");
                    model.Assignerses = null;
                    return View(model);
                }
                else
                {
                    model.IsSolo = false;
                    model.CourseId = assignment.CourseId;
                    model.Students = null;
                    var groups = _context.Assignerses.Where(a => a.AssignmentId == id).Include(x => x.Students)
                        .ToList();
                    for (int i = 0; i < groups.Count; )
                    {
                        if (groups[i].Students.Count<=0)
                        {
                            groups.Remove(groups[i]);
                        }
                        else
                        {
                            i++;
                        }
                    }

                    var groupHandins = _context.HandIns.Where(a => a.AssignmentId == id).Include(x => x.Assigners)
                        .ToList();

                    foreach (var handin in groupHandins)
                    {
                        groups.Remove(handin.Assigners);
                    }


                    model.Assignerses = new SelectList(groups,
                        "AssignersId", "Name");
                    return View(model);
                }
                
            }

            return NotFound();

        }

        [ValidateAntiForgeryToken]
        public IActionResult StudentHandIn(int id, [Bind("Text,StudentId,CourseId")] HandInViewModel handIn)
        {
            if (ModelState.IsValid)
            {
                //Create group for student
                Assigners student = new Assigners();
                student.AssignmentId = id;
                var studentInDb = _context.Students.First(x => x.Id == Convert.ToInt16(handIn.StudentId));
                student.Name = studentInDb.FirstName + " " + studentInDb.LastName;
                _context.Assignerses.Add(student);
                _context.SaveChanges();

                // add student to group
                StudentAssigners group = new StudentAssigners();
                group.StudentId = Convert.ToInt16(handIn.StudentId);
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

            return RedirectToAction("HandIn", new { id });
        }

        public IActionResult ViewHandInsForAssignment(int id)
        {
            List<HandIn> handIns = _context.HandIns.Where(h => h.AssignmentId == id)
                .Include(x => x.Assignment)
                .Include(x => x.Assigners)
                .Include(x=>x.Grader).ToList();
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


        public IActionResult GroupOverview(int id)
        {
            var viewModel = new GroupHandinViewModel()
            {
                Assigners = _context.Assignerses.Where(a => a.AssignmentId == id).Include(s=>s.Students).Include(s=>s.Assignment).ToList(),
                AssignmentId = id,
                MaxAssigners = _context.Assignments.Find(id).MaxAssigners
            };

            return View(viewModel);
        }

        public IActionResult CreateGroup(int id)
        {
            Assigners group = new Assigners();
            var numOfGroups = _context.Assignerses.Count(a => a.AssignmentId == id);
            group.Name = "Group " + (numOfGroups + 1).ToString();
            group.AssignmentId = id;
            _context.Assignerses.Add(group);
            _context.SaveChanges();
            return RedirectToAction("GroupOverview", new {id});
        }


        public IActionResult AddStudentToGroup(int courseId, int assignersId, int assignmentId)
        {
            var students = _context.Students.Where(s => s.Attends.Exists(x => x.CourseId == courseId)).ToList();
            var studentsInGroups = _context.Assignerses.Where(a => a.AssignmentId == assignmentId)
                .Include(s => s.Students).ToList();

            foreach (var group in studentsInGroups)
            {
                foreach (var student in group.Students)
                {
                    students.Remove(student.Student);
                }
            }



            IEnumerable<SelectListItem> selectList = from s in students
                select new SelectListItem
                {
                    Value = s.Id.ToString(),
                    Text = s.FirstName + " " + s.LastName
                };

            var viewModel = new AddStudentToGroupViewModel
            {
                Attends = new SelectList(selectList, "Value", "Text"),
                AssignersId = assignersId,
                AssignmentId = assignmentId
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddStudentToGroup(AddStudentToGroupViewModel newStudent)
        {
            if (ModelState.IsValid)
            {
                if (_context.Assignerses.Count(a => a.AssignersId == newStudent.AssignersId) <
                    _context.Assignments.Find(newStudent.AssignmentId).MaxAssigners)
                {
                    StudentAssigners group = new StudentAssigners();
                    group.StudentId = Convert.ToInt16(newStudent.StudentId);
                    group.AssignersId = newStudent.AssignersId;
                    _context.StudentAssignerses.Add(group);

                    _context.SaveChanges();

                    return RedirectToAction("GroupOverview", "HandIn", new {id = newStudent.AssignmentId});
                }

                return View();
            }

            return View();
        }

        public IActionResult GroupPage(int id)
        {
            var groupMembers = _context.StudentAssignerses.Where(a => a.AssignersId == id).Include(s => s.Student).Include(x=>x.Assigners).ToList();

            return View(groupMembers);
        }

        public IActionResult GroupHandIn(int id, [Bind("Text,AssignersId,CourseId")] HandInViewModel handIn)
        {
            if(ModelState.IsValid)
            {
                HandIn hi = new HandIn();
                hi.AssignersId = handIn.AssignersId;
                hi.AssignmentId = id;
                hi.Text = handIn.Text;
                _context.HandIns.Add(hi);
                _context.SaveChanges();

                return RedirectToAction("Details", "Course", new { id = handIn.CourseId });
            }

            return RedirectToAction("HandIn", new{id});
        }
    }
}