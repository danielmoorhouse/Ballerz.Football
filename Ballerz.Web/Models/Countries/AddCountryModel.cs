using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Ballerz.Football.Ballerz.Web.Models.Countries
{
    public class AddCountryModel
    {
           public string Name { get; set; }
        public string FlagUrl { get; set; }

        public IFormFile UploadFlag { get; set; }
        public int ContinentId { get; set; }
        public SelectList ContinentList { get; set; }
    }
}