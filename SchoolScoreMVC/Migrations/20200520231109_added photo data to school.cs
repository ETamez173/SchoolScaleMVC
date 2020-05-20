using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolScoreMVC.Migrations
{
    public partial class addedphotodatatoschool : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AlternateText", "Photo" },
                values: new object[] { "MTSU Photo", "MTSU.jpg" });

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AlternateText", "Photo" },
                values: new object[] { "Tennessee Tech Photo", "TennTech.jpg" });

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AlternateText", "Photo" },
                values: new object[] { "Vanderbilt Photo", "Vanderbilt.jpg" });

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AlternateText", "Photo" },
                values: new object[] { "University of Illinois Chicago Photo", "UofIChicago.jpg" });

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AlternateText", "Photo" },
                values: new object[] { "University of Illinois Urbana Photo", "UofIUrbana.jpg" });

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AlternateText", "Photo" },
                values: new object[] { "Kentucky State Photo", "KentuckyState.jpg" });

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AlternateText", "Photo" },
                values: new object[] { "Ohio University Photo", "OhioUniv.jpg" });

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AlternateText", "Photo" },
                values: new object[] { "Columbia State Photo", "ColumbiaState.jpg" });

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AlternateText", "Photo" },
                values: new object[] { "Nashville School of Software Photo", "NSS.jpg" });

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AlternateText", "Photo" },
                values: new object[] { "Bubbas School of Learning Photo", "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AlternateText", "Photo" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AlternateText", "Photo" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AlternateText", "Photo" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AlternateText", "Photo" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AlternateText", "Photo" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AlternateText", "Photo" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AlternateText", "Photo" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AlternateText", "Photo" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AlternateText", "Photo" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "School",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AlternateText", "Photo" },
                values: new object[] { null, null });
        }
    }
}
