using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentManagement21A6.Data;
using StudentManagement21A6.Models;

namespace StudentManagement21A6.Controllers
{
    public class WojewodztwosController : Controller
    {
        private readonly WyborcaContext _context;

        public WojewodztwosController(WyborcaContext context)
        {
            _context = context;
        }

        // GET: Wojewodztwos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Wojewodztwo.ToListAsync());
        }

        // GET: Wojewodztwos/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Wojewodztwo = await _context.Wojewodztwo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (Wojewodztwo == null)
            {
                return NotFound();
            }

            return View(Wojewodztwo);
        }

        // GET: Wojewodztwos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Wojewodztwos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Description")] Wojewodztwo wojewodztwo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(wojewodztwo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(wojewodztwo);
        }

        // GET: Wojewodztwos/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Wojewodztwo = await _context.Wojewodztwo.FindAsync(id);
            if (Wojewodztwo == null)
            {
                return NotFound();
            }
            return View(Wojewodztwo);
        }

        // POST: Wojewodztwos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Description")] Wojewodztwo wojewodztwo)
        {
            if (id != wojewodztwo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(wojewodztwo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WojewodztwoExists(wojewodztwo.Id))
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
            return View(wojewodztwo);
        }

        // GET: Wojewodztwos/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Wojewodztwo = await _context.Wojewodztwo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (Wojewodztwo == null)
            {
                return NotFound();
            }

            return View(Wojewodztwo);
        }

        // POST: Wojewodztwos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var Wojewodztwo = await _context.Wojewodztwo.FindAsync(id);
            _context.Wojewodztwo.Remove(Wojewodztwo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WojewodztwoExists(string id)
        {
            return _context.Wojewodztwo.Any(e => e.Id == id);
        }
    }
}

