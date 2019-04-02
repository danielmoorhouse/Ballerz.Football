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
using Ballerz.Football.Ballerz.Web.Models.Clubs;
using Microsoft.AspNetCore.Http;
using System.IO;
using Ballerz.Football.Ballerz.Web.Models.Stadiums;
using Ballerz.Football.Ballerz.Web.Models.ClubPerson;

namespace Ballerz.Football.Ballerz.Web.Controllers
{
    public class ClubsController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IClubs _clubsService;
        private readonly IClubRole _clubRolesService;
        private readonly ICompetition _competitionService;
        private readonly IStadium _stadiumService;
        private readonly IClubPerson _clubPersonService;

        public ClubsController(ApplicationDbContext db, IClubs clubsService, ICompetition competitionService,
                            IStadium stadiumService, IClubPerson clubPersonService, IClubRole clubRolesService)
        {
            _db = db;
            _competitionService = competitionService;
            _clubsService = clubsService;
            _stadiumService = stadiumService;
            _clubPersonService = clubPersonService;
            _clubRolesService = clubRolesService;
        }

        // GET: Clubs
                  public IActionResult Index()
        {
            var teams = _clubsService.GetAll()
             .OrderBy(team => team.ClubName)
             .Select(c => new ClubListingModel
             {
               Id = c.Id,
               ClubName = c.ClubName,
               TeamBadgeUrl = c.TeamBadgeUrl,
               LeagueName =  _competitionService.GetAll().Where(l => l.Id == c.LeagueId).FirstOrDefault().CompName
               //LeagueName = _db.Competitions.Where(l => l.Id == c.LeagueId).FirstOrDefault().CompName
               
             });
            var model = new ClubIndexModel
            {
                ClubList = teams
            };
            return View(model);

        }
        public IActionResult Create()
        {

            var model = new AddClubModel();
            var leagues = _db.Competitions.OrderBy(c => c.CompName)
                                        .Select(x => new { Id = x.Id, Value = x.CompName});
                  model.LeagueList = new SelectList(leagues, "Id", "Value");  
                    
                    return View(model);
           
            
        }
        [HttpPost]
         [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddClub(AddClubModel model, IFormCollection ImageT1)
        {
          
            string storePath = "/images/club_badges/";
            var path = Path.Combine(
                     Directory.GetCurrentDirectory(), "wwwroot", "images", "club_badges",
                     ImageT1.Files[0].FileName);
            using (var stream = new FileStream(path, FileMode.Create))
           {
               await ImageT1.Files[0].CopyToAsync(stream); 
            }
         
           
            var club = new Club 
            {
                ClubName = model.ClubName,
                TeamBadgeUrl = storePath + model.ImageT1.FileName,
                YearFounded = model.YearFounded,
                WorldwideFans = model.WorldwideFans,
                AverageAttendance = model.AverageAttendance,
                SocialFollowing = model.SocialFollowing,
                ClubValue = model.ClubValue,
                LeagueId = model.LeagueId,
                PageTheme = model.PageTheme,
                PageTheme2 = model.PageTheme2
             };
            await _clubsService.Create(club);
            return RedirectToAction("Index", "Clubs");

        }
        // GET: Clubs/Details/5
        public IActionResult Details(int? id)
        {
             var stadiums =  _stadiumService.GetAll()
                        .Where(s => s.HomeTeamId == id).FirstOrDefault();
             var people = (from p in _db.ClubPeople.Where(cp => cp.ClubId == id).ToList()
                           .OrderBy(l => l.ClubRoleId)
                           join r in _db.ClubRoles on p.ClubRoleId equals r.Id
                           select new ClubPersonListingModel
                           {
                               Id = p.Id,
                               PlayerImageUrl = p.PlayerImageUrl,
                               FirstName = p.FirstName,
                               LastName = p.LastName,
                               ClubRoleName = r.RoleName

                           });
                        
                  
                     
                     var teams = _clubsService.GetAll()
                        .Where(t => t.Id == id).FirstOrDefault();
            var league = _competitionService.GetAll()
                        .Where(l => l.Id == teams.LeagueId).FirstOrDefault(); 
                                 
                  
            var model = new ClubDetailModel
            {
                Clubs = teams,
                Stadiums = stadiums,
                ClubPeople = people,
                Competitions = league,
            };         
                     
       

            return View(model);
        }

        // GET: Clubs/Create
      

        // POST: Clubs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
     

        // GET: Clubs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var club = await _db.Clubs.FindAsync(id);
            if (club == null)
            {
                return NotFound();
            }
            return View(club);
        }

        // POST: Clubs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ClubName,TeamBadgeUrl,YearFounded,WorldwideFans,AverageAttendance,SocialFollowing,ClubValue,LeagueId,LeagueName")] Club club)
        {
            if (id != club.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _db.Update(club);
                    await _db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClubExists(club.Id))
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
            return View(club);
        }

        // GET: Clubs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var club = await _db.Clubs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (club == null)
            {
                return NotFound();
            }

            return View(club);
        }

        // POST: Clubs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var club = await _db.Clubs.FindAsync(id);
            _db.Clubs.Remove(club);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClubExists(int id)
        {
            return _db.Clubs.Any(e => e.Id == id);
        }
    }
}
