using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wildcatMicroFund.Migrations
{
    public partial class AssignedQuestionScoreUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssignedQuestion_Question_QuestionId",
                table: "AssignedQuestion");

            migrationBuilder.DropForeignKey(
                name: "FK_Score_PitchEventApplication_PitchEventApplicationId",
                table: "Score");

            migrationBuilder.DropForeignKey(
                name: "FK_Score_Response_ResponseId",
                table: "Score");

            migrationBuilder.DropIndex(
                name: "IX_Score_PitchEventApplicationId",
                table: "Score");

            migrationBuilder.DropColumn(
                name: "PitchEventApplicationId",
                table: "Score");

            migrationBuilder.RenameColumn(
                name: "ResponseId",
                table: "Score",
                newName: "AssignedQuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_Score_ResponseId",
                table: "Score",
                newName: "IX_Score_AssignedQuestionId");

            migrationBuilder.RenameColumn(
                name: "QuestionId",
                table: "AssignedQuestion",
                newName: "QuestionUseId");

            migrationBuilder.RenameIndex(
                name: "IX_AssignedQuestion_QuestionId",
                table: "AssignedQuestion",
                newName: "IX_AssignedQuestion_QuestionUseId");

            migrationBuilder.AlterColumn<int>(
                name: "ScoreValue",
                table: "Score",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddForeignKey(
                name: "FK_AssignedQuestion_QuestionUse_QuestionUseId",
                table: "AssignedQuestion",
                column: "QuestionUseId",
                principalTable: "QuestionUse",
                principalColumn: "QuestionUseID");

            migrationBuilder.AddForeignKey(
                name: "FK_Score_AssignedQuestion_AssignedQuestionId",
                table: "Score",
                column: "AssignedQuestionId",
                principalTable: "AssignedQuestion",
                principalColumn: "AssignedQuestionId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AssignedQuestion_QuestionUse_QuestionUseId",
                table: "AssignedQuestion");

            migrationBuilder.DropForeignKey(
                name: "FK_Score_AssignedQuestion_AssignedQuestionId",
                table: "Score");

            migrationBuilder.RenameColumn(
                name: "AssignedQuestionId",
                table: "Score",
                newName: "ResponseId");

            migrationBuilder.RenameIndex(
                name: "IX_Score_AssignedQuestionId",
                table: "Score",
                newName: "IX_Score_ResponseId");

            migrationBuilder.RenameColumn(
                name: "QuestionUseId",
                table: "AssignedQuestion",
                newName: "QuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_AssignedQuestion_QuestionUseId",
                table: "AssignedQuestion",
                newName: "IX_AssignedQuestion_QuestionId");

            migrationBuilder.AlterColumn<double>(
                name: "ScoreValue",
                table: "Score",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "PitchEventApplicationId",
                table: "Score",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Score_PitchEventApplicationId",
                table: "Score",
                column: "PitchEventApplicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_AssignedQuestion_Question_QuestionId",
                table: "AssignedQuestion",
                column: "QuestionId",
                principalTable: "Question",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Score_PitchEventApplication_PitchEventApplicationId",
                table: "Score",
                column: "PitchEventApplicationId",
                principalTable: "PitchEventApplication",
                principalColumn: "PitchEvAppID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Score_Response_ResponseId",
                table: "Score",
                column: "ResponseId",
                principalTable: "Response",
                principalColumn: "ResponseID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
