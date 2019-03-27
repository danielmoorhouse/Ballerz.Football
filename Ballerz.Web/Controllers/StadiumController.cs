using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ballerz.Football.Ballerz.Data;
using Ballerz.Football.Ballerz.Knowledgebase.Knowledgebase.Data;
using Ballerz.Football.Ballerz.Services;
using Ballerz.Football.Ballerz.Web.Models.Stadiums;

namespace Ballerz.Football.Ballerz.Web.Controllers
{
    public class StadiumController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IStadium _stadiumService;

        public StadiumController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET: Stadium
        public IActionResult Index()
        {
               var stadiums  = (from s in _db.Stadiums
                                     .OrderBy(p => p.StadiumName)
                                    join t in _db.Clubs on s.HomeTeamId equals t.Id
                                    join c in _db.Countries on s.CountryId equals c.Id
                                    select new StadiumListingModel 
                                    {
                                        StadiumName = s.StadiumName,                                        
                                        CountryFlag = c.FlagUrl,
                                        StadiumImageUrl = s.StadiumImageUrl,
                                        ClubBadgeUrl = t.TeamBadgeUrl
                                       
                                       
                                    });
                                    return View();

        }


        // GET: Stadium/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

             var stadium = await _db.Stadiums
                 .FirstOrDefaultAsync(m => m.Id == id);
             if (stadium == null)
             {
                 return NotFound();
             }

            return View(stadium);
        }

        // GET: Stadium/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Stadium/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,StadiumName,StadiumImageUrl,CountryId,HomeTeamId,Capacity,Address1,Address2,PostCode")] Stadium stadium)
        {
            if (ModelState.IsValid)
            {
                _db.Add(stadium);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stadium);
        }

        // GET: Stadium/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stadium = await _db.Stadiums.FindAsync(id);
            if (stadium == null)
            {
                return NotFound();
            }
            return View(stadium);
        }

        // POST: Stadium/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,StadiumName,StadiumImageUrl,CountryId,HomeTeamId,Capacity,Address1,Address2,PostCode")] Stadium stadium)
        {
            if (id != stadium.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _db.Update(stadium);
                    await _db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StadiumExists(stadium.Id))
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
            return View(stadium);
        }

        // GET: Stadium/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stadium = await _db.Stadiums
                .FirstOrDefaultAsync(m => m.Id == id);
            if (stadium == null)
            {
                return NotFound();
            }

            return View(stadium);
        }

        // POST: Stadium/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var stadium = await _db.Stadiums.FindAsync(id);
            _db.Stadiums.Remove(stadium);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StadiumExists(int id)
        {
            return _db.Stadiums.Any(e => e.Id == id);
        }
    }
}
