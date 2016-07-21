using Microsoft.EntityFrameworkCore;

namespace Speakr.WebApp.Site.Infrastructure.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<UserDetails> UserDetails { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}
