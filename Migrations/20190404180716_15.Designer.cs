﻿// <auto-generated />
using System;
using Ballerz.Football.Ballerz.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Ballerz.Football.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190404180716_15")]
    partial class _15
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Ballerz.Football.Ballerz.Data.ApplicationRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Ballerz.Football.Ballerz.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Ballerz.Football.Ballerz.Data.YesNo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("YesNo");
                });

            modelBuilder.Entity("Ballerz.Football.Ballerz.Knowledgebase.Knowledgebase.Data.Club", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AverageAttendance");

                    b.Property<string>("ClubName");

                    b.Property<string>("ClubValue");

                    b.Property<int>("LeagueId");

                    b.Property<string>("PageTheme");

                    b.Property<string>("PageTheme2");

                    b.Property<string>("SocialFollowing");

                    b.Property<string>("TeamBadgeUrl");

                    b.Property<string>("WorldwideFans");

                    b.Property<string>("YearFounded");

                    b.HasKey("Id");

                    b.ToTable("Clubs");
                });

            modelBuilder.Entity("Ballerz.Football.Ballerz.Knowledgebase.Knowledgebase.Data.ClubPerson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClubId");

                    b.Property<int>("ClubRoleId");

                    b.Property<int>("CountryId");

                    b.Property<DateTime>("DoB");

                    b.Property<string>("FirstName");

                    b.Property<string>("From");

                    b.Property<string>("IsCaptain");

                    b.Property<string>("LastName");

                    b.Property<string>("PlayerImageUrl");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.ToTable("ClubPeople");
                });

            modelBuilder.Entity("Ballerz.Football.Ballerz.Knowledgebase.Knowledgebase.Data.ClubPersonHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClubPersonId");

                    b.Property<string>("Games");

                    b.Property<string>("Goals");

                    b.Property<string>("LeagueName");

                    b.Property<string>("Points");

                    b.Property<string>("Position");

                    b.Property<string>("RedCards");

                    b.Property<string>("Season");

                    b.Property<string>("TeamName");

                    b.Property<string>("YellowCards");

                    b.HasKey("Id");

                    b.ToTable("ClubPersonHistory");
                });

            modelBuilder.Entity("Ballerz.Football.Ballerz.Knowledgebase.Knowledgebase.Data.ClubPersonImages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClubPersonId");

                    b.Property<string>("ImageCaption");

                    b.Property<string>("ImageUrl");

                    b.HasKey("Id");

                    b.ToTable("ClubPersonImages");
                });

            modelBuilder.Entity("Ballerz.Football.Ballerz.Knowledgebase.Knowledgebase.Data.ClubRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("RoleName");

                    b.HasKey("Id");

                    b.ToTable("ClubRoles");
                });

            modelBuilder.Entity("Ballerz.Football.Ballerz.Knowledgebase.Knowledgebase.Data.CompType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CompetitionType");

                    b.HasKey("Id");

                    b.ToTable("CompType");
                });

            modelBuilder.Entity("Ballerz.Football.Ballerz.Knowledgebase.Knowledgebase.Data.Competitions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CompImgUrl");

                    b.Property<string>("CompName");

                    b.Property<int>("CompTypeId");

                    b.Property<int>("CountryId");

                    b.HasKey("Id");

                    b.ToTable("Competitions");
                });

            modelBuilder.Entity("Ballerz.Football.Ballerz.Knowledgebase.Knowledgebase.Data.Continents", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ContinentImageUrl");

                    b.Property<string>("ContinentName");

                    b.HasKey("Id");

                    b.ToTable("Continents");
                });

            modelBuilder.Entity("Ballerz.Football.Ballerz.Knowledgebase.Knowledgebase.Data.Countries", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ContinentId");

                    b.Property<string>("CountryName");

                    b.Property<string>("FlagUrl");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Ballerz.Football.Ballerz.Knowledgebase.Knowledgebase.Data.Seasons", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Season");

                    b.HasKey("Id");

                    b.ToTable("Seasons");
                });

            modelBuilder.Entity("Ballerz.Football.Ballerz.Knowledgebase.Knowledgebase.Data.Stadium", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address1");

                    b.Property<string>("Address2");

                    b.Property<string>("Capacity");

                    b.Property<int>("CountryId");

                    b.Property<int>("HomeTeamId");

                    b.Property<string>("PostCode");

                    b.Property<string>("StadiumImageUrl");

                    b.Property<string>("StadiumName");

                    b.HasKey("Id");

                    b.ToTable("Stadiums");
                });

            modelBuilder.Entity("Ballerz.Football.Ballerz.Knowledgebase.Knowledgebase.Data.StadiumImages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ImageCaption");

                    b.Property<int>("StadiumId");

                    b.Property<string>("StadiumImageUrl");

                    b.HasKey("Id");

                    b.ToTable("StadiumImages");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Ballerz.Football.Ballerz.Data.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Ballerz.Football.Ballerz.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Ballerz.Football.Ballerz.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Ballerz.Football.Ballerz.Data.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ballerz.Football.Ballerz.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Ballerz.Football.Ballerz.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
