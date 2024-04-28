namespace MusicStream
{
    public partial class AddSongForm : Form
    {
        public User CurrentUser { get; set; }

        public AddSongForm()
        {
            InitializeComponent();
            PopulateGenreComboBox();
            PopulateMoodComboBox();
            PopulateDurationComboBox();
        }

        public AddSongForm(User currentUser)
        {
            InitializeComponent();
            CurrentUser = currentUser;
            PopulateGenreComboBox();
            PopulateMoodComboBox();
            PopulateDurationComboBox();
        }

        private void AddSongForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var menuForm = new MenuForm(CurrentUser);
            menuForm.Show();

            this.Hide();
        }

        private void AddNewSongButton_Click(object sender, EventArgs e)
        {
            if (AllFieldsFilled())
            {
                AddNewSong();
            }
            else
            {
                ShowMessageBox("Пожалуйста, заполните все поля.");
            }
        }

        public bool AllFieldsFilled()
        {
            return !string.IsNullOrEmpty(SongNameTextBox.Text) &&
                   !string.IsNullOrEmpty(AuthorTextBox.Text) &&
                   !string.IsNullOrEmpty(SongCountryTextBox.Text) &&
                   !string.IsNullOrEmpty(SongYearsTextBox.Text) &&
                   MoodComboBox.SelectedIndex != -1 &&
                   DurationComboBox.SelectedIndex != -1 &&
                   GenreComboBox.SelectedIndex != -1;
        }

        public bool ValidateSongCountry(string songCountry)
        {
            if (songCountry.Any(char.IsDigit))
            {
                MessageBox.Show("Название страны не должно содержать цифр.");
                return false;
            }
            return true;
        }

        public bool ValidateSongYears(string songYears)
        {
            if (songYears.Any(char.IsLetter))
            {
                MessageBox.Show("Годы не должны содержать букв.");
                return false;
            }
            return true;
        }
        public bool ValidateRealSongYears(string songYears)
        {
            if (int.Parse(songYears) > 2024)
            {
                MessageBox.Show("Год не может быть выше текущего.");
                return false;
            }
            return true;
        }

        private void AddNewSong()
        {
            using (var db = new ApplicationContext())
            {
                if (!ValidateSongCountry(SongCountryTextBox.Text))
                {
                    SongCountryTextBox.Text = string.Empty;
                    return;
                }

                if (!ValidateSongYears(SongYearsTextBox.Text))
                {
                    SongYearsTextBox.Text = string.Empty;
                    return;
                }

                if (!ValidateRealSongYears(SongYearsTextBox.Text))
                {
                    SongYearsTextBox.Text = string.Empty;
                    return;
                }

                var newSong = new Songs
                {
                    SongName = SongNameTextBox.Text,
                    Author = AuthorTextBox.Text,
                    SongCountry = SongCountryTextBox.Text,
                    SongYears = SongYearsTextBox.Text,
                    Duration = DurationComboBox.SelectedItem.ToString(),
                    Mood = MoodComboBox.SelectedItem.ToString(),
                    Genre = GenreComboBox.SelectedItem.ToString()
                };

                db.Songs.Add(newSong);
                db.SaveChanges();

                ShowMessageBox("Новая песня успешно сохранена!");
                ClearTextBoxes();
            }
        }

        private void ShowMessageBox(string message)
        {
            MessageBox.Show(message);
        }

        private void ClearTextBoxes()
        {
            SongNameTextBox.Text = string.Empty;
            AuthorTextBox.Text = string.Empty;
            SongCountryTextBox.Text = string.Empty;
            SongYearsTextBox.Text = string.Empty;
            MoodComboBox.Text = string.Empty;
            DurationComboBox.Text = string.Empty;
            GenreComboBox.Text = string.Empty;
        }

        private void PopulateGenreComboBox()
        {
            GenreComboBox.Items.Add("Rap");
            GenreComboBox.Items.Add("Rock");
            GenreComboBox.Items.Add("Electro");
            GenreComboBox.Items.Add("Classic");
            GenreComboBox.Items.Add("Pop");
        }

        private void PopulateMoodComboBox()
        {
            MoodComboBox.Items.Add("Adrenaline");
            MoodComboBox.Items.Add("Depressive");
            MoodComboBox.Items.Add("Calmness");
            MoodComboBox.Items.Add("Positive");
        }

        private void PopulateDurationComboBox()
        {
            DurationComboBox.Items.Add("1-5 min");
            DurationComboBox.Items.Add("5-10 min");
            DurationComboBox.Items.Add("10-15 min");
            DurationComboBox.Items.Add("15-20 min");
        }
    }
}
