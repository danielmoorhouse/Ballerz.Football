using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Ballerz.Football.Ballerz.Web.Models.Competitions
{
    public class AddCompetitionModel
    {
        public int CountryId { get; set; }
        public SelectList CountryList { get; set; }
        public int CompTypeId { get; set; }
        public SelectList CompTypeList { get; set; }
        public string CompName { get; set; }
        public string CompImgUrl { get; set; }
        public IFormFile CompImg1 { get; set; }
    }
}