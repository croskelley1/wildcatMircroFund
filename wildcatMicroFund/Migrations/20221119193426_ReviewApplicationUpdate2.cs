using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wildcatMicroFund.Data.Migrations
{
    public partial class ReviewApplicationUpdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReviewApplication_Status_StatusId",
                table: "ReviewApplication");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "ReviewApplication");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "ReviewApplication");

            migrationBuilder.AlterColumn<int>(
                name: "StatusId",
                table: "ReviewApplication",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_ReviewApplication_Status_StatusId",
                table: "ReviewApplication",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "StatusID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReviewApplication_ApplicationStatus_ApplicationStatusId",
                table: "ReviewApplication");

            migrationBuilder.DropForeignKey(
                name: "FK_ReviewApplication_Status_StatusId",
                table: "ReviewApplication");

            migrationBuilder.DropIndex(
                name: "IX_ReviewApplication_ApplicationStatusId",
                table: "ReviewApplication");

            migrationBuilder.AlterColumn<int>(
                name: "StatusId",
                table: "ReviewApplication",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "ReviewApplication",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ReviewApplication",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ReviewApplication_Status_StatusId",
                table: "ReviewApplication",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "StatusID");
        }
    }
}
