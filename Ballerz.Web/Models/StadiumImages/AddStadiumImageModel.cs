using Microsoft.AspNetCore.Http;

namespace Ballerz.Football.Ballerz.Web.Models.StadiumImages
{
    public class AddStadiumImageModel
    {
        public int StadiumId { get; set; }
        public string StadiumImageUrl { get; set; }
        public IFormFile ExStadImageUpload { get; set; }
        public string ImageCaption { get; set; } 
    }
}