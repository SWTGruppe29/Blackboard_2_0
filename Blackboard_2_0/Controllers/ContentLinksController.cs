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
    public class ContentLinksController : Controller
    {
        private readonly BbContext _context;

        public ContentLinksController(BbContext context)
        {
            _context = context;
        }

        // GET: ContentLinks
        public async Task<IActionResult> Index()
        {
            var bbContext = _context.ContentLinks.Include(c => c.ContentArea);
            return View(await bbContext.ToListAsync());
        }

        // GET: ContentLinks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contentLink = await _context.ContentLinks
                .Include(c => c.ContentArea)
                .FirstOrDefaultAsync(m => m.ContentLinkId == id);
            if (contentLink == null)
            {
                return NotFound();
            }

            return View(contentLink);
        }

        // GET: ContentLinks/Create
        public IActionResult Create(int id)
        {
            ViewData["ContentAreaId"] = new SelectList(_context.ContentAreas, "ContentAreaId", "ContentAreaId");
            return View();
        }

        // POST: ContentLinks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int pageId, int id, [Bind("ContentLinkId,ContentAreaId,Type,ContentUri")] ContentLink contentLink)
        {
            if (ModelState.IsValid)
            {
                contentLink.ContentAreaId = id;
                _context.Add(contentLink);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "CourseContents", new { id = pageId });
            }
            ViewData["ContentAreaId"] = new SelectList(_context.ContentAreas, "ContentAreaId", "ContentAreaId", contentLink.ContentAreaId);
            return View(contentLink);
        }

        // GET: ContentLinks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contentLink = await _context.ContentLinks.FindAsync(id);
            if (contentLink == null)
            {
                return NotFound();
            }
            ViewData["ContentAreaId"] = new SelectList(_context.ContentAreas, "ContentAreaId", "ContentAreaId", contentLink.ContentAreaId);
            return View(contentLink);
        }

        // POST: ContentLinks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ContentLinkId,ContentAreaId,Type,ContentUri")] ContentLink contentLink)
        {
            if (id != contentLink.ContentLinkId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contentLink);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContentLinkExists(contentLink.ContentLinkId))
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
            ViewData["ContentAreaId"] = new SelectList(_context.ContentAreas, "ContentAreaId", "ContentAreaId", contentLink.ContentAreaId);
            return View(contentLink);
        }

        // GET: ContentLinks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contentLink = await _context.ContentLinks
                .Include(c => c.ContentArea)
                .FirstOrDefaultAsync(m => m.ContentLinkId == id);
            if (contentLink == null)
            {
                return NotFound();
            }

            return View(contentLink);
        }

        // POST: ContentLinks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contentLink = await _context.ContentLinks.FindAsync(id);
            _context.ContentLinks.Remove(contentLink);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContentLinkExists(int id)
        {
            return _context.ContentLinks.Any(e => e.ContentLinkId == id);
        }
    }
}
