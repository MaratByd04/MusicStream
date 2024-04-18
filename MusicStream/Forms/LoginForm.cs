namespace MusicStream
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void LogInButton_Click(object sender, EventArgs e)
        {
            using(var db = new  ApplicationContext())
            {
                string login = LoginTextBox.Text;
                string password = PasswordTextBox.Text;

                // проверка на существование пользователя 
                var user = db.Users.FirstOrDefault(u => u.Login == login && u.Password == password);

                if (user != null)
                {
                    PasswordTextBox.Clear();

                    var menuForm = new MenuForm();
                    menuForm.Show();

                    menuForm.CurrentUser = user; // сохранение вошедшего пользователя
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль!", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PasswordTextBox.Clear();
                }
            }   
        }
        private void SignInButton_Click(object sender, EventArgs e)
        {
            var signInForm = new SignInForm();
            signInForm.Show();
        }
    }
}