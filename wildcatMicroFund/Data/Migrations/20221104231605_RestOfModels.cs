using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wildcatMicroFund.Data.Migrations
{
    public partial class RestOfModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Availability",
                columns: table => new
                {
                    AvailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    AvailStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AvailEnd = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Availability", x => x.AvailID);
                });

            migrationBuilder.CreateTable(
                name: "Award",
                columns: table => new
                {
                    AwardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppID = table.Column<int>(type: "int", nullable: false),
                    AwardTypeID = table.Column<int>(type: "int", nullable: false),
                    AwardAmount = table.Column<double>(type: "float", nullable: false),
                    AwardDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WasRecieved = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Award", x => x.AwardId);
                });

            migrationBuilder.CreateTable(
                name: "AwardType",
                columns: table => new
                {
                    AwardTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AwardTypeDesc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AwardType", x => x.AwardTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Document",
                columns: table => new
                {
                    DocID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppID = table.Column<int>(type: "int", nullable: false),
                    DocFile = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document", x => x.DocID);
                });

            migrationBuilder.CreateTable(
                name: "DocumentType",
                columns: table => new
                {
                    DocTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocTypeDesc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentType", x => x.DocTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Note",
                columns: table => new
                {
                    NoteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoteContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoteVisibility = table.Column<int>(type: "int", nullable: false),
                    NoteInternal = table.Column<bool>(type: "bit", nullable: false),
                    NoteCreator = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Note", x => x.NoteID);
                });

            migrationBuilder.CreateTable(
                name: "NoteType",
                columns: table => new
                {
                    NoteTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoteTypeDesc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NoteType", x => x.NoteTypeID);
                });

            migrationBuilder.CreateTable(
                name: "PitchEvent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PitchEventDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PitchEvent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PitchEventApplication",
                columns: table => new
                {
                    PitchEvAppID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PitchID = table.Column<int>(type: "int", nullable: false),
                    UserAppID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PitchEventApplication", x => x.PitchEvAppID);
                });

            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SurveyQuestion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuestIsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Response",
                columns: table => new
                {
                    ResponseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SurveyQuestionID = table.Column<int>(type: "int", nullable: false),
                    AppID = table.Column<int>(type: "int", nullable: false),
                    Responses = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Response", x => x.ResponseID);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleTitle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "Score",
                columns: table => new
                {
                    ScoreID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    ScoreValue = table.Column<double>(type: "float", nullable: false),
                    ScoreComments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PitchEvAppID = table.Column<int>(type: "int", nullable: false),
                    ResponseID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Score", x => x.ScoreID);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    StatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusDesc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.StatusID);
                });

            migrationBuilder.CreateTable(
                name: "Survey",
                columns: table => new
                {
                    SurvID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SurveyQID = table.Column<int>(type: "int", nullable: false),
                    AppID = table.Column<int>(type: "int", nullable: false),
                    SurvTypeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Survey", x => x.SurvID);
                });

            migrationBuilder.CreateTable(
                name: "SurveyQuestion",
                columns: table => new
                {
                    SurveyQuestionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestID = table.Column<int>(type: "int", nullable: false),
                    SurvID = table.Column<int>(type: "int", nullable: false),
                    SurveyQuestionDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyQuestion", x => x.SurveyQuestionID);
                });

            migrationBuilder.CreateTable(
                name: "SurveyType",
                columns: table => new
                {
                    SurveyTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SurveyTypeDesc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurveyType", x => x.SurveyTypeID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserFirst = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserLast = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserStreet1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserStreet2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserSpanishPref = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "UserAssignment",
                columns: table => new
                {
                    UserAppID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserAppAssignType = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    AppID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAssignment", x => x.UserAppID);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    URID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.URID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Availability");

            migrationBuilder.DropTable(
                name: "Award");

            migrationBuilder.DropTable(
                name: "AwardType");

            migrationBuilder.DropTable(
                name: "Document");

            migrationBuilder.DropTable(
                name: "DocumentType");

            migrationBuilder.DropTable(
                name: "Note");

            migrationBuilder.DropTable(
                name: "NoteType");

            migrationBuilder.DropTable(
                name: "PitchEvent");

            migrationBuilder.DropTable(
                name: "PitchEventApplication");

            migrationBuilder.DropTable(
                name: "Question");

            migrationBuilder.DropTable(
                name: "Response");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Score");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "Survey");

            migrationBuilder.DropTable(
                name: "SurveyQuestion");

            migrationBuilder.DropTable(
                name: "SurveyType");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "UserAssignment");

            migrationBuilder.DropTable(
                name: "UserRole");
        }
    }
}
