using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolScoreMVC.Migrations
{
    public partial class Addressaddedtoregisterindexapplcationuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StreetAddress",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StreetAddress",
                table: "AspNetUsers");
        }
    }
}
