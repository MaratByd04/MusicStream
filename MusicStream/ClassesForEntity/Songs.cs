using System.ComponentModel.DataAnnotations;

namespace MusicStream
{
    public class Songs
    {
        [Key]
        public int SongId { get; set; }
        public string? SongName { get; set; }
        public string? Author { get; set; }
        public string? Genre { get; set; }
        public string? SongCountry { get; set; }
        public string? SongYears { get; set; }
        public string? Mood { get; set; }
        public string? Duration { get; set; }
    }
}
