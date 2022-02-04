using DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Log> Logs => Set<Log>();
        public ApplicationDbContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=Test;Trusted_Connection=True;");
        }
    }
}