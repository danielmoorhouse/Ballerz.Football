using Microsoft.AspNetCore.Identity;

namespace Ballerz.Football.Ballerz.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Location { get; set; }
        public int Rating { get; set; }
        public string ProfileImageUrl { get; set; }
        public int TeamId { get; set; }
        public DateTime MemberSince { get; set; }
        public bool IsActive { get; set; }
    }
}