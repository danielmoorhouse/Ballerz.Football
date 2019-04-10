using System;
using Microsoft.AspNetCore.Http;

namespace Ballerz.Football.Ballerz.Knowledgebase.Knowledgebase.Data
{
    public class ClubPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime  DoB { get; set; }
        public string From { get; set; }
        public string PlayerImageUrl { get; set; }
        public string Value { get; set; }
        public string IsCaptain { get; set;  }
        public int CountryId { get; set; }
        public int ClubId { get; set; }
        public int ClubRoleId { get; set;  }
    }
}