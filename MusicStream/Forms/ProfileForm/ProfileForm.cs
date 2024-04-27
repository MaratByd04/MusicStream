using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using NLog;
using System.Xml.Linq;

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
            NameTextBox.Text = currentUser.Name ?? string.Empty;
            EmailTextBox.Text = currentUser.Email ?? string.Empty;
            LoginTextBox.Text = currentUser.Login ?? string.Empty;
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            FillUserData(currentUser);
        }

        private void EditProfileDataButton_Click(object sender, EventArgs e)
        {
            using (var db = new ApplicationContext())
            {
                //try
                {
                    var userToUpdate = db.Users.FirstOrDefault(u => u.Login == currentUser.Login);

                    if (userToUpdate != null)
                    {
                        userToUpdate.Name = NameTextBox.Text;
                        userToUpdate.Email = EmailTextBox.Text;
                        userToUpdate.Login = LoginTextBox.Text;

                        db.SaveChanges();
                        logger.Info($"Пользователь {userToUpdate.Login} обновил свои данные");

                        MessageBox.Show("Данные успешно обновлены");
                    }
                    else
                    {
                        MessageBox.Show("Пользователь не найден");
                    }
                }
                /*
                catch (Exception ex)
                {
                    logger.Error($"Ошибка при обновлении данных пользователя: {ex.Message}");
                    MessageBox.Show($"Произошла ошибка при обновлении данных: {ex.Message} . Пожалуйста, попробуйте еще раз.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/
            }
        }

        public byte[] ReadImageFromFile(string filePath)
        {
            return File.ReadAllBytes(filePath);
        }

        private void SetUserPhoto(byte[] photoBytes)
        {
            //currentUser.Photo = photoBytes;
        }

        /*
        private void DisplayImage(byte[] photoBytes)
        {
            ProfilePictureBox.Image = Image.FromStream(new MemoryStream(photoBytes));
        }
        private void ChangePhotoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.gif)|*.jpg; *.jpeg; *.png; *.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                byte[] photoBytes = ReadImageFromFile(openFileDialog.FileName);

                SetUserPhoto(photoBytes);

                DisplayImage(photoBytes);
            }
        }
        */

        private void ProfileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var menuForm = new MenuForm(currentUser);
            menuForm.Show();
            this.Hide();
        }
    }
}
