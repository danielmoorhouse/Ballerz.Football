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
    public class ClubPersonController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClubPersonController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ClubPerson
        public async Task<IActionResult> Index()
        {
            return View(await _context.ClubPeople.ToListAsync());
        }

        // GET: ClubPerson/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clubPerson = await _context.ClubPeople
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clubPerson == null)
            {
                return NotFound();
            }

            return View(clubPerson);
        }

        // GET: ClubPerson/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ClubPerson/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,From,CountryId,ClubId,ClubRoleId")] ClubPerson clubPerson)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clubPerson);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(clubPerson);
        }

        // GET: ClubPerson/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clubPerson = await _context.ClubPeople.FindAsync(id);
            if (clubPerson == null)
            {
                return NotFound();
            }
            return View(clubPerson);
        }

        // POST: ClubPerson/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,From,CountryId,ClubId,ClubRoleId")] ClubPerson clubPerson)
        {
            if (id != clubPerson.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clubPerson);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClubPersonExists(clubPerson.Id))
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
            return View(clubPerson);
        }

        // GET: ClubPerson/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clubPerson = await _context.ClubPeople
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clubPerson == null)
            {
                return NotFound();
            }

            return View(clubPerson);
        }

        // POST: ClubPerson/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var clubPerson = await _context.ClubPeople.FindAsync(id);
            _context.ClubPeople.Remove(clubPerson);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClubPersonExists(int id)
        {
            return _context.ClubPeople.Any(e => e.Id == id);
        }
    }
}
