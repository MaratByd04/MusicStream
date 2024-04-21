namespace MusicStream
{
    public partial class MenuForm : Form
    {
        /// <summary>
        /// Свойство, которое хранит текущего пользователя
        /// </summary>
        public User CurrentUser { get; set; }

        public MenuForm(User user)
        {
            InitializeComponent();
            CurrentUser = user;
        }

        private void RecommendationButton_Click(object sender, EventArgs e)
        {
            var user = CurrentUser;
            var form2 = new RecommendationForm(user);
            form2.Show();
            this.Hide();

        }

        private void TrackListButton_Click(object sender, EventArgs e)
        {
            var savedSongsForm = new SavedSongsForm(CurrentUser);
            savedSongsForm.Show();
            this.Hide();
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            var profileForm = new ProfileForm(CurrentUser);
            profileForm.Show();
            this.Hide();
        }

        private void CreateSongButton_Click(object sender, EventArgs e)
        {
            var addSongForm = new AddSongForm(); // добавь юзера 
            addSongForm.Show();
            this.Hide();
        }

        private void MenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Show();

        }
    }
}
