namespace Ballerz.Football.Ballerz.Knowledgebase.Knowledgebase.Data
{
    public class ClubPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string From { get; set; }
        public int CountryId { get; set; }
        public int ClubId { get; set; }
        public int ClubRoleId { get; set;  }
    }
}