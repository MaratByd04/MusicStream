namespace MusicStream
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                // ������� ��� ������� User
                User _Marat = new User { Name = "�����", Login = "marat", Email = "marat@gmail.com" };
                User _Roman = new User { Name = "�����", Login = "roman", Email = "roman@gmail.com" };

                // ��������� �� � ��
                db.Users.Add(_Marat);
                db.Users.Add(_Roman);
                db.SaveChanges();

                // �������� ������� �� ���� ������
                var users = db.Users.ToList();

            }
        }
    }
}