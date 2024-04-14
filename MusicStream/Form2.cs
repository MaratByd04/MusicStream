using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicStream
{
    public partial class Form2 : Form
    {
        private ApplicationContext db;
        public Form2()
        {
            InitializeComponent();

            // Создание контекста базы данных
            db = new ApplicationContext();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Проверяем, был ли объект db инициализирован
            if (db != null)
            {
                // Выполняем запрос для получения всех пользователей и их песен
                var query = from user in db.Users
                            from song in user.Songs
                            select new
                            {
                                UserName = user.Name,
                                SongTitle = song.SongName
                            };

                // Выводим результаты на форму или делаем с ними что-то другое
                foreach (var result in query)
                {
                    // Например, выводим результаты в текстовое поле
                    textBox1.Text += $"User: {result.UserName}, Song: {result.SongTitle}{Environment.NewLine}";
                }
            }
            else
            {
                // Обработка случая, когда объект db не был инициализирован
                MessageBox.Show("Ошибка: объект db не был инициализирован.");
            }
        }
    }
}
