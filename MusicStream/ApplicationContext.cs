using Microsoft.EntityFrameworkCore;

namespace MusicStream
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Songs> Songs { get; set; }
        public DbSet<User> Users => Set<User>();
        public DbSet<SavedSongs> SavedSongs => Set<SavedSongs>();

        protected override void OnModelCreating(ModelBuilder modelBuilder) //отношение таблиц сохр. треков и пользователейt
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


        // Проверка, свободна ли форма регистрации
        public bool IsRegistrationOpen()
        {
            return !Users.Any(u => u.IsRegistering);
        }

        // Открытие формы регистрации
        public void OpenRegistrationForm()
        {
            if (!IsRegistrationOpen())
            {
                MessageBox.Show("Форма регистрации уже используется другим пользователем.");
                return;
            }

            // Ваш код для открытия формы регистрации
        }
    }
}
