using MusicStream;
using System.Windows.Forms;


namespace MusicStreamTest
{
    [TestClass]
    public class UnitTest1
    {
        // 1 юнит тест

        [TestMethod]
        public void FillUserData_PopulatesTextFieldsWithUserData()
        {
            // Arrange
            var currentUser = new MusicStream.User
            {
                Name = "John Doe",
                Email = "john.doe@example.com",
                Login = "johndoe"
            };
            var profileForm = new ProfileForm(currentUser);

            // Act
            profileForm.FillUserData(currentUser);

            // Assert
            Assert.AreEqual("John Doe", profileForm.ProfileNameTextBox.Text);
            Assert.AreEqual("john.doe@example.com", profileForm.ProfileEmailTextBox.Text);
            Assert.AreEqual("johndoe", profileForm.ProfileLoginTextBox.Text);
        }

        // 2 юнит тест

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

        // 3 юнит тест

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

        // 4 юнит тест

        [TestMethod]
        public void CheckUserCredentials_UserExists_ReturnsUser()
        {
            // Arrange
            var db = new MusicStream.ApplicationContext();
            var login = "user";
            var password = "password";
            var user = new MusicStream.User { Login = login, Password = password };
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

        // 5 юнит тест

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

        // 6 юнит тест

        [TestMethod]
        public void ClearTextBoxes_ClearsAllTextBoxes()
        {
            // Arrange
            var addsongform = new AddSongForm(); // Замените YourForm на имя вашей формы

            addsongform.SongNameTextBox.Text = "Some text";
            addsongform.AuthorTextBox.Text = "Some text";
            addsongform.SongCountryTextBox.Text = "Some text";
            addsongform.SongYearsTextBox.Text = "Some text";
            addsongform.MoodComboBox.Text = "Some text";
            addsongform.DurationComboBox.Text = "Some text";
            addsongform.GenreComboBox.Text = "Some text";

            // Act
            addsongform.ClearTextBoxes();

            // Assert
            Assert.AreEqual(string.Empty, addsongform.SongNameTextBox.Text);
            Assert.AreEqual(string.Empty, addsongform.AuthorTextBox.Text);
            Assert.AreEqual(string.Empty, addsongform.SongCountryTextBox.Text);
            Assert.AreEqual(string.Empty, addsongform.SongYearsTextBox.Text);
            Assert.AreEqual(string.Empty, addsongform.MoodComboBox.Text);
            Assert.AreEqual(string.Empty, addsongform.DurationComboBox.Text);
            Assert.AreEqual(string.Empty, addsongform.GenreComboBox.Text);
        }

        // 7 юнит тест

        [TestMethod]
        public void AllFieldsFilled_WhenNotAllFieldsAreFilled_ShouldReturnFalse()
        {
            // Arrange
            var addsongForm = new AddSongForm(); 

            // Act
            addsongForm.SongNameTextBox.Text = "Song Name"; 
            bool result = addsongForm.AllFieldsFilled();

            // Assert
            Assert.IsFalse(result); 
        }

        // 8 юнит тест

        [TestMethod]
        public void ValidateSongCountry_ValidCountry_ReturnsTrue()
        {
            // Arrange
            var addsongForm = new AddSongForm();
            var songCountry = "USA";

            // Act
            var result = addsongForm.ValidateSongCountry(songCountry);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidateSongCountry_CountryWithDigits_ReturnsFalse()
        {
            // Arrange
            var addsongForm = new AddSongForm();
            var songCountry = "UK2021";

            // Act
            var result = addsongForm.ValidateSongCountry(songCountry);

            // Assert
            Assert.IsFalse(result);
        }

        // 9 юнит тест

        [TestMethod]
        public void ValidateRealSongYears_ValidYears_ReturnsTrue()
        {
            // Arrange
            var addsongForm = new AddSongForm();
            var songYears = "2020";

            // Act
            var result = addsongForm.ValidateSongYears(songYears);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ValidateRealSongYears_InvalidYearsGreaterThan2024_ReturnsFalse()
        {
            // Arrange
            var addsongForm = new AddSongForm();
            var songYears = "2025";

            // Act
            var result = addsongForm.ValidateRealSongYears(songYears);

            // Assert
            Assert.IsFalse(result);
        }

        // 10 юнит тест

        [TestMethod]
        public void ValidateSongYears_InvalidYearsWithLetters_ReturnsFalse()
        {
            // Arrange
            var addsongForm = new AddSongForm();
            var songYears = "Year2021";

            // Act
            var result = addsongForm.ValidateSongYears(songYears);

            // Assert
            Assert.IsFalse(result);
        }
    }
} 