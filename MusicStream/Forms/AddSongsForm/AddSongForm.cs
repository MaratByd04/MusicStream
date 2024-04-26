using MusicStream.Forms.MenuForm;

namespace MusicStream
{
    public partial class AddSongForm : Form
    {
        public User CurrentUser { get; set; }
        public AddSongForm(User currentUser)
        {
            InitializeComponent();
            CurrentUser = currentUser;

            // Устанавливаем флаг регистрации для текущего пользователя
            CurrentUser.IsRegistering = true;

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

                    MessageBox.Show("Новая песня успешно сохранена!");
                    ClearTextBoxes();
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
            }
        }
        private bool AllFieldsFilled()
        {
            return !string.IsNullOrEmpty(SongNameTextBox.Text) &&
                   !string.IsNullOrEmpty(AuthorTextBox.Text) &&
                   !string.IsNullOrEmpty(GenreTextBox.Text) &&
                   !string.IsNullOrEmpty(SongCountryTextBox.Text) &&
                   !string.IsNullOrEmpty(SongYearsTextBox.Text) &&
                   !string.IsNullOrEmpty(MoodTextBox.Text) &&
                   !string.IsNullOrEmpty(DurationTextBox.Text);
        }
        private void ClearTextBoxes()
        {
            SongNameTextBox.Text = String.Empty;
            AuthorTextBox.Text = String.Empty;
            GenreTextBox.Text = String.Empty;
            SongCountryTextBox.Text = String.Empty;
            SongYearsTextBox.Text = String.Empty;
            MoodTextBox.Text = String.Empty;
            DurationTextBox.Text = String.Empty;
        }
    }
}
