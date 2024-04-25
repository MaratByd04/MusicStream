using System.Reflection.Metadata;

namespace MusicStream
{
    /// <summary>
    /// класс пользоветеля, который представляет таблицу в БД
    /// </summary>
    public class User
    {  
        /// <summary>
        /// свойство, хранящее ID пользователя
        /// </summary>
        public Guid Id { get; set; }
        
        /// <summary>
        /// свойство, хранящее имя пользователя
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// свойство, хранящее электронную почту пользоваетеля
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// свойство, хранящее логин пользоваетеля
        /// </summary>
        public string? Login { get; set; }

        /// <summary>
        /// свойство, хранящее пароль пользоваетеля
        /// </summary>
        public string? Password { get; set; }

        /// <summary>
        /// Фотография пользователя в виде массива байт (BLOB)
        /// </summary>
        public byte[]? Photo { get; set; }

        /// <summary>
        /// свойство, хранящее список сохраненных песен 
        /// </summary>
        public ICollection<SavedSongs> SavedSongs { get; set; } = new List<SavedSongs>();

        public bool IsRegistering { get; set; } = false;// Новое свойство для отслеживания регистрации
    }
}
