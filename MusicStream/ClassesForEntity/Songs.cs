using System.ComponentModel.DataAnnotations;

namespace MusicStream
{
    /// <summary>
    /// класс, который представляет песню в таблице БД
    /// </summary>
    public class Songs
    {
        /// <summary>
        /// свойство, хранящее ID песни
        /// </summary>
        [Key]
        public int SongId { get; set; }
        /// <summary>
        /// свойство, хранящее название песни
        /// </summary>
        public string? SongName { get; set; }
        /// <summary>
        /// свойство, хранящее автора песни
        /// </summary>
        public string? Author { get; set; }
        /// <summary>
        /// свойство, хранящее жанр песни
        /// </summary>
        public string? Genre { get; set; }
        /// <summary>
        /// свойство, хранящее страну песни
        /// </summary>
        public string? SongCountry { get; set; }
        /// <summary>
        /// свойство, хранящее годы песни
        /// </summary>
        public string? SongYears { get; set; }
        /// <summary>
        /// свойство, хранящее настроение песни
        /// </summary>
        public string? Mood { get; set; }
        /// <summary>
        /// свойство, хранящее продолжительность песни
        /// </summary>
        public string? Duration { get; set; }
    }
}
