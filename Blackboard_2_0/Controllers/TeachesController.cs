﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blackboard_2_0.Models.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Blackboard_2_0.Controllers
{
    public class TeachesController : Controller
    {
        private readonly BbContext _context;


        public TeachesController(BbContext context)
        {
            _context = context;
        }

        // GET: Attends/Create
        public IActionResult Create(int? id)
        {
            if (id == null)
            {
                ViewData["CourseId"] = new SelectList(_context.Courses, "CourseId", "CourseId");
                ViewData["AuId"] = new SelectList(_context.Teachers, "Id", "Id");
                return View();
            }

            ViewData["CourseId"] = new SelectList(_context.Courses, "CourseId", "CourseId");
            ViewData["AuId"] = new SelectList(_context.Teachers, "Id", "Id");
            return View();
        }

        // POST: Attends/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AuId,Role,CourseId")] Teaches teaches)
        {
            if (ModelState.IsValid)
            {
                _context.Add(teaches);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Course", teaches.CourseId);
            }

            ViewData["CourseId"] = new SelectList(_context.Courses, "CourseId", "CourseId", teaches.CourseId);
            ViewData["AuId"] = new SelectList(_context.Teachers, "Id", "Id", teaches.AuId);
            return View(teaches);
        }
    }
}