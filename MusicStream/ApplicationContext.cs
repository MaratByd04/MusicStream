using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MusicStream
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<Songs> Songs { get; set; }
        public DbSet <User> Users => Set<User>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Установление связи между пользователем и списком песен 
            modelBuilder.Entity<Songs>()
                .HasOne(o => o.User)
                .WithMany(u => u.Songs)
                .HasForeignKey(o => o.UserId);
        }
        public ApplicationContext() => Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=users.db");
        }  
    }
}
