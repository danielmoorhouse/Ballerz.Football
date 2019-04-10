using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Ballerz.Football.Ballerz.Web.Models.ClubPerson
{
    public class AddClubPersonModel
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DoB { get; set; }
        public string From { get; set; }
        public string PlayerImageUrl { get; set; }
        public string Value { get; set; }
        public IFormFile PlayerImage { get; set; }
        public int CountryId { get; set; }
        public SelectList CountryList { get; set; }
        public int ClubId { get; set; }
        public SelectList ClubList { get; set; }
        public int ClubRoleId { get; set;  }
        public string IsCaptain { get; set; }
        public SelectList YesNoList { get; set; }
        public SelectList ClubRoleList { get; set; }
    }
}