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
            var recommendationForm = new RecommendationForm(CurrentUser);
            recommendationForm.Show();
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
            var addSongForm = new AddSongForm(CurrentUser); // добавь юзера 
            addSongForm.Show();
            this.Hide();
        }

        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {   
            LoginForm.Instance.Show();
            this.Hide();
        }
    }
}
