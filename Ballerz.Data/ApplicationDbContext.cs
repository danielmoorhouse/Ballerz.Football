using System;
using System.Collections.Generic;
using System.Text;
using Ballerz.Football.Ballerz.Knowledgebase.Knowledgebase.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ballerz.Football.Ballerz.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Countries> Countries { get; set; }
        public DbSet<Continents> Continents { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<ClubPerson> ClubPeople { get; set; }
        public DbSet<ClubPersonImages> ClubPersonImages { get; set; }
        public DbSet<ClubPersonHistory> ClubPersonHistory { get; set; }
        public DbSet<ClubRole> ClubRoles { get; set; }
        public DbSet<Stadium> Stadiums { get; set; }
        public DbSet<StadiumImages> StadiumImages { get; set; }
        public DbSet<Seasons> Seasons { get; set; }
        public DbSet<Competitions> Competitions { get; set; }
    }
}
