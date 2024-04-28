using NLog;

namespace MusicStream
{
    public partial class RecommendationForm : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        private User currentUser;

        public RecommendationForm()
        {
            InitializeComponent();
        }
        public RecommendationForm(User user)
        {
            currentUser = user;
            InitializeComponent();

            PopulateDropdowns();
        }
        private void PopulateDropdowns()
        {
            using (var db = new ApplicationContext())
            {
                logger.Info("Подключение к БД прошло успешно.");

                // установка значений характеристик
                var genres = db.Songs.Select(s => s.Genre).Distinct().ToList();
                var countries = db.Songs.Select(s => s.SongCountry).Distinct().ToList();
                var years = db.Songs.Select(s => s.SongYears).Distinct().ToList();
                var moods = db.Songs.Select(s => s.Mood).Distinct().ToList();
                var durations = db.Songs.Select(s => s.Duration).Distinct().ToList();

                // добавление возможности оставить характеристику песни пустой
                genres.Insert(0, "Все");
                countries.Insert(0, "Все");
                years.Insert(0, "Все");
                moods.Insert(0, "Все");
                durations.Insert(0, "Все");

                // заполнение combobox параметрами песен
                GenreComboBox.Items.AddRange(genres.Cast<Object>().ToArray());
                CountryComboBox.Items.AddRange(countries.Cast<Object>().ToArray());
                YearsComboBox.Items.AddRange(years.Cast<Object>().ToArray());
                MoodComboBox.Items.AddRange(moods.Cast<Object>().ToArray());
                DurationComboBox.Items.AddRange(durations.Cast<Object>().ToArray());
            }
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            using (var db = new ApplicationContext())
            {
                logger.Info("Подключение к БД прошло успешно.");

                // передача выбранных характеристик 
                var selectedGenre = GenreComboBox.SelectedItem?.ToString() ?? string.Empty;
                var selectedCountry = CountryComboBox.SelectedItem?.ToString() ?? string.Empty;
                var selectedYears = YearsComboBox.SelectedItem?.ToString() ?? string.Empty;
                var selectedMood = MoodComboBox.SelectedItem?.ToString() ?? string.Empty;
                var selectedDurations = DurationComboBox.SelectedItem?.ToString() ?? string.Empty;

                var filteredSongs = db.Songs.AsQueryable();

                if (!string.IsNullOrEmpty(selectedGenre) && selectedGenre != "Все")
                {
                    filteredSongs = filteredSongs.Where(s => s.Genre == selectedGenre);
                }

                if (!string.IsNullOrEmpty(selectedCountry) && selectedCountry != "Все")
                {
                    filteredSongs = filteredSongs.Where(s => s.SongCountry == selectedCountry);
                }

                if (!string.IsNullOrEmpty(selectedYears) && selectedYears != "Все")
                {
                    filteredSongs = filteredSongs.Where(s => s.SongYears == selectedYears);
                }

                if (!string.IsNullOrEmpty(selectedMood) && selectedMood != "Все")
                {
                    filteredSongs = filteredSongs.Where(s => s.Mood == selectedMood);
                }

                if (!string.IsNullOrEmpty(selectedDurations) && selectedDurations != "Все")
                {
                    filteredSongs = filteredSongs.Where(s => s.Duration == selectedDurations);
                }

                //передача в listBox самих объектов, а не строк
                ResultsListBox.DataSource = filteredSongs.ToList();
                ResultsListBox.DisplayMember = "SongName";
            }
        }
        private void SaveTrackButton_Click(object sender, EventArgs e)
        {
            using (var db = new ApplicationContext())
            {
                logger.Info("Подключение к БД прошло успешно.");

                var selectedSong = GetSelectedSongFromListBox();

                if (selectedSong != null)
                {
                    if (!CheckIfSongAlreadySaved(selectedSong, db))
                    {
                        AddSongToSavedSongs(selectedSong, db);
                    }
                    else
                    {
                        MessageBox.Show("Эта песня уже добавлена в избранное.");
                    }
                }
                else
                {
                    MessageBox.Show("Что-то пошло не так");
                }
            }
        }

        public Songs? GetSelectedSongFromListBox()
        {
            return ResultsListBox.SelectedItem as Songs;
        }

        private bool CheckIfSongAlreadySaved(Songs selectedSong, ApplicationContext db)
        {
            return db.SavedSongs.Any(s => s.SavedSongName == selectedSong.SongName && s.UserId == currentUser.Id);
        }

        private void AddSongToSavedSongs(Songs selectedSong, ApplicationContext db)
        {
            var savedSong = new SavedSongs
            {
                SavedSongName = selectedSong.SongName,
                SavedSongAuthor = selectedSong.Author,
                SavedSongGenre = selectedSong.Genre,
                SavedSongCountry = selectedSong.SongCountry,
                SavedSongYears = selectedSong.SongYears,
                SavedSongMood = selectedSong.Mood,
                SavedSongDuration = selectedSong.Duration,
                UserId = currentUser.Id
            };

            db.SavedSongs.Add(savedSong);
            logger.Info("Выполняется попытка добавить новую пенсю в таблицу БД.");

            db.SaveChanges();
            logger.Info("Лобавление песни в таблицу БД прошло успешно.");

            MessageBox.Show("Песня добавлена!");
        }

        private void RecommendationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var menuForm = new MenuForm(currentUser);
            menuForm.Show();
            this.Hide();
        }
    }
}
