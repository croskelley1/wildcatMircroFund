using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wildcatMicroFund.Data.Migrations
{
    public partial class AppStatFKUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppID",
                table: "ApplicationStatus");

            migrationBuilder.DropColumn(
                name: "StatID",
                table: "ApplicationStatus");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppID",
                table: "ApplicationStatus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatID",
                table: "ApplicationStatus",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
