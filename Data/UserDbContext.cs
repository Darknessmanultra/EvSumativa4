using EvSumativa4.Models;
using Microsoft.EntityFrameworkCore;

namespace EvSumativa4.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) { }

        public DbSet<Usuario> Users {get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .HasIndex(p => p.Correo).IsUnique();
        }
    }
}