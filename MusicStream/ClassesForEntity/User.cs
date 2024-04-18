namespace MusicStream
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }
        public ICollection<SavedSongs> SavedSongs { get; set; } = new List<SavedSongs>();
    }
}
