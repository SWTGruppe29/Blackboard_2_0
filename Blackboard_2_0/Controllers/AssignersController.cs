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
    public class AssignersController : Controller
    {
        private readonly BbContext _context;

        public AssignersController(BbContext context)
        {
            _context = context;
        }

        // GET: Assigners
        public async Task<IActionResult> Index()
        {
            return View(await _context.Assignerses.ToListAsync());
        }

        // GET: Assigners/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assigners = await _context.Assignerses
                .FirstOrDefaultAsync(m => m.AssignersId == id);
            if (assigners == null)
            {
                return NotFound();
            }

            return View(assigners);
        }

        // GET: Assigners/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Assigners/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AssignersId")] Assigners assigners)
        {
            if (ModelState.IsValid)
            {
                _context.Add(assigners);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(assigners);
        }

        // GET: Assigners/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assigners = await _context.Assignerses.FindAsync(id);
            if (assigners == null)
            {
                return NotFound();
            }
            return View(assigners);
        }

        // POST: Assigners/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AssignersId")] Assigners assigners)
        {
            if (id != assigners.AssignersId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(assigners);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AssignersExists(assigners.AssignersId))
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
            return View(assigners);
        }

        // GET: Assigners/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assigners = await _context.Assignerses
                .FirstOrDefaultAsync(m => m.AssignersId == id);
            if (assigners == null)
            {
                return NotFound();
            }

            return View(assigners);
        }

        // POST: Assigners/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var assigners = await _context.Assignerses.FindAsync(id);
            _context.Assignerses.Remove(assigners);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AssignersExists(int id)
        {
            return _context.Assignerses.Any(e => e.AssignersId == id);
        }
    }
}
