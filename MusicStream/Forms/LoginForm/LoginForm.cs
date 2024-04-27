using MusicStream.Forms.MenuForm;
using NLog;

namespace MusicStream
{
    public partial class LoginForm : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        private RecommendationEngine recommendationEngine = null!;
        
        private static LoginForm? instance;

        /// <summary>
        /// ��������, ���������� �� ������� singleton
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
                    logger.Info("������������ �������� ����.");

                    PasswordTextBox.Clear();
                    ShowMenuForm(user);
                    Console.WriteLine(user.Id);
                    this.Hide();
                }
                else
                {
                    logger.Info("������������ � ���������� ������� �� ������.");

                    ShowErrorMessage("�������� ����� ��� ������!");
                    PasswordTextBox.Clear();
                }
            }
        }

        public User CheckUserCredentials(ApplicationContext db, string login, string password)
        {
            logger.Info("����������� ������������� ������������.");

            return db.Users.FirstOrDefault(u => u.Login == login && u.Password == password);
        }

        private void ShowMenuForm(User user)
        {
            var menuForm = new MenuForm(user);
            menuForm.Show();
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "������ �����������", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            OpenSignInForm();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void OpenSignInForm()
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