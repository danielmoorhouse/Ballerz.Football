using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Ballerz.Football.Ballerz.Data;
using Ballerz.Football.Ballerz.Knowledgebase.Knowledgebase.Data;
using Ballerz.Football.Ballerz.Web.Models.Competitions;
using Microsoft.AspNetCore.Http;
using System.IO;
using Ballerz.Football.Ballerz.Services;

namespace Ballerz.Football.Ballerz.Web.Controllers
{
    public class CompetitionsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ICompetition _competitionService;

        public CompetitionsController(ApplicationDbContext context, ICompetition competitionService)
        {
            _context = context;
            _competitionService = competitionService;
        }

        // GET: Competitions
        public IActionResult Index()
        {
            var comps =  _competitionService.GetAll()
            .OrderBy(c => c.CountryId)
            .Select(l => new CompetitionListingModel
            {
                Id = l.Id,
                CompTypeId = l.CompTypeId,
                CompTypeName = _context.CompType.Where(ct => ct.Id == l.CompTypeId).FirstOrDefault().CompetitionType,
                CompName = l.CompName,
                CompImgUrl = l.CompImgUrl

            });
            var model = new CompetitionIndexModel
            {
                CompList = comps
            };
            return View(model);
        }
         public IActionResult CountryComp(int id)
           {
            var comps =  _competitionService.GetAll().Where(c => c.CountryId == id)
            .OrderBy(c => c.CompName)
            .Select(l => new CompetitionListingModel
            {
                Id = l.Id,
                CompTypeId = l.CompTypeId,
                CompTypeName = _context.CompType.Where(ct => ct.Id == l.CompTypeId).FirstOrDefault().CompetitionType,
                CompName = l.CompName,
                CompImgUrl = l.CompImgUrl

            });
            var model = new CompetitionIndexModel
            {
                CompList = comps
            };
            return View(model);
        }

        // GET: Competitions/Details/5
        public IActionResult Details(int? id)
        {
          

            return View();
        }

        // GET: Competitions/Create
        public IActionResult Create()
        {
            var model = new AddCompetitionModel();
                   var countries = _context.Countries.OrderBy(c => c.CountryName)
                                        .Select(x => new { Id = x.Id, Value = x.CountryName});
                                        model.CountryList = new SelectList(countries, "Id", "Value");

                   var compType = _context.CompType.OrderBy(c => c.CompetitionType)                     
                                        .Select(x => new { Id = x.Id, Value = x.CompetitionType});
            model.CompTypeList = new SelectList(compType, "Id", "Value");


            return View(model);
        }

        // POST: Competitions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddCompetition(AddCompetitionModel model, IFormCollection compImage)
        {
             string storePath = "/images/comp_images/";
            var path = Path.Combine(
                     Directory.GetCurrentDirectory(), "wwwroot", "images", "comp_images",
                     compImage.Files[0].FileName);
            using (var stream = new FileStream(path, FileMode.Create))
           {
               await compImage.Files[0].CopyToAsync(stream); 
            }
            var competition = new Competitions
            {
                CountryId = model.CountryId,
                CompTypeId = model.CompTypeId,
                CompName = model.CompName,
                CompImgUrl = storePath + model.CompImg1.FileName
            };
            await _competitionService.Create(competition);
            
            return RedirectToAction("Index" , "Competitions");
         
            
        }

        // GET: Competitions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var competitions = await _context.Competitions.FindAsync(id);
            if (competitions == null)
            {
                return NotFound();
            }
            return View(competitions);
        }

        // POST: Competitions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CountryId,CompTypeId,CompName,CompImgUrl")] Competitions competitions)
        {
            if (id != competitions.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(competitions);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompetitionsExists(competitions.Id))
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
            return View(competitions);
        }

        // GET: Competitions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var competitions = await _context.Competitions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (competitions == null)
            {
                return NotFound();
            }

            return View(competitions);
        }

        // POST: Competitions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var competitions = await _context.Competitions.FindAsync(id);
            _context.Competitions.Remove(competitions);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompetitionsExists(int id)
        {
            return _context.Competitions.Any(e => e.Id == id);
        }
    }
}
