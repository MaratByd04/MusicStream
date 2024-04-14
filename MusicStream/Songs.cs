using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        // Внешний ключ для связи с пользователем
        public int UserId { get; set; }
        // Связь с пользователем
        public User? User { get; set; }

    }
}
