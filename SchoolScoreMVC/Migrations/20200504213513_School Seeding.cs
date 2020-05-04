using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolScoreMVC.Migrations
{
    public partial class SchoolSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "School",
                columns: new[] { "Id", "Address", "City", "SchoolName", "State", "Zip" },
                values: new object[,]
                {
                    { 1, "", "", "MTSU", "", "" },
                    { 2, "", "", "Tennesse Tech", "", "" },
                    { 3, "", "", "Vanderbilt", "", "" },
                    { 4, "", "", "U of I Chicago", "", "" },
                    { 5, "", "", "U of I Urbana", "", "" },
                    { 6, "", "", "Kentucky State", "", "" },
                    { 7, "", "", "University of OH", "", "" },
                    { 8, "", "", "Columbia State", "", "" },
                    { 9, "", "", "Nashville School of Software", "", "" },
                    { 10, "", "", "Bubbas School of Learning", "", "" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "School",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "School",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "School",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "School",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "School",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "School",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "School",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "School",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "School",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "School",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
