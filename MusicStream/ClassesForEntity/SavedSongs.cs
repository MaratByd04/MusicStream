using System.ComponentModel.DataAnnotations;

namespace MusicStream
{
    /// <summary>
    /// класс, отвечащий за сохраненные пользователем песни в таблице БД
    /// </summary>
    public class SavedSongs
    {
        /// <summary>
        /// свойство, хранящее ID сохраненной песни
        /// </summary>
        [Key]
        public int SavedSongId { get; set; }

        /// <summary>
        /// свойство, хранящее название сохраненной песни
        /// </summary>
        public string? SavedSongName { get; set; }

        /// <summary>
        /// свойство, хранящее автора сохраненной песни
        /// </summary>
        public string? SavedSongAuthor { get; set; }

        /// <summary>
        /// свойство, хранящее жанр сохраненной песни
        /// </summary>
        public string? SavedSongGenre { get; set; }

        /// <summary>
        /// свойство, хранящее страну сохраненной песни
        /// </summary>
        public string? SavedSongCountry { get; set; }

        /// <summary>
        /// свойство, хранящее годы сохраненной песни
        /// </summary>
        public string? SavedSongYears { get; set; }

        /// <summary>
        /// свойство, хранящее настроение сохраненной песни
        /// </summary>
        public string? SavedSongMood { get; set; }

        /// <summary>
        /// свойство, хранящее продолжительность сохраненной песни
        /// </summary>
        public string? SavedSongDuration { get; set; }

        /// <summary>
        /// свойство, устанавливающее связь песни с ID пользователя
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// свойство, хранящее объект пользователя, к которому будут относиться сохраненные песни 
        /// </summary>
        public User? User { get; set; }
    }
}
