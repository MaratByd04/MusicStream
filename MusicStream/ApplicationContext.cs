using Microsoft.EntityFrameworkCore;

namespace MusicStream
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<Songs> Songs { get; set; }
        public DbSet<User> Users => Set<User>();
        public DbSet<SavedSongs> SavedSongs => Set<SavedSongs>();

        protected override void OnModelCreating(ModelBuilder modelBuilder) //отношение таблиц сохр. треков и пользователей
        {
            modelBuilder.Entity<SavedSongs>()
                .HasOne(ss => ss.User)
                .WithMany(u => u.SavedSongs)
                .HasForeignKey(ss => ss.UserId);
        }

        public ApplicationContext() => Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=users.db");
        }
    }
}
