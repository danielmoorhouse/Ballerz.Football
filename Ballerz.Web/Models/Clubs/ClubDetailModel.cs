using System.Collections.Generic;

namespace Ballerz.Football.Ballerz.Web.Models.Clubs
{
    public class ClubDetailModel
    {
     public Ballerz.Knowledgebase.Knowledgebase.Data.Club Clubs { get; set; }
     public Ballerz.Knowledgebase.Knowledgebase.Data.Stadium Stadiums { get; set; }
     public IEnumerable<Ballerz.Web.Models.ClubPerson.ClubPersonListingModel> ClubPeople { get; set; }
     public Ballerz.Knowledgebase.Knowledgebase.Data.Competitions Competitions { get; set; }
    
     
    }
}