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
using Ballerz.Football.Ballerz.Web.Models.Seasons;

namespace Ballerz.Football.Ballerz.Web.Controllers
{
    public class SeasonsController : Controller
    {
        private readonly ISeason _seasonService;

        public SeasonsController(ISeason seasonService)
        {
          _seasonService = seasonService;
        }
     
        // GET: Seasons
         public IActionResult Index()
    {
        var season = _seasonService.GetAll()
         .OrderBy(seasons => seasons.Season)
             .Select(c => new SeasonListingModel
             
        {
           Season = c.Season
        });
         var model = new SeasonIndexModel
            {
                SeasonList = season
            };
            return View(model);
    }

        // // GET: Seasons/Details/5
        // public async Task<IActionResult> Details(int? id)
        // {
        //     if (id == null)
        //     {
        //         return NotFound();
        //     }

        //     var seasons = await _context.Seasons
        //         .FirstOrDefaultAsync(m => m.Id == id);
        //     if (seasons == null)
        //     {
        //         return NotFound();
        //     }

        //     return View(seasons);
        // }

         public IActionResult Create()
        {
        var model = new AddSeasonModel();
        return View(model);
        }

        // POST: Seasons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
       public async Task<IActionResult> AddSeason(AddSeasonModel model)
    {
              var season = new Seasons
            {
                Season = model.Season
                
            };
            await _seasonService.Create(season);
            return RedirectToAction("Index", "Home");
    }

        // // GET: Seasons/Edit/5
        // public async Task<IActionResult> Edit(int? id)
        // {
        //     if (id == null)
        //     {
        //         return NotFound();
        //     }

        //     var seasons = await _db.Seasons.FindAsync(id);
        //     if (seasons == null)
        //     {
        //         return NotFound();
        //     }
        //     return View(seasons);
        // }

        // // POST: Seasons/Edit/5
        // // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // public async Task<IActionResult> Edit(int id, [Bind("Id,Season")] Seasons seasons)
        // {
        //     if (id != seasons.Id)
        //     {
        //         return NotFound();
        //     }

        //     if (ModelState.IsValid)
        //     {
        //         try
        //         {
        //             _context.Update(seasons);
        //             await _context.SaveChangesAsync();
        //         }
        //         catch (DbUpdateConcurrencyException)
        //         {
        //             if (!SeasonsExists(seasons.Id))
        //             {
        //                 return NotFound();
        //             }
        //             else
        //             {
        //                 throw;
        //             }
        //         }
        //         return RedirectToAction(nameof(Index));
        //     }
        //     return View(seasons);
        // }

        // GET: Seasons/Delete/5
        // public async Task<IActionResult> Delete(int? id)
        // {
        //     if (id == null)
        //     {
        //         return NotFound();
        //     }

        //     var seasons = await _context.Seasons
        //         .FirstOrDefaultAsync(m => m.Id == id);
        //     if (seasons == null)
        //     {
        //         return NotFound();
        //     }

        //     return View(seasons);
        // }

        // // POST: Seasons/Delete/5
        // [HttpPost, ActionName("Delete")]
        // [ValidateAntiForgeryToken]
        // public async Task<IActionResult> DeleteConfirmed(int id)
        // {
        //     var seasons = await _context.Seasons.FindAsync(id);
        //     _context.Seasons.Remove(seasons);
        //     await _context.SaveChangesAsync();
        //     return RedirectToAction(nameof(Index));
        // }

        // private bool SeasonsExists(int id)
        // {
        //     return _context.Seasons.Any(e => e.Id == id);
        // }
    }
}
