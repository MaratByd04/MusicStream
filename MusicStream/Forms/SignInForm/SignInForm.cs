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
                var email = EmailTextBox.Text;
                var password = PasswordTextBox.Text;
                var repeatPassword = RepeatPasswordTextBox.Text;

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

                if (email.Contains('@'))
                {
                    string[] emailParts = email.Split('@');

                    if (emailParts.Length == 2 && emailParts[0].Length >= 1 && emailParts[1].Length >= 3)
                    {
                        var login = emailParts[0]; //получение логина, обрезая строку после "@"

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
                    else
                    {
                        MessageBox.Show("Email должен содержать не менее 1 символа перед и 3 символов после знака - @", "Ошибка ввода Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Введите корректное название электронной почты, используя знак - @", "Ошибка ввода Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }   
            } 
        }
        private void SignInForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm.Instance.Show();
            this.Hide();
        }
    }
}
