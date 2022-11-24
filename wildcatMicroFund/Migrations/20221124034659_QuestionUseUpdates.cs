using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wildcatMicroFund.Migrations
{
    public partial class QuestionUseUpdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuestDisplayOrder",
                table: "QuestionUse",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "QuestIsScored",
                table: "QuestionUse",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "QuestUseIsActive",
                table: "QuestionUse",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuestDisplayOrder",
                table: "QuestionUse");

            migrationBuilder.DropColumn(
                name: "QuestIsScored",
                table: "QuestionUse");

            migrationBuilder.DropColumn(
                name: "QuestUseIsActive",
                table: "QuestionUse");
        }
    }
}
