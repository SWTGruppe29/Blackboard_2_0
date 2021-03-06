﻿using System;
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
    public class FoldersController : Controller
    {
        private readonly BbContext _context;

        public FoldersController(BbContext context)
        {
            _context = context;
        }

        // GET: Folders
        public async Task<IActionResult> Index()
        {
            var bbContext = _context.Folders.Include(f => f.CourseContent);
            return View(await bbContext.ToListAsync());
        }

        // GET: Folders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Folder folder = _context.Folders.Find((int)id);
            if (folder == null)
            {
                return NotFound();
            }
            FolderViewModel model = new FolderViewModel();
            model.Folders = await _context.Folders.Where(f => f.CourseContentId == folder.CourseContentId).ToListAsync();
            model.ContentAreas = await _context.ContentAreas.Where(c => c.CourseContentId == folder.CourseContentId && c.FolderId == folder.FolderId).Include(c => c.ContentLinks).ToListAsync();
            model.CourseContentId = folder.CourseContentId;
            model.FolderId = folder.FolderId;
            model.Foldername = folder.FolderName;


            return View(model);
        }

        // GET: Folders/Create
        public IActionResult Create(int id)
        {
            ViewData["CourseContentId"] = new SelectList(_context.CourseContents, "CourseContentId", "CourseContentId");
            return View();
        }

        // POST: Folders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int id, [Bind("FolderId,FolderName,CourseContentId")] Folder folder)
        {
            if (ModelState.IsValid)
            {
                folder.CourseContentId = id;
                _context.Add(folder);
                await _context.SaveChangesAsync();

                return RedirectToAction("Details", "CourseContents",new {id = folder.CourseContentId});
            }
            ViewData["CourseContentId"] = new SelectList(_context.CourseContents, "CourseContentId", "CourseContentId", folder.CourseContentId);
            return View(folder);
        }

        // GET: Folders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var folder = await _context.Folders.FindAsync(id);
            if (folder == null)
            {
                return NotFound();
            }
            ViewData["CourseContentId"] = new SelectList(_context.CourseContents, "CourseContentId", "CourseContentId", folder.CourseContentId);
            return View(folder);
        }

        // POST: Folders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FolderId,FolderName,CourseContentId")] Folder folder)
        {
            if (id != folder.FolderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(folder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FolderExists(folder.FolderId))
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
            ViewData["CourseContentId"] = new SelectList(_context.CourseContents, "CourseContentId", "CourseContentId", folder.CourseContentId);
            return View(folder);
        }

        // GET: Folders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var folder = await _context.Folders
                .Include(f => f.CourseContent)
                .FirstOrDefaultAsync(m => m.FolderId == id);
            if (folder == null)
            {
                return NotFound();
            }

            return View(folder);
        }

        // POST: Folders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var folder = await _context.Folders.FindAsync(id);
            _context.Folders.Remove(folder);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FolderExists(int id)
        {
            return _context.Folders.Any(e => e.FolderId == id);
        }
    }
}
