namespace MusicStream
{
    public partial class MenuForm : Form
    {
        public User CurrentUser { get; set; } = null!;

        public MenuForm()
        {
            InitializeComponent();
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
    }
}
