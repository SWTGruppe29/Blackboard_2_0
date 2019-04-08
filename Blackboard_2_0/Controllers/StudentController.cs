using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blackboard_2_0.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Blackboard_2_0.Models.Data;
using Microsoft.EntityFrameworkCore.Query;

namespace Blackboard_2_0.Controllers
{
    public class StudentController : Controller
    {
        private readonly BbContext _context;

        public StudentController(BbContext context)
        {
            _context = context;
        }

        // GET: Student
        public async Task<IActionResult> Index()
        {
            return View(await _context.Students.ToListAsync());
        }

        // GET: Student/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var groups = _context.StudentAssignerses.Where(s => s.StudentId == id).ToList();

            var grades = new List<IIncludableQueryable<HandIn, Course>>();

            foreach (var group in groups)
            {
                grades.Add(_context.HandIns.Where(g=>g.AssignersId==group.AssignersId).Include(x=>x.Assignment).Include(x=>x.Assignment.Course));
            }

            var viewModel = new StudentDetailsViewModel()
            {
                Student = await _context.Students.FirstOrDefaultAsync(m => m.Id == id),
                Attends = _context.Attends.Where(s => s.StudentId == id).Include(c=>c.Course).ToList(),
                Grades = grades
            };
           

            if (viewModel.Student.Id!=id)
            {
                return NotFound();
            }

            return View(viewModel);
        }

        // GET: Student/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName")] Student student)
        {
            if (ModelState.IsValid)
            {
                var newStudent = new AuId()
                {
                    Role = "Student"
                };
                _context.Add(newStudent);

                student.Id = newStudent.Id;
                _context.Add(student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: Student/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Students.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // POST: Student/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName")] Student student)
        {
            if (id != student.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(student);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(student.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: Student/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .FirstOrDefaultAsync(m => m.Id == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // POST: Student/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var student = await _context.Students.FindAsync(id);
            var auId = await _context.AuIds.FindAsync(id);
            _context.Students.Remove(student);
            _context.AuIds.Remove(auId);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentExists(int id)
        {
            return _context.Students.Any(e => e.Id == id);
        }

        public async Task<IActionResult> CoursesList(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = _context.Attends.Where(s => s.StudentId == id).Include(c => c.Course).ToList();

            return View(student);
        }
    }
}
