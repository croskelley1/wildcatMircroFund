using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wildcatMicroFund.Migrations
{
    public partial class NoteUpdates2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ApplicationId",
                table: "Note",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Note_ApplicationId",
                table: "Note",
                column: "ApplicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Note_Application_ApplicationId",
                table: "Note",
                column: "ApplicationId",
                principalTable: "Application",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Note_Application_ApplicationId",
                table: "Note");

            migrationBuilder.DropIndex(
                name: "IX_Note_ApplicationId",
                table: "Note");

            migrationBuilder.DropColumn(
                name: "ApplicationId",
                table: "Note");
        }
    }
}
