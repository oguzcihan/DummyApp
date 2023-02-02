using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataAccess.Context
{
    public class AppDbContext : DbContext
    {
        private IConfiguration Configuration { get; set; }
        public DbSet<Computer> Computers { get; set; }

        public AppDbContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
        {
            Configuration = configuration;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Computer>().HasKey(p => p.Id);
        }
    }
}
