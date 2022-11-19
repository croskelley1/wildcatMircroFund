using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wildcatMicroFund.Data.Migrations
{
    public partial class AppStatusFks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StatusID",
                table: "ApplicationStatus",
                newName: "StatusId");

            migrationBuilder.AlterColumn<int>(
                name: "StatusId",
                table: "ApplicationStatus",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ApplicationId",
                table: "ApplicationStatus",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StatID",
                table: "ApplicationStatus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationStatus_ApplicationId",
                table: "ApplicationStatus",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationStatus_StatusId",
                table: "ApplicationStatus",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationStatus_Application_ApplicationId",
                table: "ApplicationStatus",
                column: "ApplicationId",
                principalTable: "Application",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationStatus_Status_StatusId",
                table: "ApplicationStatus",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "StatusID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationStatus_Application_ApplicationId",
                table: "ApplicationStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationStatus_Status_StatusId",
                table: "ApplicationStatus");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationStatus_ApplicationId",
                table: "ApplicationStatus");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationStatus_StatusId",
                table: "ApplicationStatus");

            migrationBuilder.DropColumn(
                name: "ApplicationId",
                table: "ApplicationStatus");

            migrationBuilder.DropColumn(
                name: "StatID",
                table: "ApplicationStatus");

            migrationBuilder.RenameColumn(
                name: "StatusId",
                table: "ApplicationStatus",
                newName: "StatusID");

            migrationBuilder.AlterColumn<int>(
                name: "StatusID",
                table: "ApplicationStatus",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
