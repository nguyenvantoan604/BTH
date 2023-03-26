using BTH19_03.Data;
using BTH19_03.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BTH19_03.Controllers

{
    public class PersionController : Controller{
        private readonly ApplicationDbContext _context;
        public PersionController (ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var model = await _context.Persions.ToListAsync();
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]

        public async Task<IActionResult> Create(Persion std)
        {
            if(ModelState.IsValid)
            {
                _context.Add(std);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(std);
        }

        public async Task<IActionResult> Edit(string id)
        {
            if( id == null)
            {
                return View("NotFound");
            }

            var persion = await _context.Persions.FindAsync(id);
            if(persion == null)
            {
                return View("NotFound");
            }
            return View(persion);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
// Edit
        public async Task<IActionResult> Edit(string id, [Bind("PersionID,PersionName")] Persion std)
        {
            if(id != std.PersionID)
            {
                return View("NotFound");
            }
            if(ModelState.IsValid)
            {
                try
                {
                    _context.Update(std);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if(!PersionExists(std.PersionID))
                    {
                        return View("NotFound");
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(std);
        }
        //Delelte
            public async Task<IActionResult> Delete(string id)
        {
            if(id == null)
            {
                return View("NotFound");
            }

            var std = await _context.Persions.FirstOrDefaultAsync(m => m.PersionID ==id);
            if(std == null)
            {
                return View("NotFound");
            }
            return View(std);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> DeleteConfirmed(string id)
        {

            var std = await _context.Persions.FindAsync(id);
            _context.Persions.Remove(std);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        private bool PersionExists(string id)
        {
            return _context.Persions.Any(e => e.PersionID ==id);
        }


    }
}