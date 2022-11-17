using wildcatMicroFund.Models;

namespace wildcatMicroFund.Interfaces
{
    public interface IUnitOfWork
    {
        //Data Accessors
        public IRepository<Application> Application { get; }
        public IRepository<ApplicationStatus> ApplicationStatus { get; }
        public IRepository<Availability> Availability { get; }
        public IRepository<Award> Award { get; }
        public IRepository<AwardType> AwardType { get; }
        public IRepository<Document> Document { get; }
        public IRepository<DocumentType> DocumentType { get; }
        public IRepository<Note> Note { get; }
        public IRepository<NoteType> NoteType { get; }
        public IRepository<PitchEvent> PitchEvent { get; }
        public IRepository<PitchEventApplication> PitchEventApplication { get; }
        public IRepository<Question> Question { get; }
        public IRepository<Response> Response { get; }
        public IRepository<Role> Role { get; }
        public IRepository<Score> Score { get; }
        public IRepository<Status> Status { get; }
        public IRepository<Survey> Survey { get; }
        public IRepository<SurveyQuestion> SurveyQuestion { get; }
        public IRepository<SurveyType> SurveyType { get; }
        public IRepository<User> User { get; }
        public IRepository<UserAssignment> UserAssignment { get; }
        public IRepository<UserRole> UserRole { get; }
        public IRepository<EmailTemplate> EmailTemplate { get; }

        //save changes to data source
        void Commit();
        //same but an Asynchronous Commit
        Task<int> CommitAsync();

    }
}
