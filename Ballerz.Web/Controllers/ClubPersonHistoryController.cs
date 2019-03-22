using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ballerz.Football.Ballerz.Data;
using Ballerz.Football.Ballerz.Knowledgebase.Knowledgebase.Data;

namespace Ballerz.Football.Ballerz.Web.Controllers
{
    public class ClubPersonHistoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClubPersonHistoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ClubPersonHistory
        public async Task<IActionResult> Index()
        {
            return View(await _context.ClubPersonHistory.ToListAsync());
        }

        // GET: ClubPersonHistory/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clubPersonHistory = await _context.ClubPersonHistory
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clubPersonHistory == null)
            {
                return NotFound();
            }

            return View(clubPersonHistory);
        }

        // GET: ClubPersonHistory/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ClubPersonHistory/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ClubPersonId,TeamName,Season,LeagueName,RedCards,YellowCards,Goals,Position,Points")] ClubPersonHistory clubPersonHistory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clubPersonHistory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(clubPersonHistory);
        }

        // GET: ClubPersonHistory/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clubPersonHistory = await _context.ClubPersonHistory.FindAsync(id);
            if (clubPersonHistory == null)
            {
                return NotFound();
            }
            return View(clubPersonHistory);
        }

        // POST: ClubPersonHistory/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ClubPersonId,TeamName,Season,LeagueName,RedCards,YellowCards,Goals,Position,Points")] ClubPersonHistory clubPersonHistory)
        {
            if (id != clubPersonHistory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clubPersonHistory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClubPersonHistoryExists(clubPersonHistory.Id))
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
            return View(clubPersonHistory);
        }

        // GET: ClubPersonHistory/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clubPersonHistory = await _context.ClubPersonHistory
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clubPersonHistory == null)
            {
                return NotFound();
            }

            return View(clubPersonHistory);
        }

        // POST: ClubPersonHistory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var clubPersonHistory = await _context.ClubPersonHistory.FindAsync(id);
            _context.ClubPersonHistory.Remove(clubPersonHistory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClubPersonHistoryExists(int id)
        {
            return _context.ClubPersonHistory.Any(e => e.Id == id);
        }
    }
}
