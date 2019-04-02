namespace Ballerz.Football.Ballerz.Web.Models.Stadiums
{
    public class StadiumDetailModel
    {
          public string StadiumName { get; set; }
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string StadiumImageUrl { get; set; }
        public int ClubId { get; set; }
        
        public string Capacity { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string PostCode { get; set; }
    }
}