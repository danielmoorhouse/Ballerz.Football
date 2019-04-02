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
using Microsoft.AspNetCore.Http;
using System.IO;

namespace Ballerz.Football.Ballerz.Web.Controllers
{
    public class StadiumController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IStadium _stadiumService;
        private readonly IClubs _clubsService;

        public StadiumController(ApplicationDbContext db, IClubs clubsService,
              IStadium stadiumService  )
        {
            _db = db;
            _stadiumService = stadiumService;
            _clubsService = clubsService;
        }

        // GET: Stadium
        public IActionResult Index()
        {
               var stadiums  = _stadiumService.GetAll()
                        .Select(s => new StadiumListingModel 
                            {
                                Id = s.Id,
                                StadiumName = s.StadiumName,                                        
                                HomeTeamId = s.HomeTeamId,
                                HomeTeamName = _clubsService.GetAll().Where(ht => ht.Id == s.HomeTeamId).FirstOrDefault().ClubName,
                                StadiumImageUrl = s.StadiumImageUrl,
                                ClubBadgeUrl = _clubsService.GetAll().Where(b => b.Id == s.HomeTeamId).FirstOrDefault().TeamBadgeUrl
                                
                             });
                              var model = new StadiumIndexModel
            {
                StadList = stadiums
            };
            return View(model);

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
            var model = new AddStadiumModel();
           var countries = _db.Countries.OrderBy(c => c.CountryName)
                                        .Select(x => new { Id = x.Id, Value = x.CountryName});
            
            model.CountryList = new SelectList(countries, "Id", "Value");
            
             var teams = _db.Clubs.OrderBy(c => c.ClubName)
                                        .Select(x => new { Id = x.Id, Value = x.ClubName});
            
            model.ClubList = new SelectList(teams, "Id", "Value");
            return View(model); 
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddStadium(AddStadiumModel model, IFormCollection StadiumImage)
        {
                string storePath = "/images/stadium_images/";
            var path = Path.Combine(
                     Directory.GetCurrentDirectory(), "wwwroot", "images", "stadium_images",
                     StadiumImage.Files[0].FileName);
                  
            using (var stream = new FileStream(path, FileMode.Create))
           {
               await StadiumImage.Files[0].CopyToAsync(stream); 
               
            }
                var stadium = new Stadium
                {
                StadiumName = model.StadiumName,
                CountryId = model.CountryId,
                Capacity = model.Capacity,
                Address1 = model.Address1,
                Address2 = model.Address2,
                PostCode = model.PostCode,
                StadiumImageUrl = storePath + model.StadiumImage.FileName,
                HomeTeamId = model.ClubId
                
            };
            
            await _stadiumService.Create(stadium);
            return RedirectToAction("Index", "Stadium");
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
