using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wildcatMicroFund.Migrations
{
    public partial class ResetDec6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Application",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AppStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Application", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StreetAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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
                name: "EmailTemplate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmailTemplateName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TemplateContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TemplateSubject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailTemplate", x => x.Id);
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
                name: "Question",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionSummary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuestIsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.Id);
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
                name: "UserApplicationAssignmentType",
                columns: table => new
                {
                    UserApplicationAssignmentTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserApplicationAssignmentDesc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserApplicationAssignmentType", x => x.UserApplicationAssignmentTypeId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReadyEmail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReadyEmailEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReadyEmailSubject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReadyEmailContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailTemplateId = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReadyEmail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReadyEmail_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReadyEmail_EmailTemplate_EmailTemplateId",
                        column: x => x.EmailTemplateId,
                        principalTable: "EmailTemplate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    NoteCreatorUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApplicationId = table.Column<int>(type: "int", nullable: true),
                    NoteTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Note", x => x.NoteID);
                    table.ForeignKey(
                        name: "FK_Note_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Application",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Note_NoteType_NoteTypeId",
                        column: x => x.NoteTypeId,
                        principalTable: "NoteType",
                        principalColumn: "NoteTypeID");
                });

            migrationBuilder.CreateTable(
                name: "AssignedQuestion",
                columns: table => new
                {
                    AssignedQuestionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppQuestionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: true),
                    ApplicationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssignedQuestion", x => x.AssignedQuestionId);
                    table.ForeignKey(
                        name: "FK_AssignedQuestion_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Application",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AssignedQuestion_Question_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Question",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "QuestionDetail",
                columns: table => new
                {
                    QuestionDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionDetailInfo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuestionID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionDetail", x => x.QuestionDetailId);
                    table.ForeignKey(
                        name: "FK_QuestionDetail_Question_QuestionID",
                        column: x => x.QuestionID,
                        principalTable: "Question",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "QuestionUse",
                columns: table => new
                {
                    QuestionUseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestID = table.Column<int>(type: "int", nullable: false),
                    QCategoryID = table.Column<int>(type: "int", nullable: false),
                    QuestDisplayOrder = table.Column<int>(type: "int", nullable: false),
                    QuestIsScored = table.Column<bool>(type: "bit", nullable: false),
                    QuestUseIsActive = table.Column<bool>(type: "bit", nullable: false),
                    QuestPointValue = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionUse", x => x.QuestionUseID);
                    table.ForeignKey(
                        name: "FK_QuestionUse_QCategory_QCategoryID",
                        column: x => x.QCategoryID,
                        principalTable: "QCategory",
                        principalColumn: "QCategoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuestionUse_Question_QuestID",
                        column: x => x.QuestID,
                        principalTable: "Question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationStatus",
                columns: table => new
                {
                    AppStatId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    StatusDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationStatus", x => x.AppStatId);
                    table.ForeignKey(
                        name: "FK_ApplicationStatus_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Application",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationStatus_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "StatusID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAssignment",
                columns: table => new
                {
                    UserAssignmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserApplicationAssignmentTypeId = table.Column<int>(type: "int", nullable: true),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ApplicationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAssignment", x => x.UserAssignmentID);
                    table.ForeignKey(
                        name: "FK_UserAssignment_Application_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Application",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserAssignment_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserAssignment_UserApplicationAssignmentType_UserApplicationAssignmentTypeId",
                        column: x => x.UserApplicationAssignmentTypeId,
                        principalTable: "UserApplicationAssignmentType",
                        principalColumn: "UserApplicationAssignmentTypeId");
                });

            migrationBuilder.CreateTable(
                name: "Response",
                columns: table => new
                {
                    ResponseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Responses = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssignedQuestionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Response", x => x.ResponseID);
                    table.ForeignKey(
                        name: "FK_Response_AssignedQuestion_AssignedQuestionId",
                        column: x => x.AssignedQuestionId,
                        principalTable: "AssignedQuestion",
                        principalColumn: "AssignedQuestionId");
                });

            migrationBuilder.CreateTable(
                name: "PitchEventApplication",
                columns: table => new
                {
                    PitchEvAppID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PitchEventId = table.Column<int>(type: "int", nullable: true),
                    UserApplicationAssignmentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PitchEventApplication", x => x.PitchEvAppID);
                    table.ForeignKey(
                        name: "FK_PitchEventApplication_PitchEvent_PitchEventId",
                        column: x => x.PitchEventId,
                        principalTable: "PitchEvent",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PitchEventApplication_UserAssignment_UserApplicationAssignmentId",
                        column: x => x.UserApplicationAssignmentId,
                        principalTable: "UserAssignment",
                        principalColumn: "UserAssignmentID");
                });

            migrationBuilder.CreateTable(
                name: "Score",
                columns: table => new
                {
                    ScoreID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScoreValue = table.Column<double>(type: "float", nullable: false),
                    ScoreComments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PitchEventApplicationId = table.Column<int>(type: "int", nullable: false),
                    ResponseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Score", x => x.ScoreID);
                    table.ForeignKey(
                        name: "FK_Score_PitchEventApplication_PitchEventApplicationId",
                        column: x => x.PitchEventApplicationId,
                        principalTable: "PitchEventApplication",
                        principalColumn: "PitchEvAppID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Score_Response_ResponseId",
                        column: x => x.ResponseId,
                        principalTable: "Response",
                        principalColumn: "ResponseID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationStatus_ApplicationId",
                table: "ApplicationStatus",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationStatus_StatusId",
                table: "ApplicationStatus",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AssignedQuestion_ApplicationId",
                table: "AssignedQuestion",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_AssignedQuestion_QuestionId",
                table: "AssignedQuestion",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Note_ApplicationId",
                table: "Note",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Note_NoteTypeId",
                table: "Note",
                column: "NoteTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PitchEventApplication_PitchEventId",
                table: "PitchEventApplication",
                column: "PitchEventId");

            migrationBuilder.CreateIndex(
                name: "IX_PitchEventApplication_UserApplicationAssignmentId",
                table: "PitchEventApplication",
                column: "UserApplicationAssignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionDetail_QuestionID",
                table: "QuestionDetail",
                column: "QuestionID");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionUse_QCategoryID",
                table: "QuestionUse",
                column: "QCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionUse_QuestID",
                table: "QuestionUse",
                column: "QuestID");

            migrationBuilder.CreateIndex(
                name: "IX_ReadyEmail_EmailTemplateId",
                table: "ReadyEmail",
                column: "EmailTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_ReadyEmail_UserID",
                table: "ReadyEmail",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Response_AssignedQuestionId",
                table: "Response",
                column: "AssignedQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Score_PitchEventApplicationId",
                table: "Score",
                column: "PitchEventApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Score_ResponseId",
                table: "Score",
                column: "ResponseId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAssignment_ApplicationId",
                table: "UserAssignment",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAssignment_ApplicationUserId",
                table: "UserAssignment",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAssignment_UserApplicationAssignmentTypeId",
                table: "UserAssignment",
                column: "UserApplicationAssignmentTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationStatus");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

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
                name: "QuestionDetail");

            migrationBuilder.DropTable(
                name: "QuestionUse");

            migrationBuilder.DropTable(
                name: "ReadyEmail");

            migrationBuilder.DropTable(
                name: "Score");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "NoteType");

            migrationBuilder.DropTable(
                name: "QCategory");

            migrationBuilder.DropTable(
                name: "EmailTemplate");

            migrationBuilder.DropTable(
                name: "PitchEventApplication");

            migrationBuilder.DropTable(
                name: "Response");

            migrationBuilder.DropTable(
                name: "PitchEvent");

            migrationBuilder.DropTable(
                name: "UserAssignment");

            migrationBuilder.DropTable(
                name: "AssignedQuestion");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "UserApplicationAssignmentType");

            migrationBuilder.DropTable(
                name: "Application");

            migrationBuilder.DropTable(
                name: "Question");
        }
    }
}
