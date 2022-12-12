﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using wildcatMicroFund.Data;

#nullable disable

namespace wildcatMicroFund.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("wildcatMicroFund.Models.Application", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AppStatus")
                        .HasColumnType("int");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Application");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.ApplicationStatus", b =>
                {
                    b.Property<int>("AppStatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AppStatId"), 1L, 1);

                    b.Property<int>("ApplicationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StatusDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<string>("UserID")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AppStatId");

                    b.HasIndex("ApplicationId");

                    b.HasIndex("StatusId");

                    b.ToTable("ApplicationStatus");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.AssignedQuestion", b =>
                {
                    b.Property<int>("AssignedQuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AssignedQuestionId"), 1L, 1);

                    b.Property<DateTime>("AppQuestionDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ApplicationId")
                        .HasColumnType("int");

                    b.Property<int?>("QuestionUseId")
                        .HasColumnType("int");

                    b.HasKey("AssignedQuestionId");

                    b.HasIndex("ApplicationId");

                    b.HasIndex("QuestionUseId");

                    b.ToTable("AssignedQuestion");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.Availability", b =>
                {
                    b.Property<int>("AvailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AvailID"), 1L, 1);

                    b.Property<DateTime>("AvailEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("AvailStart")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("AvailID");

                    b.ToTable("Availability");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.Award", b =>
                {
                    b.Property<int>("AwardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AwardId"), 1L, 1);

                    b.Property<int>("AppID")
                        .HasColumnType("int");

                    b.Property<double>("AwardAmount")
                        .HasColumnType("float");

                    b.Property<DateTime>("AwardDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("AwardTypeID")
                        .HasColumnType("int");

                    b.Property<bool>("WasRecieved")
                        .HasColumnType("bit");

                    b.HasKey("AwardId");

                    b.ToTable("Award");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.AwardType", b =>
                {
                    b.Property<int>("AwardTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AwardTypeId"), 1L, 1);

                    b.Property<string>("AwardTypeDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AwardTypeId");

                    b.ToTable("AwardType");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.Document", b =>
                {
                    b.Property<int>("DocID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DocID"), 1L, 1);

                    b.Property<int>("AppID")
                        .HasColumnType("int");

                    b.Property<string>("DocFile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DocID");

                    b.ToTable("Document");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.DocumentType", b =>
                {
                    b.Property<int>("DocTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DocTypeID"), 1L, 1);

                    b.Property<string>("DocTypeDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DocTypeID");

                    b.ToTable("DocumentType");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.EmailTemplate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("EmailTemplateName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TemplateContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TemplateSubject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EmailTemplate");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.Note", b =>
                {
                    b.Property<int>("NoteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NoteID"), 1L, 1);

                    b.Property<int?>("ApplicationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NoteContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoteCreatorUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("NoteInternal")
                        .HasColumnType("bit");

                    b.Property<int?>("NoteTypeId")
                        .HasColumnType("int");

                    b.Property<int>("NoteVisibility")
                        .HasColumnType("int");

                    b.HasKey("NoteID");

                    b.HasIndex("ApplicationId");

                    b.HasIndex("NoteTypeId");

                    b.ToTable("Note");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.NoteType", b =>
                {
                    b.Property<int>("NoteTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NoteTypeID"), 1L, 1);

                    b.Property<string>("NoteTypeDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NoteTypeID");

                    b.ToTable("NoteType");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.PitchEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("PitchEventDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("PitchEvent");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.PitchEventApplication", b =>
                {
                    b.Property<int>("PitchEvAppID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PitchEvAppID"), 1L, 1);

                    b.Property<int?>("PitchEventId")
                        .HasColumnType("int");

                    b.Property<int?>("UserApplicationAssignmentId")
                        .HasColumnType("int");

                    b.HasKey("PitchEvAppID");

                    b.HasIndex("PitchEventId");

                    b.HasIndex("UserApplicationAssignmentId");

                    b.ToTable("PitchEventApplication");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.QCategory", b =>
                {
                    b.Property<int>("QCategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QCategoryID"), 1L, 1);

                    b.Property<string>("QCategoryDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QCategoryID");

                    b.ToTable("QCategory");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("QuestIsActive")
                        .HasColumnType("bit");

                    b.Property<string>("QuestionSummary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Question");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.QuestionDetail", b =>
                {
                    b.Property<int>("QuestionDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuestionDetailId"), 1L, 1);

                    b.Property<string>("QuestionDetailInfo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("QuestionID")
                        .HasColumnType("int");

                    b.HasKey("QuestionDetailId");

                    b.HasIndex("QuestionID");

                    b.ToTable("QuestionDetail");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.QuestionUse", b =>
                {
                    b.Property<int>("QuestionUseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuestionUseID"), 1L, 1);

                    b.Property<int>("QCategoryID")
                        .HasColumnType("int");

                    b.Property<int>("QuestDisplayOrder")
                        .HasColumnType("int");

                    b.Property<int>("QuestID")
                        .HasColumnType("int");

                    b.Property<bool>("QuestIsScored")
                        .HasColumnType("bit");

                    b.Property<int>("QuestPointValue")
                        .HasColumnType("int");

                    b.Property<bool>("QuestUseIsActive")
                        .HasColumnType("bit");

                    b.HasKey("QuestionUseID");

                    b.HasIndex("QCategoryID");

                    b.HasIndex("QuestID");

                    b.ToTable("QuestionUse");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.ReadyEmail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmailTemplateId")
                        .HasColumnType("int");

                    b.Property<string>("ReadyEmailContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReadyEmailEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReadyEmailSubject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("EmailTemplateId");

                    b.HasIndex("UserID");

                    b.ToTable("ReadyEmail");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.Response", b =>
                {
                    b.Property<int>("ResponseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ResponseID"), 1L, 1);

                    b.Property<int?>("AssignedQuestionId")
                        .HasColumnType("int");

                    b.Property<string>("Responses")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("applicationId")
                        .HasColumnType("int");

                    b.HasKey("ResponseID");

                    b.HasIndex("AssignedQuestionId");

                    b.ToTable("Response");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.Score", b =>
                {
                    b.Property<int>("ScoreID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ScoreID"), 1L, 1);

                    b.Property<int>("AssignedQuestionId")
                        .HasColumnType("int");

                    b.Property<string>("ScoreComments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ScoreValue")
                        .HasColumnType("int");

                    b.Property<string>("UserID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("applicationId")
                        .HasColumnType("int");

                    b.HasKey("ScoreID");

                    b.HasIndex("AssignedQuestionId");

                    b.ToTable("Score");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.Status", b =>
                {
                    b.Property<int>("StatusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StatusID"), 1L, 1);

                    b.Property<string>("StatusDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StatusID");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.UserApplicationAssignmentType", b =>
                {
                    b.Property<int>("UserApplicationAssignmentTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserApplicationAssignmentTypeId"), 1L, 1);

                    b.Property<string>("UserApplicationAssignmentDesc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserApplicationAssignmentTypeId");

                    b.ToTable("UserApplicationAssignmentType");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.UserAssignment", b =>
                {
                    b.Property<int>("UserAssignmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserAssignmentID"), 1L, 1);

                    b.Property<int?>("ApplicationId")
                        .HasColumnType("int");

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("UserApplicationAssignmentTypeId")
                        .HasColumnType("int");

                    b.HasKey("UserAssignmentID");

                    b.HasIndex("ApplicationId");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("UserApplicationAssignmentTypeId");

                    b.ToTable("UserAssignment");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("wildcatMicroFund.Models.ApplicationStatus", b =>
                {
                    b.HasOne("wildcatMicroFund.Models.Application", "Application")
                        .WithMany()
                        .HasForeignKey("ApplicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("wildcatMicroFund.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Application");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.AssignedQuestion", b =>
                {
                    b.HasOne("wildcatMicroFund.Models.Application", "Application")
                        .WithMany()
                        .HasForeignKey("ApplicationId");

                    b.HasOne("wildcatMicroFund.Models.QuestionUse", "QuestionUse")
                        .WithMany()
                        .HasForeignKey("QuestionUseId");

                    b.Navigation("Application");

                    b.Navigation("QuestionUse");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.Note", b =>
                {
                    b.HasOne("wildcatMicroFund.Models.Application", "Application")
                        .WithMany()
                        .HasForeignKey("ApplicationId");

                    b.HasOne("wildcatMicroFund.Models.NoteType", "NoteType")
                        .WithMany()
                        .HasForeignKey("NoteTypeId");

                    b.Navigation("Application");

                    b.Navigation("NoteType");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.PitchEventApplication", b =>
                {
                    b.HasOne("wildcatMicroFund.Models.PitchEvent", "PitchEvent")
                        .WithMany()
                        .HasForeignKey("PitchEventId");

                    b.HasOne("wildcatMicroFund.Models.UserAssignment", "UserAssignment")
                        .WithMany()
                        .HasForeignKey("UserApplicationAssignmentId");

                    b.Navigation("PitchEvent");

                    b.Navigation("UserAssignment");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.QuestionDetail", b =>
                {
                    b.HasOne("wildcatMicroFund.Models.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionID");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.QuestionUse", b =>
                {
                    b.HasOne("wildcatMicroFund.Models.QCategory", "QCategory")
                        .WithMany()
                        .HasForeignKey("QCategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("wildcatMicroFund.Models.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("QCategory");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.ReadyEmail", b =>
                {
                    b.HasOne("wildcatMicroFund.Models.EmailTemplate", "EmailTemplate")
                        .WithMany()
                        .HasForeignKey("EmailTemplateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("wildcatMicroFund.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmailTemplate");

                    b.Navigation("User");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.Response", b =>
                {
                    b.HasOne("wildcatMicroFund.Models.AssignedQuestion", "AssignedQuestion")
                        .WithMany()
                        .HasForeignKey("AssignedQuestionId");

                    b.Navigation("AssignedQuestion");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.Score", b =>
                {
                    b.HasOne("wildcatMicroFund.Models.AssignedQuestion", "AssignedQuestion")
                        .WithMany()
                        .HasForeignKey("AssignedQuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AssignedQuestion");
                });

            modelBuilder.Entity("wildcatMicroFund.Models.UserAssignment", b =>
                {
                    b.HasOne("wildcatMicroFund.Models.Application", "Application")
                        .WithMany()
                        .HasForeignKey("ApplicationId");

                    b.HasOne("wildcatMicroFund.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("wildcatMicroFund.Models.UserApplicationAssignmentType", "UserApplicationAssignmentType")
                        .WithMany()
                        .HasForeignKey("UserApplicationAssignmentTypeId");

                    b.Navigation("Application");

                    b.Navigation("ApplicationUser");

                    b.Navigation("UserApplicationAssignmentType");
                });
#pragma warning restore 612, 618
        }
    }
}
