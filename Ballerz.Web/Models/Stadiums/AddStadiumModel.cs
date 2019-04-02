using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Ballerz.Football.Ballerz.Web.Models.Stadiums
{
    public class AddStadiumModel
    {
        public string StadiumName { get; set; }
        public int CountryId { get; set; }
        public SelectList CountryList { get; set; }
        public string StadiumImageUrl { get; set; }
        public IFormFile StadiumImage { get; set; }
        public int ClubId { get; set; }
        public SelectList ClubList { get; set; }
        public string Capacity { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string PostCode { get; set; }
    }
}