using System.ComponentModel.DataAnnotations;

namespace MusicStream
{
    public class SavedSongs
    {
        [Key]
        public int SavedSongId { get; set; }
        public string? SavedSongName { get; set; }
        public string? SavedSongAuthor { get; set; }
        public string? SavedSongGenre { get; set; }
        public string? SavedSongCountry { get; set; }
        public string? SavedSongYears { get; set; }
        public string? SavedSongMood { get; set; }
        public string? SavedSongDuration { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
    }
}
