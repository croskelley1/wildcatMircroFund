using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wildcatMicroFund.Migrations
{
    public partial class failedTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReadyEmail_AspNetUsers_UserId",
                table: "ReadyEmail");

            migrationBuilder.DropForeignKey(
                name: "FK_ReadyEmail_EmailTemplate_EmailTemplateId",
                table: "ReadyEmail");

            migrationBuilder.DropIndex(
                name: "IX_ReadyEmail_EmailTemplateId",
                table: "ReadyEmail");

            migrationBuilder.DropIndex(
                name: "IX_ReadyEmail_UserId",
                table: "ReadyEmail");

            migrationBuilder.DropColumn(
                name: "EmailTemplateId",
                table: "ReadyEmail");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ReadyEmail");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "EmailTemplateId",
                table: "ReadyEmail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "ReadyEmail",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ReadyEmail_EmailTemplateId",
                table: "ReadyEmail",
                column: "EmailTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_ReadyEmail_UserId",
                table: "ReadyEmail",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReadyEmail_AspNetUsers_UserId",
                table: "ReadyEmail",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ReadyEmail_EmailTemplate_EmailTemplateId",
                table: "ReadyEmail",
                column: "EmailTemplateId",
                principalTable: "EmailTemplate",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
