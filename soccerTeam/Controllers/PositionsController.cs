using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using soccerTeam.Data;
using soccerTeam.Models;

namespace soccerTeam.Controllers
{
    public class PositionsController : Controller
    {
        private readonly soccerTeamContext _context;

        public PositionsController(soccerTeamContext context)
        {
            _context = context;
        }

        // GET: Positions
        public async Task<IActionResult> Index()
        {
            return View(await _context.Positions.ToListAsync());
        }

        // GET: Positions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Positions = await _context.Positions
                .FirstOrDefaultAsync(m => m.PositionID == id);
            if (Positions == null)
            {
                return NotFound();
            }

            return View(Positions);
        }

        // GET: Positions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Positions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PositionID,PositionDesc")] Positions Positions)
        {
            if (ModelState.IsValid)
            {
                _context.Add(Positions);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Positions);
        }

        // GET: Positions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Positions = await _context.Positions.FindAsync(id);
            if (Positions == null)
            {
                return NotFound();
            }
            return View(Positions);
        }

        // POST: Positions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PositionID,PositionDesc")] Positions Positions)
        {
            if (id != Positions.PositionID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(Positions);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PositionsExists(Positions.PositionID))
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
            return View(Positions);
        }

        // GET: Positions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Positions = await _context.Positions
                .FirstOrDefaultAsync(m => m.PositionID == id);
            if (Positions == null)
            {
                return NotFound();
            }

            return View(Positions);
        }

        // POST: Positions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var Positions = await _context.Positions.FindAsync(id);
            _context.Positions.Remove(Positions);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PositionsExists(int id)
        {
            return _context.Positions.Any(e => e.PositionID == id);
        }
    }
}
