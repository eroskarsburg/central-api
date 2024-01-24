using application.Shared.Entity;
using Microsoft.EntityFrameworkCore;

namespace application.Shared.Context.Users
{
    public class UserContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CentralDB;Trusted_Connection=true;");
        }
    }
}
