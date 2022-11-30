﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using wildcatMicroFund.Interfaces;
using wildcatMicroFund.Models;
namespace wildcatMicroFund.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Application> Application { get; set; }
        public DbSet<ApplicationStatus> ApplicationStatus { get; set; }
        public DbSet<Availability> Availability { get; set; }
        public DbSet<Award> Award { get; set; }
        public DbSet<AwardType> AwardType { get; set; }
        public DbSet<Document> Document { get; set; }
        public DbSet<DocumentType> DocumentType { get; set; }
        public DbSet<Note> Note { get; set; }
        public DbSet<NoteType> NoteType { get; set; }
        public DbSet<PitchEvent> PitchEvent { get; set; }
        public DbSet<PitchEventApplication> PitchEventApplication { get; set; }
        public DbSet<QCategory> QCategory { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<QuestionDetail> QuestionDetail { get; set; }
        public DbSet<QuestionUse> QuestionUse { get; set; }
        public DbSet<Response> Response { get; set; }
        public DbSet<Score> Score { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<UserApplicationAssignmentType> UserApplicationAssignmentType { get; set; }
        public DbSet<UserAssignment> UserAssignment { get; set; }
        public DbSet<EmailTemplate> EmailTemplate { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }


    }
}