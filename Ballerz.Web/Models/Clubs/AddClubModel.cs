using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Ballerz.Football.Ballerz.Web.Models.Clubs
{
    public class AddClubModel
    {
        public string ClubName { get; set; }
        public string TeamBadgeUrl { get; set; }
        public IFormFile ImageT1 { get; set; }
        public string YearFounded { get; set; }
        public string WorldwideFans { get; set; }
        public string AverageAttendance { get; set; }
        public string SocialFollowing { get; set; }
        public string ClubValue { get; set; }
        public string PageTheme { get; set; }
        public string PageTheme2 { get; set; }
        public int LeagueId { get; set; }
        public SelectList LeagueList { get; set; }
    }
}