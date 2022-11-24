using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wildcatMicroFund.Data.Migrations
{
    public partial class pkupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationStatus_Application_ApplicationId",
                table: "ApplicationStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationStatus_Status_StatusId",
                table: "ApplicationStatus");

            migrationBuilder.RenameColumn(
                name: "AppStat",
                table: "ApplicationStatus",
                newName: "AppStatId");

            migrationBuilder.AlterColumn<int>(
                name: "StatusId",
                table: "ApplicationStatus",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationId",
                table: "ApplicationStatus",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationStatus_Application_ApplicationId",
                table: "ApplicationStatus",
                column: "ApplicationId",
                principalTable: "Application",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationStatus_Status_StatusId",
                table: "ApplicationStatus",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "StatusID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationStatus_Application_ApplicationId",
                table: "ApplicationStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationStatus_Status_StatusId",
                table: "ApplicationStatus");

            migrationBuilder.RenameColumn(
                name: "AppStatId",
                table: "ApplicationStatus",
                newName: "AppStat");

            migrationBuilder.AlterColumn<int>(
                name: "StatusId",
                table: "ApplicationStatus",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationId",
                table: "ApplicationStatus",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
    }
}
