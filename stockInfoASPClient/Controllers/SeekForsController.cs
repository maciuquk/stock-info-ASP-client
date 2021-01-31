using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using stockInfoASPClient.Data;
using stockInfoASPClient.Models;

namespace stockInfoASPClient.Controllers
{
    [Authorize]
    public class SeekForsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SeekForsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SeekFors
        public async Task<IActionResult> Index()
        {
            return View(await _context.SeekFor.ToListAsync());
        }

        // GET: SeekFors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SeekFors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Word")] SeekFor seekFor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(seekFor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(seekFor);
        }

        // GET: SeekFors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seekFor = await _context.SeekFor.FindAsync(id);
            if (seekFor == null)
            {
                return NotFound();
            }
            return View(seekFor);
        }

        // POST: SeekFors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Word")] SeekFor seekFor)
        {
            if (id != seekFor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(seekFor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SeekForExists(seekFor.Id))
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
            return View(seekFor);
        }

        // GET: SeekFors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seekFor = await _context.SeekFor
                .FirstOrDefaultAsync(m => m.Id == id);
            if (seekFor == null)
            {
                return NotFound();
            }

            return View(seekFor);
        }

        // POST: SeekFors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var seekFor = await _context.SeekFor.FindAsync(id);
            _context.SeekFor.Remove(seekFor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SeekForExists(int id)
        {
            return _context.SeekFor.Any(e => e.Id == id);
        }
    }
}
