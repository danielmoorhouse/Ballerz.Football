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
    public class ClubRoleController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClubRoleController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ClubRole
        public async Task<IActionResult> Index()
        {
            return View(await _context.ClubRoles.ToListAsync());
        }

        // GET: ClubRole/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clubRole = await _context.ClubRoles
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clubRole == null)
            {
                return NotFound();
            }

            return View(clubRole);
        }

        // GET: ClubRole/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ClubRole/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,RoleName")] ClubRole clubRole)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clubRole);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(clubRole);
        }

        // GET: ClubRole/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clubRole = await _context.ClubRoles.FindAsync(id);
            if (clubRole == null)
            {
                return NotFound();
            }
            return View(clubRole);
        }

        // POST: ClubRole/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,RoleName")] ClubRole clubRole)
        {
            if (id != clubRole.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clubRole);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClubRoleExists(clubRole.Id))
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
            return View(clubRole);
        }

        // GET: ClubRole/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clubRole = await _context.ClubRoles
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clubRole == null)
            {
                return NotFound();
            }

            return View(clubRole);
        }

        // POST: ClubRole/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var clubRole = await _context.ClubRoles.FindAsync(id);
            _context.ClubRoles.Remove(clubRole);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClubRoleExists(int id)
        {
            return _context.ClubRoles.Any(e => e.Id == id);
        }
    }
}
