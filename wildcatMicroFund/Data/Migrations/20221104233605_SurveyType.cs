using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wildcatMicroFund.Data.Migrations
{
    public partial class SurveyType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SurvTypeID",
                table: "Survey",
                newName: "SurveyTypeID");

            migrationBuilder.RenameColumn(
                name: "SurvID",
                table: "Survey",
                newName: "SurveyID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SurveyTypeID",
                table: "Survey",
                newName: "SurvTypeID");

            migrationBuilder.RenameColumn(
                name: "SurveyID",
                table: "Survey",
                newName: "SurvID");
        }
    }
}
