using Microsoft.EntityFrameworkCore;
using NLog;
using System.Xml.Linq;

namespace MusicStream
{
    public partial class ProfileForm : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        private User currentUser;
        public ProfileForm(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            if (currentUser != null)
            {
                NameTextBox.Text = currentUser.Name?.ToString() ?? String.Empty;
                EmailTextBox.Text = currentUser.Email;
                LoginTextBox.Text = currentUser.Login;
            }
            else
            {
                MessageBox.Show("Пользователль - null");
            }
        }
        
        private void EditProfileDataButton_Click(object sender, EventArgs e)
        {
            
            using (var db = new ApplicationContext())
            {
                if (currentUser != null)
                {
                    currentUser.Name = NameTextBox.Text;
                    currentUser.Email = EmailTextBox.Text;
                    currentUser.Login = LoginTextBox.Text;

                    db.SaveChanges();

                    

                    logger.Info($"Пользователь {currentUser.Login} обновил свое имя на {NameTextBox.Text}");

                    MessageBox.Show("Данные успешно обновлены");
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
