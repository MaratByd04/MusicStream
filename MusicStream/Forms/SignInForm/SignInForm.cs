using MusicStream.Forms.MenuForm;

namespace MusicStream
{
    public partial class SignInForm : Form
    {
        private readonly RecommendationEngine recommendationEngine;


        public SignInForm()
        {
            InitializeComponent();

            recommendationEngine = new RecommendationEngine();

        }

        public void SignInButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new ApplicationContext())
                {
                    var email = EmailTextBox.Text;
                    var password = PasswordTextBox.Text;
                    var repeatPassword = RepeatPasswordTextBox.Text;

                    if (!CheckPasswordMatch(password, repeatPassword))
                    {
                        return;
                    }

                    if (!CheckExistingUser(db, email))
                    {
                        return;
                    }

                    if (!CheckEmailValidity(email))
                    {
                        return;
                    }

                    RegisterNewUser(db, email, password);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при регистрации пользователя: {ex.Message}", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool CheckPasswordMatch(string password, string repeatPassword)
        {
            if (password != repeatPassword)
            {
                MessageBox.Show("Пароли не совпадают!", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PasswordTextBox.Clear();
                RepeatPasswordTextBox.Clear();
                return false;
            }
            return true;
        }

        public bool CheckExistingUser(ApplicationContext db, string email)
        {
            var existingUser = db.Users.FirstOrDefault(u => u.Email == email);
            if (existingUser != null)
            {
                MessageBox.Show("Пользователь с таким email уже зарегистрирован!", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                EmailTextBox.Clear();
                PasswordTextBox.Clear();
                RepeatPasswordTextBox.Clear();
                return false;
            }
            return true;
        }

        public bool CheckEmailValidity(string email)
        {
            if (email.Contains('@'))
            {
                string[] emailParts = email.Split('@');

                if (emailParts.Length == 2 && emailParts[0].Length >= 1 && emailParts[1].Length >= 3)
                    return true;

                MessageBox.Show("Email должен содержать не менее 1 символа перед и 3 символов после знака - @", "Ошибка ввода Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Введите корректное название электронной почты, используя знак - @", "Ошибка ввода Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private void RegisterNewUser(ApplicationContext db, string email, string password)
        {
            string[] emailParts = email.Split('@');
            var login = emailParts[0];

            var newUser = new User
            {
                Email = email,
                Login = login,
                Password = password
            };

            db.Users.Add(newUser);
            db.SaveChanges();

            MessageBox.Show("Пользователь успешно зарегистрирован! \nДля дальнейшего входа в качестве логина используйте адрес вашей почты до знака - @", "Успешная регистрация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            EmailTextBox.Clear();
            PasswordTextBox.Clear();
            RepeatPasswordTextBox.Clear();
            this.Hide();

            var menuForm = new MenuForm(newUser);
            menuForm.Show();

            menuForm.CurrentUser = newUser;
        }
        private void SignInForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm.Instance.Show();
            this.Hide();
        }
    }
}
