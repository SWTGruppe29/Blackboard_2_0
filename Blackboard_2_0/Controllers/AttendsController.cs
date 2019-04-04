using System;
using System.Collections;
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


        // GET: Attends/Create
        public IActionResult Create(int? id)
        {
            if (id == null)
            {
                ViewData["CourseId"] = new SelectList(_context.Courses, "CourseId", "CourseId");
                ViewData["StudentId"] = new SelectList(_context.Students, "Id", "Id");
                return View();
            }
           
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
                return RedirectToAction("Index","Course",attends.CourseId);
            }

            ViewData["CourseId"] = new SelectList(_context.Courses, "CourseId", "CourseId", attends.CourseId);
            ViewData["StudentId"] = new SelectList(_context.Students, "Id", "Id", attends.StudentId);
            return View(attends);
        }
    }
}
