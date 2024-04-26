using MusicStream.Forms.MenuForm;

namespace MusicStream
{
    public partial class LoginForm : Form
    {
        private RecommendationEngine recommendationEngine = null!;
        
        private static LoginForm? instance;

        /// <summary>
        /// свойство, отвечающее за паттерн singleton
        /// </summary>
        public static LoginForm Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new LoginForm();
                }
                return instance;
            }
        }

        
        public LoginForm()
        {
            InitializeComponent();

            RecommendationEngineProvider.Initialize();
        }
        public void LogInButton_Click(object sender, EventArgs e)
        {
            using (var db = new ApplicationContext())
            {
                var login = LoginTextBox.Text;
                var password = PasswordTextBox.Text;

                var user = CheckUserCredentials(db, login, password);

                if (user != null)
                {
                    PasswordTextBox.Clear();
                    ShowMenuForm(user);
                    this.Hide();
                }
                else
                {
                    ShowErrorMessage("Неверный логин или пароль!");
                    PasswordTextBox.Clear();
                }
            }
        }

        public User CheckUserCredentials(ApplicationContext db, string login, string password)
        {
            return db.Users.FirstOrDefault(u => u.Login == login && u.Password == password);
        }

        private void ShowMenuForm(User user)
        {
            var menuForm = new MenuForm(user);
            menuForm.Show();
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void SignInButton_Click(object sender, EventArgs e)
        {
            OpenRegistrationForm();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void OpenRegistrationForm()
        {
            using (ApplicationContext db = new ApplicationContext())
            {

                var signInForm = new SignInForm();
                signInForm.Show();
                this.Hide();
            }
        }
    }
}