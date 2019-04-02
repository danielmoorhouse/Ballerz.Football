namespace Ballerz.Football.Ballerz.Web.Models.ClubPerson
{
    public class ClubPersonListingModel
    {
        public int Id { get; set; }
         public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PlayerImageUrl { get; set; }
        public int ClubId { get; set; }
        public string ClubName { get; set; }
         public int CountryId { get; set; }
        public string CountryName { get; set; }
        public int ClubRoleId { get; set; }
        public string ClubRoleName { get; set; }
    }
}