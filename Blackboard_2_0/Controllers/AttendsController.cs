using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Blackboard_2_0.Models.Data;

namespace Blackboard_2_0.Controllers
{
    public class AttendsController : Controller
    {
        private readonly BbContext _context;

        public AttendsController(BbContext context)
        {
            _context = context;
        }

        // GET: Attends
        public async Task<IActionResult> Index()
        {
            var bbContext = _context.Attends.Include(a => a.Course).Include(a => a.Student);
            return View(await bbContext.ToListAsync());
        }

        // GET: Attends/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var attends = await _context.Attends
                .Include(a => a.Course)
                .Include(a => a.Student)
                .FirstOrDefaultAsync(m => m.StudentId == id);
            if (attends == null)
            {
                return NotFound();
            }

            return View(attends);
        }

        // GET: Attends/Create
        public IActionResult Create()
        {
            ViewData["CourseId"] = new SelectList(_context.Courses, "CourseId", "CourseId");
            ViewData["StudentId"] = new SelectList(_context.Students, "Id", "Id");
            return View();
        }

        // POST: Attends/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StudentId,Status,CourseId")] Attends attends)
        {
            if (ModelState.IsValid)
            {
                attends.Status = "Active";
                _context.Add(attends);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CourseId"] = new SelectList(_context.Courses, "CourseId", "CourseId", attends.CourseId);
            ViewData["StudentId"] = new SelectList(_context.Students, "Id", "Id", attends.StudentId);
            return View(attends);
        }

        // GET: Attends/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var attends = await _context.Attends.FindAsync(id);
            if (attends == null)
            {
                return NotFound();
            }
            ViewData["CourseId"] = new SelectList(_context.Courses, "CourseId", "CourseId", attends.CourseId);
            ViewData["StudentId"] = new SelectList(_context.Students, "Id", "Id", attends.StudentId);
            return View(attends);
        }

        // POST: Attends/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StudentId,Status,CourseId")] Attends attends)
        {
            if (id != attends.StudentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(attends);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AttendsExists(attends.StudentId))
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
            ViewData["CourseId"] = new SelectList(_context.Courses, "CourseId", "CourseId", attends.CourseId);
            ViewData["StudentId"] = new SelectList(_context.Students, "Id", "Id", attends.StudentId);
            return View(attends);
        }

        // GET: Attends/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var attends = await _context.Attends
                .Include(a => a.Course)
                .Include(a => a.Student)
                .FirstOrDefaultAsync(m => m.StudentId == id);
            if (attends == null)
            {
                return NotFound();
            }

            return View(attends);
        }

        // POST: Attends/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var attends = await _context.Attends.FindAsync(id);
            _context.Attends.Remove(attends);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AttendsExists(int id)
        {
            return _context.Attends.Any(e => e.StudentId == id);
        }
    }
}
