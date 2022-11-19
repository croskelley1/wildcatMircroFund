using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wildcatMicroFund.Data.Migrations
{
    public partial class ReviewApplication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReviewApplication_ApplicationStatus_ApplicationStatusId",
                table: "ReviewApplication");

            migrationBuilder.DropIndex(
                name: "IX_ReviewApplication_ApplicationStatusId",
                table: "ReviewApplication");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ReviewApplication",
                newName: "CompanyName");

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "ReviewApplication",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ReviewApplication_StatusId",
                table: "ReviewApplication",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReviewApplication_Status_StatusId",
                table: "ReviewApplication",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "StatusID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReviewApplication_Status_StatusId",
                table: "ReviewApplication");

            migrationBuilder.DropIndex(
                name: "IX_ReviewApplication_StatusId",
                table: "ReviewApplication");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "ReviewApplication");

            migrationBuilder.RenameColumn(
                name: "CompanyName",
                table: "ReviewApplication",
                newName: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewApplication_ApplicationStatusId",
                table: "ReviewApplication",
                column: "ApplicationStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReviewApplication_ApplicationStatus_ApplicationStatusId",
                table: "ReviewApplication",
                column: "ApplicationStatusId",
                principalTable: "ApplicationStatus",
                principalColumn: "AppStat",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
