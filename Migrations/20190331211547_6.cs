using Microsoft.EntityFrameworkCore.Migrations;

namespace Ballerz.Football.Migrations
{
    public partial class _6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LeagueName",
                table: "Clubs");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ClubPeople",
                newName: "LastName");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "ClubPeople",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "ClubPeople");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "ClubPeople",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "LeagueName",
                table: "Clubs",
                nullable: true);
        }
    }
}
