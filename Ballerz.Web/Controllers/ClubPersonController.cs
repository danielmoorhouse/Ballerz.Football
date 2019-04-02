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
using Ballerz.Football.Ballerz.Web.Models.ClubPerson;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace Ballerz.Football.Ballerz.Web.Controllers
{
    public class ClubPersonController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IClubPerson _clubPersonService;
        private readonly IClubs _clubsService;
        private readonly IClubRole _clubRolesService;
        private readonly ICountries _countriesService;

        public ClubPersonController(ApplicationDbContext context, IClubPerson clubPersonService,
                IClubs clubsService, IClubRole clubRolesService, ICountries countriesService)
        {
            _context = context;
            _clubPersonService = clubPersonService;
            _clubsService = clubsService;
            _clubRolesService = clubRolesService;
            _countriesService = countriesService;
        }

        // GET: ClubPerson
        public IActionResult Index()
        {
            var clubPerson = _clubPersonService.GetAll()
            .OrderBy(cp => cp.LastName)
            .Select(c => new ClubPersonListingModel
            {
                Id = c.Id,
                FirstName = c.FirstName,
                LastName = c.LastName,
                PlayerImageUrl = c.PlayerImageUrl,
                ClubId = c.ClubId,
                ClubName =  _clubsService.GetAll().Where(n => n.Id == c.ClubId).FirstOrDefault().ClubName,
                CountryId = c.CountryId,
                CountryName = _countriesService.GetAll().Where(l => l.Id == c.CountryId).FirstOrDefault().CountryName,
                ClubRoleId = c.ClubRoleId,
                ClubRoleName = _clubRolesService.GetAll().Where(r => r.Id == c.ClubRoleId).FirstOrDefault().RoleName
            });
            var model = new ClubPersonIndexModel
            {
                CPList = clubPerson
            };
            return View(model);
        }

        // GET: ClubPerson/Details/5
        public IActionResult Details(int? id)
        {
     

            return View();
        }

        // GET: ClubPerson/Create
        public IActionResult Create()
        {
            var model = new AddClubPersonModel();
            var clubs = _clubsService.GetAll()
                        .OrderBy(c => c.ClubName)
                        .Select(x => new {Id = x.Id, Value = x.ClubName});
            model.ClubList = new SelectList(clubs, "Id", "Value");  

            var clubRoles = _clubRolesService.GetAll()
                        .OrderBy(c => c.Id)
                        .Select(x => new {Id = x.Id, Value = x.RoleName});
            model.ClubRoleList = new SelectList(clubRoles, "Id", "Value");  

            var countries = _countriesService.GetAll()
                        .OrderBy(c => c.ContinentId)
                        .Select(x => new {Id = x.Id, Value = x.CountryName});
            model.CountryList = new SelectList(countries, "Id", "Value");          

            return View(model);
        }

        // POST: ClubPerson/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddClubPerson(AddClubPersonModel model, IFormCollection PlayerImage)
        {
            string storePath = "/images/club_person_images/";
            var path = Path.Combine(
                     Directory.GetCurrentDirectory(), "wwwroot", "images", "club_person_images",
                     PlayerImage.Files[0].FileName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await PlayerImage.Files[0].CopyToAsync(stream);
            }
            var clubPerson = new ClubPerson
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                DoB = model.DoB,
                From = model.From,
                PlayerImageUrl = storePath + model.PlayerImage.FileName,
                Value = model.Value,
                CountryId = model.CountryId,
                ClubId = model.ClubId,
                ClubRoleId = model.ClubRoleId
            };
            await _clubPersonService.Create(clubPerson);
            return RedirectToAction("Index", "ClubPerson");
           
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
