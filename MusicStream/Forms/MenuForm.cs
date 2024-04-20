namespace MusicStream
{
    public partial class MenuForm : Form
    {
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

        }
        private void TrackListButton_Click(object sender, EventArgs e)
        {
            var user = CurrentUser;
            var savedSongsForm = new SavedSongsForm(user);
            savedSongsForm.Show();
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            var user = CurrentUser;
            var profileForm = new ProfileForm(CurrentUser);
            profileForm.Show();
        }

        private void CreateSongButton_Click(object sender, EventArgs e)
        {
            var user = CurrentUser;
            var addSongForm = new AddSongForm();
            addSongForm.Show();
        }
    }
}
