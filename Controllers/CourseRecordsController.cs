using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EductionFinalProject.Data;
using EductionFinalProject.Models;

namespace EductionFinalProject.Controllers
{
    public class CourseRecordsController : Controller
    {
        private readonly EductionFinalProjectContext _context;

        public CourseRecordsController(EductionFinalProjectContext context)
        {
            _context = context;
        }

        // GET: CourseRecords
        public async Task<IActionResult> Index()
        {
            return View(await _context.CourseRecord.ToListAsync());
        }
        public async Task<IActionResult> CoursesList()
        {
            return View(await _context.CourseRecord.ToListAsync());
        }


        // GET: CourseRecords/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseRecord = await _context.CourseRecord
                .FirstOrDefaultAsync(m => m.id == id);
            if (courseRecord == null)
            {
                return NotFound();
            }

            return View(courseRecord);
        }

        // GET: CourseRecords/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CourseRecords/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Product,Duration,Fee")] CourseRecord courseRecord)
        {
            if (ModelState.IsValid)
            {
                _context.Add(courseRecord);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(courseRecord);
        }

        // GET: CourseRecords/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseRecord = await _context.CourseRecord.FindAsync(id);
            if (courseRecord == null)
            {
                return NotFound();
            }
            return View(courseRecord);
        }

        // POST: CourseRecords/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Product,Duration,Fee")] CourseRecord courseRecord)
        {
            if (id != courseRecord.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(courseRecord);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseRecordExists(courseRecord.id))
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
            return View(courseRecord);
        }

        // GET: CourseRecords/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var courseRecord = await _context.CourseRecord
                .FirstOrDefaultAsync(m => m.id == id);
            if (courseRecord == null)
            {
                return NotFound();
            }

            return View(courseRecord);
        }

        // POST: CourseRecords/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var courseRecord = await _context.CourseRecord.FindAsync(id);
            _context.CourseRecord.Remove(courseRecord);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CourseRecordExists(int id)
        {
            return _context.CourseRecord.Any(e => e.id == id);
        }
    }
}
