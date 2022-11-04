using wildcatMicroFund.Interfaces;
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

