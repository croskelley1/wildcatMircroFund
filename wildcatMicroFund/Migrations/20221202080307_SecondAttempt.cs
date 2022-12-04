using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wildcatMicroFund.Migrations
{
    public partial class SecondAttempt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmailTemplateId",
                table: "ReadyEmail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ReadyEmail_EmailTemplateId",
                table: "ReadyEmail",
                column: "EmailTemplateId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReadyEmail_EmailTemplate_EmailTemplateId",
                table: "ReadyEmail",
                column: "EmailTemplateId",
                principalTable: "EmailTemplate",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReadyEmail_EmailTemplate_EmailTemplateId",
                table: "ReadyEmail");

            migrationBuilder.DropIndex(
                name: "IX_ReadyEmail_EmailTemplateId",
                table: "ReadyEmail");

            migrationBuilder.DropColumn(
                name: "EmailTemplateId",
                table: "ReadyEmail");
        }
    }
}
