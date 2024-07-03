using Microsoft.EntityFrameworkCore;
using StudentRegistration.Web.Models;

namespace StudentRegistration.Web.Data
{
    public class ApplicationDbContext :DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
            
        }

        public DbSet<Students> Students { get; set; }

        public DbSet<Interview> Interviews { get; set; }

    }
}
