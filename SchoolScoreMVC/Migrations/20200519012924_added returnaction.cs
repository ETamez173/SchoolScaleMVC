using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolScoreMVC.Migrations
{
    public partial class addedreturnaction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ReturnAction",
                table: "School",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReturnController",
                table: "School",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReturnAction",
                table: "School");

            migrationBuilder.DropColumn(
                name: "ReturnController",
                table: "School");
        }
    }
}
