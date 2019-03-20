using Microsoft.AspNetCore.Http;

namespace Ballerz.Football.Ballerz.Web.Models.Countries
{
    public class AddCountryModel
    {
           public string Name { get; set; }
        public string FlagUrl { get; set; }

        public IFormFile UploadFlag { get; set; }
    }
}