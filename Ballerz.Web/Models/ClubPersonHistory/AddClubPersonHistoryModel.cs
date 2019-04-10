using Microsoft.AspNetCore.Mvc.Rendering;

namespace Ballerz.Football.Ballerz.Web.Models.ClubPersonHistory
{
    public class AddClubPersonHistoryModel
    {
         public int ClubPersonId { get; set; }
        public SelectList ClubPersonList { get; set; }
       
        public string ClubName { get; set; }
        public SelectList ClubList { get; set; }
        public string Season { get; set; }
        public SelectList SeasonList { get; set; }
        public string CompName { get; set; }
        public SelectList CompList { get; set; }
        public string Games { get; set; }
        public string RedCards { get; set; }
        public string YellowCards { get; set; }
        public string Goals { get; set; }
        public string Position { get; set; }
        public string Points { get; set; }
    }
}