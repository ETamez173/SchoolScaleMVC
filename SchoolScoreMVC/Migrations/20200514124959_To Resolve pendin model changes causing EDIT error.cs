using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolScoreMVC.Migrations
{
    public partial class ToResolvependinmodelchangescausingEDITerror : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Loan_DegreeSchoolId",
                table: "Loan");

            migrationBuilder.CreateIndex(
                name: "IX_Loan_DegreeSchoolId",
                table: "Loan",
                column: "DegreeSchoolId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Loan_DegreeSchoolId",
                table: "Loan");

            migrationBuilder.CreateIndex(
                name: "IX_Loan_DegreeSchoolId",
                table: "Loan",
                column: "DegreeSchoolId");
        }
    }
}
