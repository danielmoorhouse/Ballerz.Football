namespace Ballerz.Football.Ballerz.Knowledgebase.Knowledgebase.Data
{
    public class Stadium
    {
        public int Id { get; set; }
        public string StadiumName { get; set; }
        public string StadiumImageUrl { get; set; }
        public int CountryId { get; set; }
        public int HomeTeamId { get; set; }
        public string Capacity { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string PostCode { get; set; }
        
      
    }
}