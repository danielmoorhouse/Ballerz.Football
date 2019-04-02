namespace Ballerz.Football.Ballerz.Web.Models.Competitions
{
    public class CompetitionListingModel
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public int CompTypeId { get; set; }
        public string CompTypeName { get; set; }
        public string CompName { get; set; }
        public string CompImgUrl { get; set; } 
    }
}