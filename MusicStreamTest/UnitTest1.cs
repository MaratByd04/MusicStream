using MusicStream;
using System.Windows.Forms;


namespace MusicStreamTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FillUserData_PopulatesTextFieldsWithUserData()
        {
            // Arrange
            var currentUser = new User
            {
                Name = "John Doe",
                Email = "john.doe@example.com",
                Login = "johndoe"
            };
            var profileForm = new ProfileForm(currentUser);

            // Act
            profileForm.FillUserData(currentUser);

            // Assert
            Assert.AreEqual("John Doe", profileForm.NameTextBox.Text);
            Assert.AreEqual("john.doe@example.com", profileForm.EmailTextBox.Text);
            Assert.AreEqual("johndoe", profileForm.LoginTextBox.Text);
        }

        [TestMethod]
        public void CheckPasswordMatch_PasswordsMatch_ReturnsTrue()
        {
            // Arrange
            var form = new Form();
            form.Controls.Add(new TextBox { Name = "PasswordTextBox", Text = "password" });
            form.Controls.Add(new TextBox { Name = "RepeatPasswordTextBox", Text = "password" });

            var formUnderTest = new SignInForm();

            // Act
            var result = formUnderTest.CheckPasswordMatch(form.Controls["PasswordTextBox"].Text, form.Controls["RepeatPasswordTextBox"].Text);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckPasswordMatch_PasswordsMatch_ReturnsFalse()
        {
            // Arrange
            var form = new Form();
            form.Controls.Add(new TextBox { Name = "PasswordTextBox", Text = "passwor" });
            form.Controls.Add(new TextBox { Name = "RepeatPasswordTextBox", Text = "password" });

            var formUnderTest = new SignInForm();

            // Act
            var result = formUnderTest.CheckPasswordMatch(form.Controls["PasswordTextBox"].Text, form.Controls["RepeatPasswordTextBox"].Text);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckEmailValidity_ValidEmail_ReturnsTrue()
        {
            // Arrange
            var formUnderTest = new SignInForm();

            // Act
            var result = formUnderTest.CheckEmailValidity("test@example.com");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckEmailValidity_InvalidEmail_ReturnsFalse()
        {
            // Arrange
            var formUnderTest = new SignInForm();

            // Act
            var result = formUnderTest.CheckEmailValidity("invalidemail");

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckUserCredentials_UserExists_ReturnsUser()
        {
            // Arrange
            var db = new MusicStream.ApplicationContext();
            var login = "testuser";
            var password = "testpassword";
            var user = new User { Login = login, Password = password };
            db.Users.Add(user);
            db.SaveChanges();

            var formUnderTest = new LoginForm();

            // Act
            var result = formUnderTest.CheckUserCredentials(db, login, password);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(login, result.Login);
            Assert.AreEqual(password, result.Password);
        }

        [TestMethod]
        public void GetSelectedSongFromListBox_ReturnsSelectedSong()
        {
            // Arrange
            var listBox = new ListBox();
            var song = new Songs { SongName = "Test Song" };
            listBox.Items.Add(song);
            listBox.SelectedIndex = 0;

            var formUnderTest = new RecommendationForm();
            formUnderTest.ResultsListBox = listBox;

            // Act
            var result = formUnderTest.GetSelectedSongFromListBox();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(song, result);
        }
    }

}