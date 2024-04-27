using MusicStream.Forms.MenuForm;

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
        }

        public AddSongForm(User currentUser)
        {
            InitializeComponent();
            CurrentUser = currentUser;
            PopulateGenreComboBox();
            PopulateMoodComboBox();
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
                   !string.IsNullOrEmpty(DurationTextBox.Text) &&
                   MoodComboBox.SelectedIndex != -1 &&
                   GenreComboBox.SelectedIndex != -1;
        }

        private void AddNewSong()
        {
            using (var db = new ApplicationContext())
            {
                if (SongCountryTextBox.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("Название страны не должно содержать цифр.");
                    SongCountryTextBox.Text = string.Empty;
                    return;
                }

                if (SongYearsTextBox.Text.Any(char.IsLetter) || int.Parse(SongYearsTextBox.Text) > 2024)
                {
                    MessageBox.Show("Годы не должны содержать букв.");
                    SongYearsTextBox.Text = string.Empty;
                    return;
                }

                var newSong = new Songs
                {
                    SongName = SongNameTextBox.Text,
                    Author = AuthorTextBox.Text,
                    SongCountry = SongCountryTextBox.Text,
                    SongYears = SongYearsTextBox.Text,
                    Duration = DurationTextBox.Text,
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
            DurationTextBox.Text = string.Empty;
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
    }
}
