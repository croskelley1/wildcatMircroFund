using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wildcatMicroFund.Migrations
{
    public partial class NoteUpdates3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NoteCreator",
                table: "Note");

            migrationBuilder.AddColumn<string>(
                name: "NoteCreatorUserId",
                table: "Note",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NoteCreatorUserId",
                table: "Note");

            migrationBuilder.AddColumn<int>(
                name: "NoteCreator",
                table: "Note",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
