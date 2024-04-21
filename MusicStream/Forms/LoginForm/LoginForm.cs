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
                var login = LoginTextBox.Text;
                var password = PasswordTextBox.Text;

                // �������� �� ������������� ������������ 
                var user = db.Users.FirstOrDefault(u => u.Login == login && u.Password == password);

                if (user != null)
                {
                    PasswordTextBox.Clear();

                    var menuForm = new MenuForm(user);
                    menuForm.Show();

                    menuForm.CurrentUser = user; // ���������� ��������� ������������

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
        }
    }
}