﻿using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using NLog;
using System.Xml.Linq;

namespace MusicStream
{
    public partial class ProfileForm : Form
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        private User currentUser;
        private ApplicationContext db;

        public ProfileForm(User user, ApplicationContext db)
        {
            InitializeComponent();
            currentUser = user;
            this.db = db;
        }

        public void FillUserData(User currentUser)
        {
            NameTextBox.Text = currentUser.Name ?? string.Empty;
            EmailTextBox.Text = currentUser.Email ?? string.Empty;
            LoginTextBox.Text = currentUser.Login ?? string.Empty;
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            if (currentUser != null)
            {
                FillUserData(currentUser);
            }
            else
            {
                MessageBox.Show("Пользователь - null");
            }
        }

        private void EditProfileDataButton_Click(object sender, EventArgs e)
        {
            if (currentUser != null)
            {
                try
                {
                    currentUser.Name = NameTextBox.Text;
                    currentUser.Email = EmailTextBox.Text;
                    currentUser.Login = LoginTextBox.Text;

                    db.SaveChanges();

                    logger.Info($"Пользователь {currentUser.Login} обновил свои данные");

                    MessageBox.Show("Данные успешно обновлены");
                }
                catch (Exception ex)
                {
                    logger.Error($"Ошибка при обновлении данных пользователя: {ex.Message}");
                    MessageBox.Show("Произошла ошибка при обновлении данных. Пожалуйста, попробуйте еще раз.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("User - null");
            }
        }

        private void ChangePhotoButton_Click(object sender, EventArgs e)
        {
            // Открываем диалог выбора файла для выбора изображения
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.gif)|*.jpg; *.jpeg; *.png; *.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Считываем данные изображения в виде массива байт
                byte[] photoBytes = File.ReadAllBytes(openFileDialog.FileName);

                // Сохраняем данные изображения в свойство пользователя Photo
                currentUser.Photo = photoBytes;

                // Отображаем выбранное изображение на форме
                ProfilePictureBox.Image = Image.FromStream(new MemoryStream(photoBytes));
            }
        }

        private void ProfileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var menuForm = new MenuForm(currentUser);
            menuForm.Show();
            this.Hide();
        }
    }
}