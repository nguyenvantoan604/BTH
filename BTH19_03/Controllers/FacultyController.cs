using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BTH19_03.Data;
using BTH19_03.Models;

namespace BTH19_03.Controllers
{
    public class FacultyController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FacultyController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Faculty
        public async Task<IActionResult> Index()
        {
              return _context.Facultys != null ? 
                          View(await _context.Facultys.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Facultys'  is null.");
        }

        // GET: Faculty/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Facultys == null)
            {
                return NotFound();
            }

            var faculty = await _context.Facultys
                .FirstOrDefaultAsync(m => m.FacultyID == id);
            if (faculty == null)
            {
                return NotFound();
            }

            return View(faculty);
        }

        // GET: Faculty/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Faculty/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FacultyID,FacultyName")] Faculty faculty)
        {
            if (ModelState.IsValid)
            {
                _context.Add(faculty);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(faculty);
        }

        // GET: Faculty/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Facultys == null)
            {
                return NotFound();
            }

            var faculty = await _context.Facultys.FindAsync(id);
            if (faculty == null)
            {
                return NotFound();
            }
            return View(faculty);
        }

        // POST: Faculty/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("FacultyID,FacultyName")] Faculty faculty)
        {
            if (id != faculty.FacultyID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(faculty);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FacultyExists(faculty.FacultyID))
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
            return View(faculty);
        }

        // GET: Faculty/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Facultys == null)
            {
                return NotFound();
            }

            var faculty = await _context.Facultys
                .FirstOrDefaultAsync(m => m.FacultyID == id);
            if (faculty == null)
            {
                return NotFound();
            }

            return View(faculty);
        }

        // POST: Faculty/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Facultys == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Facultys'  is null.");
            }
            var faculty = await _context.Facultys.FindAsync(id);
            if (faculty != null)
            {
                _context.Facultys.Remove(faculty);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FacultyExists(string id)
        {
          return (_context.Facultys?.Any(e => e.FacultyID == id)).GetValueOrDefault();
        }
    }
}
