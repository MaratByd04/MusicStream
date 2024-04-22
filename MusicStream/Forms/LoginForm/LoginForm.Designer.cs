namespace MusicStream
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Button LogInButton;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            MusicStreamLabel = new Label();
            LoginTextBox = new TextBox();
            EnterLabel = new Label();
            PasswordTextBox = new TextBox();
            LoginLabel = new Label();
            PasswordLabel = new Label();
            SignInButton = new Button();
            RegistrationQuestionLabel = new Label();
            LogInButton = new Button();
            SuspendLayout();
            // 
            // LogInButton
            // 
            LogInButton.BackColor = SystemColors.InactiveCaption;
            LogInButton.FlatStyle = FlatStyle.Flat;
            LogInButton.Font = new Font("Modern No. 20", 13.7999992F);
            LogInButton.ForeColor = Color.MidnightBlue;
            LogInButton.Location = new Point(511, 453);
            LogInButton.Margin = new Padding(6, 2, 6, 2);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(242, 64);
            LogInButton.TabIndex = 4;
            LogInButton.Text = "Войти";
            LogInButton.UseVisualStyleBackColor = false;
            LogInButton.Click += LogInButton_Click;
            // 
            // MusicStreamLabel
            // 
            MusicStreamLabel.BackColor = Color.Transparent;
            MusicStreamLabel.Font = new Font("Modern No. 20", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MusicStreamLabel.ForeColor = Color.PaleTurquoise;
            MusicStreamLabel.Location = new Point(259, -3);
            MusicStreamLabel.Margin = new Padding(6, 0, 6, 0);
            MusicStreamLabel.Name = "MusicStreamLabel";
            MusicStreamLabel.Size = new Size(736, 90);
            MusicStreamLabel.TabIndex = 0;
            MusicStreamLabel.Text = "MusicStream";
            MusicStreamLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginTextBox
            // 
            LoginTextBox.BackColor = SystemColors.InactiveCaption;
            LoginTextBox.Font = new Font("Modern No. 20", 18F);
            LoginTextBox.ForeColor = Color.Black;
            LoginTextBox.Location = new Point(200, 243);
            LoginTextBox.Margin = new Padding(6, 2, 6, 2);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.PlaceholderText = "Введите логин";
            LoginTextBox.Size = new Size(869, 40);
            LoginTextBox.TabIndex = 1;
            // 
            // EnterLabel
            // 
            EnterLabel.BackColor = Color.Transparent;
            EnterLabel.Font = new Font("Modern No. 20", 28F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            EnterLabel.ForeColor = Color.PaleTurquoise;
            EnterLabel.Location = new Point(224, 116);
            EnterLabel.Margin = new Padding(6, 0, 6, 0);
            EnterLabel.Name = "EnterLabel";
            EnterLabel.Size = new Size(815, 54);
            EnterLabel.TabIndex = 2;
            EnterLabel.Text = "Войдите в учетную запись";
            EnterLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BackColor = SystemColors.InactiveCaption;
            PasswordTextBox.Font = new Font("Modern No. 20", 18F);
            PasswordTextBox.ForeColor = Color.Black;
            PasswordTextBox.Location = new Point(200, 355);
            PasswordTextBox.Margin = new Padding(6, 2, 6, 2);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.PlaceholderText = "Введите пароль";
            PasswordTextBox.Size = new Size(869, 40);
            PasswordTextBox.TabIndex = 3;
            PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // LoginLabel
            // 
            LoginLabel.BackColor = Color.Transparent;
            LoginLabel.Font = new Font("Modern No. 20", 12F, FontStyle.Bold | FontStyle.Italic);
            LoginLabel.ForeColor = Color.PaleTurquoise;
            LoginLabel.Location = new Point(200, 214);
            LoginLabel.Margin = new Padding(6, 0, 6, 0);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(122, 27);
            LoginLabel.TabIndex = 5;
            LoginLabel.Text = "Логин";
            // 
            // PasswordLabel
            // 
            PasswordLabel.BackColor = Color.Transparent;
            PasswordLabel.Font = new Font("Modern No. 20", 12F, FontStyle.Bold | FontStyle.Italic);
            PasswordLabel.ForeColor = Color.PaleTurquoise;
            PasswordLabel.Location = new Point(200, 326);
            PasswordLabel.Margin = new Padding(6, 0, 6, 0);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(122, 27);
            PasswordLabel.TabIndex = 6;
            PasswordLabel.Text = "Пароль";
            // 
            // SignInButton
            // 
            SignInButton.BackColor = SystemColors.InactiveCaption;
            SignInButton.FlatStyle = FlatStyle.Flat;
            SignInButton.Font = new Font("Modern No. 20", 13.7999992F);
            SignInButton.ForeColor = Color.MidnightBlue;
            SignInButton.Location = new Point(511, 559);
            SignInButton.Margin = new Padding(6, 2, 6, 2);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(242, 70);
            SignInButton.TabIndex = 7;
            SignInButton.Text = "Зарегистрироваться ";
            SignInButton.UseVisualStyleBackColor = false;
            SignInButton.Click += SignInButton_Click;
            // 
            // RegistrationQuestionLabel
            // 
            RegistrationQuestionLabel.BackColor = Color.Transparent;
            RegistrationQuestionLabel.Font = new Font("Modern No. 20", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegistrationQuestionLabel.ForeColor = SystemColors.Control;
            RegistrationQuestionLabel.Location = new Point(511, 533);
            RegistrationQuestionLabel.Name = "RegistrationQuestionLabel";
            RegistrationQuestionLabel.Size = new Size(242, 24);
            RegistrationQuestionLabel.TabIndex = 8;
            RegistrationQuestionLabel.Text = "Вы здесь впервые?";
            RegistrationQuestionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1266, 650);
            Controls.Add(RegistrationQuestionLabel);
            Controls.Add(SignInButton);
            Controls.Add(PasswordLabel);
            Controls.Add(LoginLabel);
            Controls.Add(LogInButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(EnterLabel);
            Controls.Add(LoginTextBox);
            Controls.Add(MusicStreamLabel);
            Font = new Font("Modern No. 20", 12F);
            ForeColor = Color.MidnightBlue;
            KeyPreview = true;
            Margin = new Padding(6, 2, 6, 2);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            FormClosed += this.LoginForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MusicStreamLabel;
        private TextBox LoginTextBox;
        private Label EnterLabel;
        private TextBox PasswordTextBox;
        private Button LogInButton;
        private Label LoginLabel;
        private Label PasswordLabel;
        private Button SignInButton;
        private Label RegistrationQuestionLabel;
    }
}