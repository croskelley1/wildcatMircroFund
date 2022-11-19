using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wildcatMicroFund.Data.Migrations
{
    public partial class QuestionAndQuestionDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuestDesc",
                table: "Question");

            migrationBuilder.RenameColumn(
                name: "SurveyQuestion",
                table: "Question",
                newName: "QuestionSummary");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "QuestionSummary",
                table: "Question",
                newName: "SurveyQuestion");

            migrationBuilder.AddColumn<string>(
                name: "QuestDesc",
                table: "Question",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
