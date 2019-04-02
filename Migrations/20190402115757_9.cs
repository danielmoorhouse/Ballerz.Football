using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ballerz.Football.Migrations
{
    public partial class _9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PageTheme",
                table: "Clubs",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DoB",
                table: "ClubPeople",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PageTheme",
                table: "Clubs");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DoB",
                table: "ClubPeople",
                nullable: true,
                oldClrType: typeof(DateTime));
        }
    }
}
