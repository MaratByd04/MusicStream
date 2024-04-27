using MusicStream.Forms.MenuForm;

namespace MusicStream
{
    public partial class AddSongForm : Form
    {
        public User CurrentUser { get; set; }

        public AddSongForm()
        {
            InitializeComponent();

        }

        public AddSongForm(User currentUser)
        {
            InitializeComponent();
            CurrentUser = currentUser;
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
                   !string.IsNullOrEmpty(GenreTextBox.Text) &&
                   !string.IsNullOrEmpty(SongCountryTextBox.Text) &&
                   !string.IsNullOrEmpty(SongYearsTextBox.Text) &&
                   !string.IsNullOrEmpty(MoodTextBox.Text) &&
                   !string.IsNullOrEmpty(DurationTextBox.Text);
        }

        private void AddNewSong()
        {
            using (var db = new ApplicationContext())
            {
                var newSong = new Songs
                {
                    SongName = SongNameTextBox.Text,
                    Author = AuthorTextBox.Text,
                    Genre = GenreTextBox.Text,
                    SongCountry = SongCountryTextBox.Text,
                    SongYears = SongYearsTextBox.Text,
                    Mood = MoodTextBox.Text,
                    Duration = DurationTextBox.Text
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
            GenreTextBox.Text = string.Empty;
            SongCountryTextBox.Text = string.Empty;
            SongYearsTextBox.Text = string.Empty;
            MoodTextBox.Text = string.Empty;
            DurationTextBox.Text = string.Empty;
        }

    }
}
