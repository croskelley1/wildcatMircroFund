using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wildcatMicroFund.Migrations
{
    public partial class moreForeignKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "ReadyEmail",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_ReadyEmail_UserID",
                table: "ReadyEmail",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_ReadyEmail_AspNetUsers_UserID",
                table: "ReadyEmail",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReadyEmail_AspNetUsers_UserID",
                table: "ReadyEmail");

            migrationBuilder.DropIndex(
                name: "IX_ReadyEmail_UserID",
                table: "ReadyEmail");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "ReadyEmail");
        }
    }
}
