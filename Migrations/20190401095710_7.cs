using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ballerz.Football.Migrations
{
    public partial class _7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DoB",
                table: "ClubPeople",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "PlayerImageUrl",
                table: "ClubPeople",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Value",
                table: "ClubPeople",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DoB",
                table: "ClubPeople");

            migrationBuilder.DropColumn(
                name: "PlayerImageUrl",
                table: "ClubPeople");

            migrationBuilder.DropColumn(
                name: "Value",
                table: "ClubPeople");
        }
    }
}
