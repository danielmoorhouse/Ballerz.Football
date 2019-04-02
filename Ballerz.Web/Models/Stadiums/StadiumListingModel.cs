namespace Ballerz.Football.Ballerz.Web.Models.Stadiums
{
    public class StadiumListingModel
    {
        public int Id { get; set; }
        public string StadiumName { get; set; }
        public int HomeTeamId { get; set; }
        public string HomeTeamName { get; set; }
        public string ClubBadgeUrl { get; set; }
        public string StadiumImageUrl { get; set; }
    }
}