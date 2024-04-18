namespace MusicStream
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }
        private void SignInButton_Click(object sender, EventArgs e)
        {
            using(var db = new  ApplicationContext())
            {
                string email = EmailTextBox.Text;
                string password = PasswordTextBox.Text;
                string repeatPassword = RepeatPasswordTextBox.Text;

                if (password != repeatPassword)
                {
                    MessageBox.Show("Пароли не совпадают!", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PasswordTextBox.Clear();
                    RepeatPasswordTextBox.Clear();
                    return;
                }

                var existingUser = db.Users.FirstOrDefault(u => u.Email == email);
                if (existingUser != null)
                {
                    MessageBox.Show("Пользователь с таким email уже зарегистрирован!", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    EmailTextBox.Clear();
                    PasswordTextBox.Clear();
                    RepeatPasswordTextBox.Clear();
                    return;
                }

                string login = email.Split('@')[0]; //получение логина, обрезая строку после "@"

                var newUser = new User
                {
                    Email = email,
                    Login = login,
                    Password = password
                };

                db.Users.Add(newUser);
                db.SaveChanges();

                MessageBox.Show("Пользователь успешно зарегистрирован!", "Успешная регистрация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EmailTextBox.Clear();
                PasswordTextBox.Clear();
                RepeatPasswordTextBox.Clear();
                this.Hide();
            } 
        }
    }
}
