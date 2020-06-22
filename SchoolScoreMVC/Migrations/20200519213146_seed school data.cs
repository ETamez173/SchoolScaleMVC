using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolScoreMVC.Migrations
{
    public partial class seedschooldata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "State", "Zip" },
                values: new object[] { "1301 E. Main St.", "Murfreesboro", "TN", "37132" });

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "State", "Zip" },
                values: new object[] { "1 William L. Jones Dr.", "Cookeville", "TN", "38505" });

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "State", "Zip" },
                values: new object[] { "2201 West End Ave.", "Nashville", "TN", "37235" });

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "SchoolName", "State", "Zip" },
                values: new object[] { "1200 W. Harrison", "Chicago", "University of Illinois Chicago", "IL", "60607" });

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "SchoolName", "State", "Zip" },
                values: new object[] { "1110 W. Springfield", "Urbana", "University of Illinois Urbana", "IL", "61801" });

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "State", "Zip" },
                values: new object[] { "400 East Main St.", "Frankfort", "KY", "40601" });

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "SchoolName", "State", "Zip" },
                values: new object[] { "1 Ohio University", "Athens", "Ohio University", "OH", "45701" });

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "State", "Zip" },
                values: new object[] { "1665 Hampshire Pike", "Columbia", "TN", "38401" });

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "State", "Zip" },
                values: new object[] { "301 Plus Park Blvd #300", "Nashville", "TN", "37217" });

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "State", "Zip" },
                values: new object[] { "100 BBQ Lane", "Nashville", "TN", "37217" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "City", "State", "Zip" },
                values: new object[] { "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "State", "Zip" },
                values: new object[] { "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "State", "Zip" },
                values: new object[] { "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "SchoolName", "State", "Zip" },
                values: new object[] { "", "", "U of I Chicago", "", "" });

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "SchoolName", "State", "Zip" },
                values: new object[] { "", "", "U of I Urbana", "", "" });

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "State", "Zip" },
                values: new object[] { "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "SchoolName", "State", "Zip" },
                values: new object[] { "", "", "University of OH", "", "" });

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "State", "Zip" },
                values: new object[] { "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "State", "Zip" },
                values: new object[] { "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "State", "Zip" },
                values: new object[] { "", "", "", "" });
        }
    }
}
