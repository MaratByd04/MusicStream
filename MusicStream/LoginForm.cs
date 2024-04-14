namespace MusicStream
{
    public partial class LoginForm : Form
    {
        private ApplicationContext db;
        private bool isFirstClick = true;
        public LoginForm()
        {
            InitializeComponent();

            db = new ApplicationContext();
        }

        private void LoginTextBox_Click_2(object sender, EventArgs e)
        {
            
            if (isFirstClick)
            {
                LoginTextBox.Clear();
                isFirstClick = false;
            }
        }
        private void PasswordTextBox_Click(object sender, EventArgs e)
        {
                PasswordTextBox.Clear();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            string login = LoginTextBox.Text;
            string password = PasswordTextBox.Text;

            // Проверка существования пользователя 
            var user = db.Users.FirstOrDefault(u => u.Login == login && u.Password == password);

            if (user != null)
            {
                MessageBox.Show($"Добро пожаловать, {user.Name}!", "Успешная авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var form2 = new Form2();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PasswordTextBox.Clear();
            }
        }
    }
}