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
    public class CompetitionsController : Controller
    {
        private readonly soccerTeamContext _context;

        public CompetitionsController(soccerTeamContext context)
        {
            _context = context;
        }

        // GET: Competitions
        public async Task<IActionResult> Index()
        {
            return View(await _context.Competitions.ToListAsync());
        }

        // GET: Competitions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Competitions = await _context.Competitions
                .FirstOrDefaultAsync(m => m.CompetitionID == id);
            if (Competitions == null)
            {
                return NotFound();
            }

            return View(Competitions);
        }

        // GET: Competitions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Competitions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompetitionID,CompetitionName")] Competitions Competitions)
        {
            if (ModelState.IsValid)
            {
                _context.Add(Competitions);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Competitions);
        }

        // GET: Competitions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Competitions = await _context.Competitions.FindAsync(id);
            if (Competitions == null)
            {
                return NotFound();
            }
            return View(Competitions);
        }

        // POST: Competitions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CompetitionID,CompetitionName")] Competitions Competitions)
        {
            if (id != Competitions.CompetitionID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(Competitions);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompetitionsExists(Competitions.CompetitionID))
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
            return View(Competitions);
        }

        // GET: Competitions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Competitions = await _context.Competitions
                .FirstOrDefaultAsync(m => m.CompetitionID == id);
            if (Competitions == null)
            {
                return NotFound();
            }

            return View(Competitions);
        }

        // POST: Competitions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var Competitions = await _context.Competitions.FindAsync(id);
            _context.Competitions.Remove(Competitions);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompetitionsExists(int id)
        {
            return _context.Competitions.Any(e => e.CompetitionID == id);
        }
    }
}
