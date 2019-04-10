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
using Ballerz.Football.Ballerz.Web.Models.ClubPersonHistory;

namespace Ballerz.Football.Ballerz.Web.Controllers
{
    public class ClubPersonHistoryController : Controller
    {
             private readonly IClubPersonHistory _playerHistoryService;
        private readonly IClubPerson _playerService;
        private readonly IClubs _teamService;

        private readonly ApplicationDbContext _db;

        public ClubPersonHistoryController(IClubPersonHistory playerHistoryService, ISeason seasonService,
         ApplicationDbContext db, IClubPerson playerService, IClubs teamService)
        {
            _playerHistoryService = playerHistoryService;
            _db = db;
            _playerService = playerService;
            _teamService = teamService;
        }

        public IActionResult Index(int id)
        {
           
            var history = (from playerHistory in _db.ClubPersonHistory
                        .Where(h => h.ClubPersonId == id)
                        .OrderBy(s => s.Season)
                        join Player in _db.ClubPeople on playerHistory.ClubPersonId equals Player.Id
                              select new ClubPersonHistoryListingModel
                             {
                                ClubPersonId = playerHistory.ClubPersonId,
                                 ClubPersonName = Player.FirstName + Player.LastName,
                                 ClubName = playerHistory.TeamName,
                                 Season = playerHistory.Season,
                                 CompName = playerHistory.LeagueName,
                                 Games = playerHistory.Games,
                                 RedCards = playerHistory.RedCards,
                                 YellowCards = playerHistory.YellowCards,
                                 Goals = playerHistory.Goals,
                                 Position = playerHistory.Position,
                                 Points = playerHistory.Points
                             });
            var model = new ClubPersonHistoryIndexModel
            {
                ClubPersonHistoryList = history
            };
                             
            return View(model);

        }
        public IActionResult Create()
        {
            var model = new AddClubPersonHistoryModel();
            var players = _db.ClubPeople.OrderBy(p => p.ClubId)
                                         .Select(x => new { Id = x.Id, Value = x.FirstName + x.LastName});
            model.ClubPersonList = new SelectList(players, "Id", "Value");
            var leagues = _db.Competitions.OrderBy(c => c.CompName)
                                       .Select(x => new { Id = x.Id, Value = x.CompName });
            model.CompList = new SelectList(leagues, "Value", "Value");
            var season = _db.Seasons.OrderBy(s => s.Season)
                                         .Select(x => new { Id = x.Id, Value = x.Season });
            model.SeasonList = new SelectList(season, "Value", "Value");
            var team = _db.Clubs.OrderBy(s => s.ClubName)
                           .Select(x => new { Id = x.Id, Value = x.ClubName });
            model.ClubList = new SelectList(team, "Value", "Value");

            return View(model);
        }
        public async Task<IActionResult> AddClubPersonHistory(AddClubPersonHistoryModel model)
        {
            var history = new ClubPersonHistory
            {

                ClubPersonId = model.ClubPersonId,
                TeamName = model.ClubName,
                Season = model.Season,
                LeagueName = model.CompName,
                Games = model.Games,
                RedCards = model.RedCards,
                YellowCards = model.YellowCards,
                Goals = model.Goals,
                Position = model.Position,
                Points = model.Points


            };
            await _playerHistoryService.Create(history);
            return RedirectToAction("Index", "ClubPersonHistory");
        }
    }
}
