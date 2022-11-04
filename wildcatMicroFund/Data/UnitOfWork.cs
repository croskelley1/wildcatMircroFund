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

        private IRepository<Question> _Question;
        public IRepository<Question> Question
        {
            get
            {
                _Question ??= new Repository<Question>(_dbContext);
                return _Question;
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

        private IRepository<Role> _Role;
        public IRepository<Role> Role
        {
            get
            {
                _Role ??= new Repository<Role>(_dbContext);
                return _Role;
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

        private IRepository<Survey> _Survey;
        public IRepository<Survey> Survey
        {
            get
            {
                _Survey ??= new Repository<Survey>(_dbContext);
                return _Survey;
            }
        }

        private IRepository<SurveyQuestion> _SurveyQuestion;
        public IRepository<SurveyQuestion> SurveyQuestion
        {
            get
            {
                _SurveyQuestion ??= new Repository<SurveyQuestion>(_dbContext);
                return _SurveyQuestion;
            }
        }

        private IRepository<SurvType> _SurvType;
        public IRepository<SurvType> SurvType
        {
            get
            {
                _SurvType ??= new Repository<SurvType>(_dbContext);
                return _SurvType;
            }
        }

        private IRepository<User> _User;
        public IRepository<User> User
        {
            get
            {
                _User ??= new Repository<User>(_dbContext);
                return _User;
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

        private IRepository<UserRole> _UserRole;
        public IRepository<UserRole> UserRole
        {
            get
            {
                _UserRole ??= new Repository<UserRole>(_dbContext);
                return _UserRole;
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

