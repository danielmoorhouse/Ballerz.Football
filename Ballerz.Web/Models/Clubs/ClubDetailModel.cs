namespace Ballerz.Football.Ballerz.Web.Models.Clubs
{
    public class ClubDetailModel
    {
        public int Id { get; set; }
        public string ClubName { get; set; }
        public string TeamBadgeUrl { get; set; }
        public string YearFounded { get; set; }
        public string WorldwideFans { get; set; }
        public string AverageAttendance { get; set; }
        public string SocialFollowing { get; set; }
        public string ClubValue { get; set; }
        public int LeagueId { get; set; }
        public string LeagueName { get; set; }
    }
}