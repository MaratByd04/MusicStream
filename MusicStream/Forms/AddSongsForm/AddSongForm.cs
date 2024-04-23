using MusicStream.Forms.MenuForm;

namespace MusicStream
{
    public partial class AddSongForm : Form
    {
        public User CurrentUser {  get; set; }
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
    }
}
