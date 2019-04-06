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
    public class ContentAreasController : Controller
    {
        private readonly BbContext _context;

        public ContentAreasController(BbContext context)
        {
            _context = context;
        }

        // GET: ContentAreas
        public async Task<IActionResult> Index()
        {
            var bbContext = _context.ContentAreas.Include(c => c.CourseContent).Include(c => c.Folder);
            return View(await bbContext.ToListAsync());
        }

        // GET: ContentAreas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contentArea = await _context.ContentAreas
                .Include(c => c.CourseContent)
                .Include(c => c.Folder)
                .FirstOrDefaultAsync(m => m.ContentAreaId == id);
            if (contentArea == null)
            {
                return NotFound();
            }

            return View(contentArea);
        }

        // GET: ContentAreas/Create
        public IActionResult Create(int folderId, int id)
        {
            if (folderId < 0)
            {
                ViewData["Check"] = false;
                ViewData["FolderId"] = new SelectList(_context.Folders, "FolderId", "FolderId");
            }
            else
            {
                ViewData["Check"] = true;
            }
            

            return View();
        }

        // POST: ContentAreas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int folderId, int id,[Bind("FolderId,TextBlock")] ContentArea contentArea)
        {
            if (folderId > 0)
            {
                contentArea.FolderId = folderId;
            }

            if (ModelState.IsValid)
            {
                contentArea.CourseContentId = id;
                _context.Add(contentArea);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details","CourseContents",new{id = id});
            }

            ViewData["ContentAreaId"] = new SelectList(_context.CourseContents, "CourseContentId", "CourseContentId", contentArea.ContentAreaId);
            ViewData["FolderId"] = new SelectList(_context.Folders, "FolderId", "FolderId", contentArea.FolderId);
            return View(contentArea);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateFolder(int id, int FolderId, [Bind("FolderId,TextBlock")] ContentArea contentArea)
        {
            if (ModelState.IsValid)
            {
                contentArea.FolderId = id;
                contentArea.CourseContentId = id;
                _context.Add(contentArea);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details","CourseContents",new{id = id});
            }

            return View(contentArea);
        }


        // GET: ContentAreas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contentArea = await _context.ContentAreas.FindAsync(id);
            if (contentArea == null)
            {
                return NotFound();
            }
            ViewData["ContentAreaId"] = new SelectList(_context.CourseContents, "CourseContentId", "CourseContentId", contentArea.ContentAreaId);
            ViewData["FolderId"] = new SelectList(_context.Folders, "FolderId", "FolderId", contentArea.FolderId);
            return View(contentArea);
        }

        // POST: ContentAreas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ContentAreaId,FolderId,CourseContentId,TextBlock")] ContentArea contentArea)
        {
            if (id != contentArea.ContentAreaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contentArea);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContentAreaExists(contentArea.ContentAreaId))
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
            ViewData["ContentAreaId"] = new SelectList(_context.CourseContents, "CourseContentId", "CourseContentId", contentArea.ContentAreaId);
            ViewData["FolderId"] = new SelectList(_context.Folders, "FolderId", "FolderId", contentArea.FolderId);
            return View(contentArea);
        }

        // GET: ContentAreas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contentArea = await _context.ContentAreas
                .Include(c => c.CourseContent)
                .Include(c => c.Folder)
                .FirstOrDefaultAsync(m => m.ContentAreaId == id);
            if (contentArea == null)
            {
                return NotFound();
            }

            return View(contentArea);
        }

        // POST: ContentAreas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contentArea = await _context.ContentAreas.FindAsync(id);
            _context.ContentAreas.Remove(contentArea);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContentAreaExists(int id)
        {
            return _context.ContentAreas.Any(e => e.ContentAreaId == id);
        }
    }
}
