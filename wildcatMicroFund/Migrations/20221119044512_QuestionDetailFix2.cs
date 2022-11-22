using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wildcatMicroFund.Data.Migrations
{
    public partial class QuestionDetailFix2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionDetail_Status_StatusId",
                table: "QuestionDetail");

            migrationBuilder.RenameColumn(
                name: "StatusId",
                table: "QuestionDetail",
                newName: "QuestionID");

            migrationBuilder.RenameIndex(
                name: "IX_QuestionDetail_StatusId",
                table: "QuestionDetail",
                newName: "IX_QuestionDetail_QuestionID");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionDetail_Question_QuestionID",
                table: "QuestionDetail",
                column: "QuestionID",
                principalTable: "Question",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionDetail_Question_QuestionID",
                table: "QuestionDetail");

            migrationBuilder.RenameColumn(
                name: "QuestionID",
                table: "QuestionDetail",
                newName: "StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_QuestionDetail_QuestionID",
                table: "QuestionDetail",
                newName: "IX_QuestionDetail_StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionDetail_Status_StatusId",
                table: "QuestionDetail",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "StatusID");
        }
    }
}
