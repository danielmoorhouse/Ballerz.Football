using Microsoft.AspNetCore.Http;

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
        public int LeagueId { get; set; }
        public string LeagueName { get; set; }
    }
}