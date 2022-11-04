using wildcatMicroFund.Models;

namespace wildcatMicroFund.Interfaces
{
    public interface IUnitOfWork
    {
        //Data Accessors
        public IRepository<Application> Application { get; }

        //save changes to data source
        void Commit();
        //same but an Asynchronous Commit
        Task<int> CommitAsync();

    }
}
