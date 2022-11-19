using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wildcatMicroFund.Data.Migrations
{
    public partial class QUestionUseAndQCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QCategory",
                columns: table => new
                {
                    QCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QCategoryDesc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QCategory", x => x.QCategoryID);
                });

            migrationBuilder.CreateTable(
                name: "QuestionUse",
                columns: table => new
                {
                    QuestionUseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestPointValue = table.Column<int>(type: "int", nullable: false),
                    QuestID = table.Column<int>(type: "int", nullable: true),
                    QCategoryID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionUse", x => x.QuestionUseID);
                    table.ForeignKey(
                        name: "FK_QuestionUse_QCategory_QCategoryID",
                        column: x => x.QCategoryID,
                        principalTable: "QCategory",
                        principalColumn: "QCategoryID");
                    table.ForeignKey(
                        name: "FK_QuestionUse_Question_QuestID",
                        column: x => x.QuestID,
                        principalTable: "Question",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_QuestionUse_QCategoryID",
                table: "QuestionUse",
                column: "QCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionUse_QuestID",
                table: "QuestionUse",
                column: "QuestID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuestionUse");

            migrationBuilder.DropTable(
                name: "QCategory");
        }
    }
}
