using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using wildcatMicroFund.Models;
namespace wildcatMicroFund.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Application> Application { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
    }
}