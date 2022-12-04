using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wildcatMicroFund.Migrations
{
    public partial class NoteUpdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Note",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "NoteTypeId",
                table: "Note",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Note_NoteTypeId",
                table: "Note",
                column: "NoteTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Note_NoteType_NoteTypeId",
                table: "Note",
                column: "NoteTypeId",
                principalTable: "NoteType",
                principalColumn: "NoteTypeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Note_NoteType_NoteTypeId",
                table: "Note");

            migrationBuilder.DropIndex(
                name: "IX_Note_NoteTypeId",
                table: "Note");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Note");

            migrationBuilder.DropColumn(
                name: "NoteTypeId",
                table: "Note");
        }
    }
}
