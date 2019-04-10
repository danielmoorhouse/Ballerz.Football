namespace Ballerz.Football.Ballerz.Data
{
    public class Profile : ApplicationUser
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string FirstName { get;set;}
        public string LastName { get; set; }
        public int ClubId { get; set; }
        public DateTime MemberSince { get; set; }
        public string ShortDescription { get; set; }
        
        public int CountryId { get; set; }
        
        public string ProfileImageUrl { get; set; }

        public string Location { get; set; }
        public string UserRating { get; set; }
        public bool IsAdmin { get; set; }

    }
}