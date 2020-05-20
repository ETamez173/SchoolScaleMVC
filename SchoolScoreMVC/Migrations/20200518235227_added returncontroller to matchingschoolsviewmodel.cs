using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolScoreMVC.Migrations
{
    public partial class addedreturncontrollertomatchingschoolsviewmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DegreeSchool",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DegreeSchool",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DegreeSchool",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DegreeSchool",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DegreeSchool",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DegreeSchool",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DegreeSchool",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "DegreeSchool",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "DegreeSchool",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "DegreeSchool",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "DegreeSchool",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "DegreeSchool",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "DegreeSchool",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "DegreeSchool",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "DegreeSchool",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "DegreeSchool",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "DegreeSchool",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "DegreeSchool",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "DegreeSchool",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "DegreeSchool",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "DegreeSchool",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "DegreeSchool",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "DegreeSchool",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "DegreeSchool",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "DegreeSchool",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "DegreeSchool",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "DegreeSchool",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "DegreeSchool",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "DegreeSchool",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "DegreeSchool",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "DegreeSchool",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "DegreeSchool",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "DegreeSchool",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "DegreeSchool",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "DegreeSchool",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "DegreeSchool",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "DegreeSchool",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "DegreeSchool",
                keyColumn: "Id",
                keyValue: 38);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "DegreeSchool",
                columns: new[] { "Id", "AnnualCost", "DegreeId", "SchoolId", "StudyYears", "TotalCost" },
                values: new object[,]
                {
                    { 1, 12500.0, 1, 1, 4, 50000.0 },
                    { 24, 7000.0, 3, 8, 4, 28000.0 },
                    { 25, 800.0, 3, 10, 4, 3200.0 },
                    { 26, 10000.0, 4, 1, 4, 40000.0 },
                    { 27, 10000.0, 4, 2, 4, 40000.0 },
                    { 28, 16000.0, 4, 3, 4, 64000.0 },
                    { 29, 21000.0, 4, 4, 4, 84000.0 },
                    { 30, 20000.0, 4, 5, 4, 80000.0 },
                    { 31, 9000.0, 4, 6, 4, 36000.0 },
                    { 32, 8750.0, 4, 7, 4, 35000.0 },
                    { 33, 4000.0, 4, 8, 4, 16000.0 },
                    { 34, 900.0, 4, 10, 4, 3600.0 },
                    { 16, 8500.0, 5, 1, 4, 34000.0 },
                    { 17, 15000.0, 5, 4, 4, 60000.0 },
                    { 35, 12500.0, 6, 9, 1, 12500.0 },
                    { 36, 12500.0, 7, 9, 1, 12500.0 },
                    { 23, 9000.0, 3, 7, 4, 36000.0 },
                    { 22, 7500.0, 3, 6, 4, 30000.0 },
                    { 21, 16000.0, 3, 5, 4, 64000.0 },
                    { 20, 20000.0, 3, 4, 4, 80000.0 },
                    { 2, 25000.0, 1, 2, 4, 100000.0 },
                    { 3, 25000.0, 1, 3, 4, 100000.0 },
                    { 4, 20000.0, 1, 4, 4, 80000.0 },
                    { 5, 12000.0, 1, 5, 4, 48000.0 },
                    { 6, 8000.0, 1, 6, 4, 32000.0 },
                    { 7, 10000.0, 1, 7, 4, 40000.0 },
                    { 8, 6500.0, 1, 8, 4, 26000.0 },
                    { 37, 12500.0, 8, 9, 1, 12500.0 },
                    { 9, 1200.0, 1, 10, 4, 4800.0 },
                    { 11, 13000.0, 2, 2, 4, 52000.0 },
                    { 12, 22000.0, 2, 4, 4, 88000.0 },
                    { 13, 21000.0, 2, 5, 4, 84000.0 },
                    { 14, 10500.0, 2, 7, 4, 42000.0 },
                    { 15, 1200.0, 2, 10, 4, 4800.0 },
                    { 18, 9500.0, 3, 1, 4, 38000.0 },
                    { 19, 13000.0, 3, 3, 4, 52000.0 },
                    { 10, 11250.0, 2, 1, 4, 45000.0 },
                    { 38, 7500.0, 9, 9, 1, 7500.0 }
                });
        }
    }
}
