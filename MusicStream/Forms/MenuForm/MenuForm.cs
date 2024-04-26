using MusicStream.Forms.MenuForm;
using System.Windows.Forms;

namespace MusicStream
{
    public partial class MenuForm : Form
    {
        private readonly RecommendationEngine recommendationEngine;

        /// <summary>
        /// Свойство, которое хранит текущего пользователя
        /// </summary>
        public User CurrentUser { get; set; }

        public MenuForm(User user)
        {
            InitializeComponent();
            CurrentUser = user;

            recommendationEngine = RecommendationEngineProvider.GetRecommendationEngine();
        }

        private void ShowPlaylist(List<Songs> playlist)
        {
            PlaylistListBox.DataSource = null;
            PlaylistListBox.Items.Clear();

            foreach (var song in playlist)
            {
                PlaylistListBox.Items.Add(song.SongName.ToString()); // Предполагается, что у песни есть свойство Title
            }

            //передача в listBox самих объектов, а не строк
            PlaylistListBox.DataSource = playlist.ToList();
            PlaylistListBox.DisplayMember = "SongName";

            PlaylistListBox.BringToFront();
            PlaylistListBox.Visible = true;
            HidePlaylistButton.BringToFront();
            HidePlaylistButton.Visible = true;
            SaveTrackButton.Visible = true;
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
            // Проверяем доступность регистрации перед открытием формы добавления песни
            if (CheckRegistrationAvailability())
            {
                var addSongForm = new AddSongForm(CurrentUser); // передаем текущего пользователя в форму
                addSongForm.Show();
                this.Hide();
            }
        }
        private bool CheckRegistrationAvailability()
        {
            using (var db = new ApplicationContext())
            {
                var user = db.Users.FirstOrDefault(u => u.Id == CurrentUser.Id);

                // Проверяем, доступна ли форма для регистрации
                if (user == null || !user.IsRegistering)
                {
                    return true; // Форма доступна, если пользователь не найден или не зарегистрирован в данный момент
                }
            }
            return false;
        }

        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {   
            LoginForm.Instance.Show();
            this.Hide();
        }

        private void SadnessPlaylistButton_Click(Object sender, EventArgs e)
        {
            ShowPlaylist(recommendationEngine.GetSadnessPlaylist());
        }

        private void WorkPlaylistButton_Click(object sender, EventArgs e)
        {
            ShowPlaylist(recommendationEngine.GetWorkPlaylist());
        }

        private void SportPlaylistButton_Click(object sender, EventArgs e)
        {
            ShowPlaylist(recommendationEngine.GetSportPlaylist());
        }

        private void HidePlaylistButton_Click(object sender, EventArgs e)
        {
            PlaylistListBox.Visible = false;
            HidePlaylistButton.Visible = false;
            SaveTrackButton.Visible = false;
        }

        private void SaveTrackButton_Click(object sender, EventArgs e)
        {
            using (var db = new ApplicationContext())
            {
                if (PlaylistListBox.SelectedItem != null)
                {
                    var selectedSong = PlaylistListBox.SelectedItem as Songs;

                    if (selectedSong != null)
                    {
                        var existingSong = db.SavedSongs.FirstOrDefault(s => s.SavedSongName == selectedSong.SongName && s.UserId == CurrentUser.Id);

                        if (existingSong == null)
                        {
                            // создание новой записи в SavedSongs
                            var savedSong = new SavedSongs
                            {
                                SavedSongName = selectedSong.SongName,
                                SavedSongAuthor = selectedSong.Author,
                                SavedSongGenre = selectedSong.Genre,
                                SavedSongCountry = selectedSong.SongCountry,
                                SavedSongYears = selectedSong.SongYears,
                                SavedSongMood = selectedSong.Mood,
                                SavedSongDuration = selectedSong.Duration,
                                UserId = CurrentUser.Id
                            };

                            db.SavedSongs.Add(savedSong);
                            db.SaveChanges();

                            MessageBox.Show("Песня добавлена!");
                        }
                        else
                        {
                            MessageBox.Show("Эта песня уже добавлена в избранное.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Что-то пошло не так");
                    }
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите песню для сохранения.");
                }
            }
        }
    }
}
