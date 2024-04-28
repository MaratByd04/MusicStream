using NLog;

namespace MusicStream
{
    public partial class ProfileForm : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        private User currentUser;

        public ProfileForm()
        {
            InitializeComponent();
        }

        public ProfileForm(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        public void FillUserData(User currentUser)
        {
            ProfileNameTextBox.Text = currentUser.Name ?? string.Empty;
            ProfileLoginTextBox.Text = currentUser.Email ?? string.Empty;
            ProfileEmailTextBox.Text = currentUser.Login ?? string.Empty;
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            FillUserData(currentUser);
        }

        
        private void EditProfileDataButton_Click(object sender, EventArgs e)
        {
            using (var db = new ApplicationContext())
            {
                try
                {
                    var userToUpdate = db.Users.FirstOrDefault(u => u.Login == currentUser.Login);

                    if (userToUpdate != null)
                    {
                        userToUpdate.Name = ProfileNameTextBox.Text;
                        userToUpdate.Email = ProfileEmailTextBox.Text;
                        userToUpdate.Login = ProfileLoginTextBox.Text;

                        db.SaveChanges();
                        logger.Info($"Пользователь {userToUpdate.Login} обновил свои данные");

                        MessageBox.Show("Данные успешно обновлены");
                    }
                    else
                    {
                        MessageBox.Show("Пользователь не найден");
                    }
                }
                catch (Exception ex)
                {
                    logger.Error($"Ошибка при обновлении данных пользователя: {ex.Message}");
                    MessageBox.Show($"Произошла ошибка при обновлении данных: {ex.Message} . Пожалуйста, попробуйте еще раз.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        


        private void ProfileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var menuForm = new MenuForm(currentUser);
            menuForm.Show();
            this.Hide();
        }
    }
}
