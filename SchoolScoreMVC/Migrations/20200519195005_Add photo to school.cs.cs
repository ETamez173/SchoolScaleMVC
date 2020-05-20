using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolScoreMVC.Migrations
{
    public partial class Addphototoschoolcs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AlternateText",
                table: "School",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "School",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlternateText",
                table: "School");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "School");
        }
    }
}
