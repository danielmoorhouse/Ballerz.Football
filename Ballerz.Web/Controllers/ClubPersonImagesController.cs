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
    public class ClubPersonImagesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClubPersonImagesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ClubPersonImages
        public async Task<IActionResult> Index()
        {
            return View(await _context.ClubPersonImages.ToListAsync());
        }

        // GET: ClubPersonImages/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clubPersonImages = await _context.ClubPersonImages
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clubPersonImages == null)
            {
                return NotFound();
            }

            return View(clubPersonImages);
        }

        // GET: ClubPersonImages/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ClubPersonImages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ClubPersonId,ImageUrl,ImageCaption")] ClubPersonImages clubPersonImages)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clubPersonImages);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(clubPersonImages);
        }

        // GET: ClubPersonImages/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clubPersonImages = await _context.ClubPersonImages.FindAsync(id);
            if (clubPersonImages == null)
            {
                return NotFound();
            }
            return View(clubPersonImages);
        }

        // POST: ClubPersonImages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ClubPersonId,ImageUrl,ImageCaption")] ClubPersonImages clubPersonImages)
        {
            if (id != clubPersonImages.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clubPersonImages);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClubPersonImagesExists(clubPersonImages.Id))
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
            return View(clubPersonImages);
        }

        // GET: ClubPersonImages/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clubPersonImages = await _context.ClubPersonImages
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clubPersonImages == null)
            {
                return NotFound();
            }

            return View(clubPersonImages);
        }

        // POST: ClubPersonImages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var clubPersonImages = await _context.ClubPersonImages.FindAsync(id);
            _context.ClubPersonImages.Remove(clubPersonImages);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClubPersonImagesExists(int id)
        {
            return _context.ClubPersonImages.Any(e => e.Id == id);
        }
    }
}
