
namespace Ballerz.Football.Ballerz.Web.Models.ClubPersonHistory
{
    public class ClubPersonHistoryListingModel
    {
        public int Id { get; set; }
         public int ClubPersonId { get; set; }
       
       public string ClubPersonName { get; set; }
      
        public string ClubName { get; set; }
        public string Season { get; set; }
       
        public string CompName { get; set; }
       
        public string Games { get; set; }
        public string RedCards { get; set; }
        public string YellowCards { get; set; }
        public string Goals { get; set; }
        public string Position { get; set; }
        public string Points { get; set; }
    }
}