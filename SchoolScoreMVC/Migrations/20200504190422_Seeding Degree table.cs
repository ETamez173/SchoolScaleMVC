using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolScoreMVC.Migrations
{
    public partial class SeedingDegreetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Degree",
                columns: new[] { "Id", "EarningAvg", "EarningHigh", "EarningLow", "EducationName" },
                values: new object[,]
                {
                    { 1, 90000.0, 98000.0, 84000.0, "Electical Engineer" },
                    { 2, 90000.0, 98000.0, 84000.0, "Chemical Engineer" },
                    { 3, 60000.0, 73000.0, 55000.0, "Registered Nurse" },
                    { 4, 95000.0, 105000.0, 80000.0, "Computer Science" },
                    { 5, 30000.0, 38000.0, 24000.0, "Liberal Arts" },
                    { 6, 95000.0, 105000.0, 80000.0, "Full Stack Software Developer" },
                    { 7, 95000.0, 105000.0, 80000.0, "Front-End Web Designer Developer" },
                    { 8, 95000.0, 105000.0, 80000.0, "Data Science" },
                    { 9, 95000.0, 105000.0, 80000.0, "Data Analytics" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Degree",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Degree",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Degree",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Degree",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Degree",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Degree",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Degree",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Degree",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Degree",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
