using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blackboard_2_0.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Blackboard_2_0.Models.Data;

namespace Blackboard_2_0.Controllers
{
    public class CourseContentsController : Controller
    {
        private readonly BbContext _context;

        public CourseContentsController(BbContext context)
        {
            _context = context;
        }

        // GET: CourseContents
        public async Task<IActionResult> Index()
        {
            var bbContext = _context.CourseContents.Include(c => c.Course);
            return View(await bbContext.ToListAsync());
        }

        // GET: CourseContents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CourseContentViewModel model = new CourseContentViewModel();
            model.ContentAreas = _context.ContentAreas.Where(a => a.CourseContentId == id).Include(s => s.ContentLinks)
                .ToList();
            model.Folders = _context.Folders.Where(a => a.CourseContentId == id).Include(s => s.ContentAreas).ToList();

            model.CourseContent = await _context.CourseContents
                .Include(c => c.Course)
                .FirstOrDefaultAsync(m => m.CourseContentId == id);



            var courseContent = await _context.CourseContents
                .Include(c => c.Course)
                .FirstOrDefaultAsync(m => m.CourseContentId == id);

            if (courseContent == null)
            {
                return NotFound();
            }

            ViewData["ContentAreaId"] = new SelectList(_context.CourseContents, "CourseContentId", "CourseContentId", model.ContentArea.ContentAreaId);
            ViewData["FolderId"] = new SelectList(_context.Folders, "FolderId", "FolderId", model.ContentArea.FolderId);

            return View(model);
        }

        // GET: CourseContents/Create
        public IActionResult Create(int id)
        {
            ViewData["CourseId"] = new SelectList(_context.Courses, "CourseId", "CourseId");
            return View();
        }

        // POST: CourseContents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int id, [Bind("CourseContentId,Name,CourseId")] CourseContent courseContent)
        {
            if (ModelState.IsValid)
            {
                courseContent.CourseId = id;
                _context.Add(courseContent);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "Course", new { id = courseContent.CourseId});
            }
            ViewData["CourseId"] = new SelectList(_context.Courses, "CourseId", "CourseId", courseContent.CourseId);
            return View(courseContent);
        }

        // GET: CourseContents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseContent = await _context.CourseContents.FindAsync(id);
            if (courseContent == null)
            {
                return NotFound();
            }
            ViewData["CourseId"] = new SelectList(_context.Courses, "CourseId", "CourseId", courseContent.CourseId);
            return View(courseContent);
        }

        // POST: CourseContents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CourseContentId,Name,CourseId")] CourseContent courseContent)
        {
            if (id != courseContent.CourseContentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(courseContent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseContentExists(courseContent.CourseContentId))
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
            ViewData["CourseId"] = new SelectList(_context.Courses, "CourseId", "CourseId", courseContent.CourseId);
            return View(courseContent);
        }

        // GET: CourseContents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseContent = await _context.CourseContents
                .Include(c => c.Course)
                .FirstOrDefaultAsync(m => m.CourseContentId == id);
            if (courseContent == null)
            {
                return NotFound();
            }

            return View(courseContent);
        }

        // POST: CourseContents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var courseContent = await _context.CourseContents.FindAsync(id);
            _context.CourseContents.Remove(courseContent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CourseContentExists(int id)
        {
            return _context.CourseContents.Any(e => e.CourseContentId == id);
        }
    }
}
