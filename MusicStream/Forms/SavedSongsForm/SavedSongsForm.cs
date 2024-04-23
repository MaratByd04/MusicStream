namespace MusicStream
{
    public partial class SavedSongsForm : Form
    {
        private User currentUser = null!;
        public SavedSongsForm(User user)
        {
            InitializeComponent(); 
            currentUser = user;
        }
        private void ShowFavoriteSongsButton_Click(object sender, EventArgs e)
        {
            SavedTracksListBox.Items.Clear();

            using (var db = new ApplicationContext())
            {
                var savedSongs = db.SavedSongs.Where(s => s.UserId == currentUser.Id).ToList();

                foreach (var savedSong in savedSongs)
                {
                    if (savedSong != null)
                    {
                        SavedTracksListBox.Items.Add(savedSong);
                        SavedTracksListBox.DisplayMember = "SavedSongName";
                        DeleteSongButton.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Песня не найдена!");
                    }
                }
            }
        }
        private void DeleteSongButton_Click(object sender, EventArgs e)
        {
            var selectedSong = SavedTracksListBox.SelectedItem as SavedSongs;

            if (selectedSong != null)
            {
                using (var db = new ApplicationContext())
                {
                    var savedSong = db.SavedSongs.FirstOrDefault(s => s.SavedSongName == selectedSong.SavedSongName);
                    if (savedSong != null)
                    {
                        db.SavedSongs.Remove(savedSong);
                        db.SaveChanges();

                        // Удалить элемент из списка
                        SavedTracksListBox.Items.Remove(selectedSong);

                        MessageBox.Show("Песня убрана из избранного!");
                    }
                    else
                    {
                        MessageBox.Show("Выбранная песня не найдена в избранном.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите песню.");
            }
        }
        private void SavedSongsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var menuForm = new MenuForm(currentUser);
            menuForm.Show();

            this.Hide();
        }
    }
}
