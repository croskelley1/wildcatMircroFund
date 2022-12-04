using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wildcatMicroFund.Migrations
{
    public partial class EmailSubject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ReadyEmailEmail",
                table: "ReadyEmail",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReadyEmailSubject",
                table: "ReadyEmail",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TemplateSubject",
                table: "EmailTemplate",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReadyEmailEmail",
                table: "ReadyEmail");

            migrationBuilder.DropColumn(
                name: "ReadyEmailSubject",
                table: "ReadyEmail");

            migrationBuilder.DropColumn(
                name: "TemplateSubject",
                table: "EmailTemplate");
        }
    }
}
