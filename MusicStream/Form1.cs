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
                // создаем два объекта User
                User _Marat = new User { Name = "Марат", Login = "marat", Email = "marat@gmail.com" };
                User _Roman = new User { Name = "Роман", Login = "roman", Email = "roman@gmail.com" };

                // добавляем их в бд
                db.Users.Add(_Marat);
                db.Users.Add(_Roman);
                db.SaveChanges();

                // Получаем объекты из базы данных
                var users = db.Users.ToList();

            }
        }
    }
}