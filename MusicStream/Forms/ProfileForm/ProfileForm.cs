namespace MusicStream
{
    public partial class ProfileForm : Form
    {
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
                MessageBox.Show("эта тварь уходит в нул");
            }
        }    
        private void EditProfileDataButton_Click(object sender, EventArgs e)
        {
            using(var db = new ApplicationContext())
            {
                var name = NameTextBox.Text;
                if(currentUser != null)
                {
                    currentUser.Name = name;
                    MessageBox.Show("Данные успешно обновлены");
                    db.SaveChanges();
                }    
            }
        }
    }
}
