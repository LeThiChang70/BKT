using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LTC1070.Models;

namespace LTC1070.Controllers
{
    public class LTC070sController : Controller
    {
        private readonly MvcMovieContext _context;

        public LTC070sController(MvcMovieContext context)
        {
            _context = context;
        }

        // GET: LTC070s
        public async Task<IActionResult> Index()
        {
            return View(await _context.LTC070.ToListAsync());
        }

        // GET: LTC070s/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lTC070 = await _context.LTC070
                .FirstOrDefaultAsync(m => m.LTCId == id);
            if (lTC070 == null)
            {
                return NotFound();
            }

            return View(lTC070);
        }

        // GET: LTC070s/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LTC070s/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LTCId,LTCName")] LTC070 lTC070)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lTC070);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lTC070);
        }

        // GET: LTC070s/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lTC070 = await _context.LTC070.FindAsync(id);
            if (lTC070 == null)
            {
                return NotFound();
            }
            return View(lTC070);
        }

        // POST: LTC070s/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("LTCId,LTCName")] LTC070 lTC070)
        {
            if (id != lTC070.LTCId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lTC070);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LTC070Exists(lTC070.LTCId))
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
            return View(lTC070);
        }

        // GET: LTC070s/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lTC070 = await _context.LTC070
                .FirstOrDefaultAsync(m => m.LTCId == id);
            if (lTC070 == null)
            {
                return NotFound();
            }

            return View(lTC070);
        }

        // POST: LTC070s/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var lTC070 = await _context.LTC070.FindAsync(id);
            _context.LTC070.Remove(lTC070);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LTC070Exists(string id)
        {
            return _context.LTC070.Any(e => e.LTCId == id);
        }
    }
}
