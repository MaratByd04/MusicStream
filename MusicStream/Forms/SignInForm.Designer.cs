namespace MusicStream
{
    partial class SignInForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MusicStreamLabel = new Label();
            EnterLabel = new Label();
            EmailTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            RepeatPasswordTextBox = new TextBox();
            EmailLabel = new Label();
            PasswordLabel = new Label();
            RepeatPasswordLabel = new Label();
            SignInButton = new Button();
            SuspendLayout();
            // 
            // MusicStreamLabel
            // 
            MusicStreamLabel.BackColor = Color.Black;
            MusicStreamLabel.Font = new Font("Modern No. 20", 28.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MusicStreamLabel.ForeColor = Color.PaleTurquoise;
            MusicStreamLabel.Location = new Point(327, 9);
            MusicStreamLabel.Name = "MusicStreamLabel";
            MusicStreamLabel.Size = new Size(534, 98);
            MusicStreamLabel.TabIndex = 0;
            MusicStreamLabel.Text = "MusicStream";
            MusicStreamLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EnterLabel
            // 
            EnterLabel.BackColor = Color.Black;
            EnterLabel.Font = new Font("Modern No. 20", 18F, FontStyle.Bold);
            EnterLabel.ForeColor = Color.PaleTurquoise;
            EnterLabel.Location = new Point(245, 96);
            EnterLabel.Name = "EnterLabel";
            EnterLabel.Size = new Size(678, 66);
            EnterLabel.TabIndex = 1;
            EnterLabel.Text = "Введите свои данные";
            EnterLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EmailTextBox
            // 
            EmailTextBox.BackColor = SystemColors.InactiveCaption;
            EmailTextBox.Font = new Font("Modern No. 20", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmailTextBox.ForeColor = Color.Black;
            EmailTextBox.Location = new Point(41, 233);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.PlaceholderText = "Введите вашу электронную почту";
            EmailTextBox.Size = new Size(1102, 32);
            EmailTextBox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BackColor = SystemColors.InactiveCaption;
            PasswordTextBox.Font = new Font("Modern No. 20", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PasswordTextBox.ForeColor = Color.Black;
            PasswordTextBox.Location = new Point(41, 321);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.PlaceholderText = "Придумайте пароль";
            PasswordTextBox.Size = new Size(1102, 32);
            PasswordTextBox.TabIndex = 3;
            PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // RepeatPasswordTextBox
            // 
            RepeatPasswordTextBox.BackColor = SystemColors.InactiveCaption;
            RepeatPasswordTextBox.Font = new Font("Modern No. 20", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RepeatPasswordTextBox.ForeColor = Color.Black;
            RepeatPasswordTextBox.Location = new Point(41, 405);
            RepeatPasswordTextBox.Name = "RepeatPasswordTextBox";
            RepeatPasswordTextBox.PasswordChar = '*';
            RepeatPasswordTextBox.PlaceholderText = "Повторите пароль";
            RepeatPasswordTextBox.Size = new Size(1102, 32);
            RepeatPasswordTextBox.TabIndex = 4;
            RepeatPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // EmailLabel
            // 
            EmailLabel.BackColor = Color.Transparent;
            EmailLabel.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            EmailLabel.ForeColor = Color.PaleTurquoise;
            EmailLabel.Location = new Point(41, 204);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(169, 26);
            EmailLabel.TabIndex = 5;
            EmailLabel.Text = "Электронная почта";
            // 
            // PasswordLabel
            // 
            PasswordLabel.BackColor = Color.Transparent;
            PasswordLabel.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            PasswordLabel.ForeColor = Color.PaleTurquoise;
            PasswordLabel.Location = new Point(41, 292);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(128, 26);
            PasswordLabel.TabIndex = 6;
            PasswordLabel.Text = "Пароль";
            // 
            // RepeatPasswordLabel
            // 
            RepeatPasswordLabel.BackColor = Color.Transparent;
            RepeatPasswordLabel.Font = new Font("Modern No. 20", 11F, FontStyle.Bold);
            RepeatPasswordLabel.ForeColor = Color.PaleTurquoise;
            RepeatPasswordLabel.Location = new Point(41, 376);
            RepeatPasswordLabel.Name = "RepeatPasswordLabel";
            RepeatPasswordLabel.Size = new Size(203, 26);
            RepeatPasswordLabel.TabIndex = 7;
            RepeatPasswordLabel.Text = "Подтверждение пароля";
            // 
            // SignInButton
            // 
            SignInButton.BackColor = Color.Black;
            SignInButton.FlatStyle = FlatStyle.Flat;
            SignInButton.Font = new Font("Modern No. 20", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignInButton.ForeColor = Color.PaleTurquoise;
            SignInButton.Location = new Point(431, 486);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(270, 62);
            SignInButton.TabIndex = 8;
            SignInButton.Text = "Зарегистрироваться";
            SignInButton.UseVisualStyleBackColor = false;
            SignInButton.Click += SignInButton_Click;
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1191, 594);
            Controls.Add(SignInButton);
            Controls.Add(RepeatPasswordLabel);
            Controls.Add(PasswordLabel);
            Controls.Add(EmailLabel);
            Controls.Add(RepeatPasswordTextBox);
            Controls.Add(PasswordTextBox);
            Controls.Add(EmailTextBox);
            Controls.Add(EnterLabel);
            Controls.Add(MusicStreamLabel);
            Name = "SignInForm";
            Text = "SignInForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MusicStreamLabel;
        private Label EnterLabel;
        private TextBox EmailTextBox;
        private TextBox PasswordTextBox;
        private TextBox RepeatPasswordTextBox;
        private Label EmailLabel;
        private Label PasswordLabel;
        private Label RepeatPasswordLabel;
        private Button SignInButton;
    }
}