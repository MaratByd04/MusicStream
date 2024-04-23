using MusicStream.Forms.MenuForm;

namespace MusicStream
{
    public partial class LoginForm : Form
    {
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
        private void LogInButton_Click(object sender, EventArgs e)
        {
            using(var db = new ApplicationContext())
            {
                var login = LoginTextBox.Text;
                var password = PasswordTextBox.Text;

                // �������� �� ������������� ������������ 
                var user = db.Users.FirstOrDefault(u => u.Login == login && u.Password == password);

                if (user != null)
                {
                    PasswordTextBox.Clear();

                    var menuForm = new MenuForm(user);
                    menuForm.Show();

                    this.Hide();   
                }
                else
                {
                    MessageBox.Show("�������� ����� ��� ������!", "������ �����������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    PasswordTextBox.Clear();
                }
            }   
        }
        private void SignInButton_Click(object sender, EventArgs e)
        {
            var signInForm = new SignInForm();
            signInForm.Show();
            this.Hide();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}