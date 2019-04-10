using System.Collections.Generic;

namespace Ballerz.Football.Ballerz.Web.Models.ClubPerson
{
    public class ClubPersonDetailModel
    {
        public Ballerz.Knowledgebase.Knowledgebase.Data.ClubPerson ClubPerson { get; set; }
        public Ballerz.Knowledgebase.Knowledgebase.Data.Club Club { get; set; }
        public Ballerz.Knowledgebase.Knowledgebase.Data.ClubRole ClubRole { get; set; }
        public Ballerz.Knowledgebase.Knowledgebase.Data.Competitions Competition { get; set; }
        public Ballerz.Knowledgebase.Knowledgebase.Data.Countries Country { get; set; }

        public IEnumerable<Ballerz.Knowledgebase.Knowledgebase.Data.ClubPersonHistory> ClubPersonHistory { get; set; }
    }
}