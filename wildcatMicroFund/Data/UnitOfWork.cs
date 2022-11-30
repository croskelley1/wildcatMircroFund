﻿using wildcatMicroFund.Interfaces;
using wildcatMicroFund.Models;

namespace wildcatMicroFund.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        //Dependency Injection of the DB Service

        private readonly ApplicationDbContext _dbContext;

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        private IRepository<Application> _Application;

        public IRepository<Application> Application
        {
            get
            {
                _Application ??= new Repository<Application>(_dbContext);
                return _Application;
            }
        }

        private IRepository<ApplicationStatus> _ApplicationStatus;

        public IRepository<ApplicationStatus> ApplicationStatus
        {
            get
            {
                _ApplicationStatus ??= new Repository<ApplicationStatus>(_dbContext);
                return _ApplicationStatus;
            }
        }     

        private IRepository<Availability> _Availability;

        public IRepository<Availability> Availability
        {
            get
            {
                _Availability ??= new Repository<Availability>(_dbContext);
                return _Availability;
            }
        }

        private IRepository<Award> _Award;

        public IRepository<Award> Award
        {
            get
            {
                _Award ??= new Repository<Award>(_dbContext);
                return _Award;
            }
        }

        private IRepository<AwardType> _AwardType;
        public IRepository<AwardType> AwardType
        {
            get
            {
                _AwardType ??= new Repository<AwardType>(_dbContext);
                return _AwardType;
            }
        }

        private IRepository<Document> _Document;
        public IRepository<Document> Document
        {
            get
            {
                _Document ??= new Repository<Document>(_dbContext);
                return _Document;
            }
        }

        private IRepository<DocumentType> _DocumentType;
        public IRepository<DocumentType> DocumentType
        {
            get
            {
                _DocumentType ??= new Repository<DocumentType>(_dbContext);
                return _DocumentType;
            }
        }

        private IRepository<Note> _Note;
        public IRepository<Note> Note
        {
            get
            {
                _Note ??= new Repository<Note>(_dbContext);
                return _Note;
            }
        }

        private IRepository<NoteType> _NoteType;
        public IRepository<NoteType> NoteType
        {
            get
            {
                _NoteType ??= new Repository<NoteType>(_dbContext);
                return _NoteType;
            }
        }

        private IRepository<PitchEvent> _PitchEvent;
        public IRepository<PitchEvent> PitchEvent
        {
            get
            {
                _PitchEvent ??= new Repository<PitchEvent>(_dbContext);
                return _PitchEvent;
            }
        }

        private IRepository<PitchEventApplication> _PitchEventApplication;
        public IRepository<PitchEventApplication> PitchEventApplication
        {
            get
            {
                _PitchEventApplication ??= new Repository<PitchEventApplication>(_dbContext);
                return _PitchEventApplication;
            }
        }

        private IRepository<QCategory> _QCategory;
        public IRepository<QCategory> QCategory
        {
            get
            {
                _QCategory ??= new Repository<QCategory>(_dbContext);
                return _QCategory;
            }
        }

        private IRepository<Question> _Question;
        public IRepository<Question> Question
        {
            get
            {
                _Question ??= new Repository<Question>(_dbContext);
                return _Question;
            }
        }

        private IRepository<QuestionDetail> _QuestionDetail;
        public IRepository<QuestionDetail> QuestionDetail
        {
            get
            {
                _QuestionDetail ??= new Repository<QuestionDetail>(_dbContext);
                return _QuestionDetail;
            }
        }

        private IRepository<QuestionUse> _QuestionUse;
        public IRepository<QuestionUse> QuestionUse
        {
            get
            {
                _QuestionUse ??= new Repository<QuestionUse>(_dbContext);
                return _QuestionUse;
            }
        }

        private IRepository<Response> _Response;
        public IRepository<Response> Response
        {
            get
            {
                _Response ??= new Repository<Response>(_dbContext);
                return _Response;
            }
        }

        private IRepository<Score> _Score;
        public IRepository<Score> Score
        {
            get
            {
                _Score ??= new Repository<Score>(_dbContext);
                return _Score;
            }
        }

        private IRepository<Status> _Status;
        public IRepository<Status> Status
        {
            get
            {
                _Status ??= new Repository<Status>(_dbContext);
                return _Status;
            }
        }              

        private IRepository<UserAssignment> _UserAssignment;
        public IRepository<UserAssignment> UserAssignment
        {
            get
            {
                _UserAssignment ??= new Repository<UserAssignment>(_dbContext);
                return _UserAssignment;
            }
        }       

        private IRepository<EmailTemplate> _EmailTemplate;

        public IRepository<EmailTemplate> EmailTemplate
        {
            get
            {

                _EmailTemplate ??= new Repository<EmailTemplate>(_dbContext);
                return _EmailTemplate;
            }
        }
        private IRepository<ApplicationUser> _ApplicationUser;
        public IRepository<ApplicationUser> ApplicationUser 
        {
            get 
            {
                _ApplicationUser ??= new Repository<ApplicationUser>(_dbContext);
                return _ApplicationUser;
            }
        }
        private IRepository<UserApplicationAssignmentType> _UserApplicationAssignmentType;
        public IRepository<UserApplicationAssignmentType> UserApplicationAssignmentType
        {
            get
            {
                _UserApplicationAssignmentType ??= new Repository<UserApplicationAssignmentType>(_dbContext);
                return _UserApplicationAssignmentType;
            }
        }
       
        public async Task<int> CommitAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }
        public void Dispose()
        {
            _dbContext.Dispose();
        }
        public void Commit()
        {
            _dbContext.SaveChanges();
        }
    }
}

