using CSU.Domain.Entities;

using Microsoft.EntityFrameworkCore;

namespace CSU.Infrastructure.Comman.Persistence
{
    public class DataContext : DbContext
    {
        public DataContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = localhost; Database = CSUSuceava; TrustServerCertificate = true; Integrated Security = true; ");
        }

        public DbSet<News> News { get; set; } = null!;
        public DbSet<Image> Images { get; set; } = null!;
    }
}
