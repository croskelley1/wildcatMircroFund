using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wildcatMicroFund.Migrations
{
    public partial class removedExtraCol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "ReadyEmail");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "ReadyEmail");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "ReadyEmail");

            migrationBuilder.DropColumn(
                name: "TemplateName",
                table: "ReadyEmail");

            migrationBuilder.DropColumn(
                name: "template",
                table: "ReadyEmail");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "ReadyEmail",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "ReadyEmail",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "ReadyEmail",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TemplateName",
                table: "ReadyEmail",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "template",
                table: "ReadyEmail",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
