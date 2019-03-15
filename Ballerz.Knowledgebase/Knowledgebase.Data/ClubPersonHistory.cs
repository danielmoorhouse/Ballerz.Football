namespace Ballerz.Football.Ballerz.Knowledgebase.Knowledgebase.Data
{
    public class ClubPersonHistory
    {
        public int Id { get; set; }
        public int ClubPersonId { get; set; }
        
         public string TeamName { get; set; }
        
        public string Season { get; set; }
        
        public string LeagueName { get; set; }
        
        public string RedCards { get; set; }
        public string YellowCards { get; set; }
        public string Goals { get; set; }
        public string Position { get; set; }
        public string Points { get; set; }
    }
}