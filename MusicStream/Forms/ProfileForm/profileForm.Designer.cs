namespace MusicStream
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            ProfilePictureBox = new PictureBox();
            ChangePhotoButton = new Button();
            NameLabel = new Label();
            LoginLabel = new Label();
            EmailLabel = new Label();
            EditProfileDataButton = new Button();
            ProfileNameTextBox = new TextBox();
            ProfileLoginTextBox = new TextBox();
            ProfileEmailTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ProfilePictureBox).BeginInit();
            SuspendLayout();
            // 
            // ProfilePictureBox
            // 
            ProfilePictureBox.Location = new Point(34, 116);
            ProfilePictureBox.Margin = new Padding(3, 2, 3, 2);
            ProfilePictureBox.Name = "ProfilePictureBox";
            ProfilePictureBox.Size = new Size(220, 141);
            ProfilePictureBox.TabIndex = 0;
            ProfilePictureBox.TabStop = false;
            // 
            // ChangePhotoButton
            // 
            ChangePhotoButton.Location = new Point(50, 284);
            ChangePhotoButton.Margin = new Padding(3, 2, 3, 2);
            ChangePhotoButton.Name = "ChangePhotoButton";
            ChangePhotoButton.Size = new Size(186, 42);
            ChangePhotoButton.TabIndex = 1;
            ChangePhotoButton.Text = "Изменить фото";
            ChangePhotoButton.UseVisualStyleBackColor = true;
            // 
            // NameLabel
            // 
            NameLabel.BackColor = Color.Transparent;
            NameLabel.ForeColor = Color.PaleTurquoise;
            NameLabel.Location = new Point(343, 148);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(126, 16);
            NameLabel.TabIndex = 5;
            NameLabel.Text = "Имя";
            // 
            // LoginLabel
            // 
            LoginLabel.BackColor = Color.Transparent;
            LoginLabel.ForeColor = Color.PaleTurquoise;
            LoginLabel.Location = new Point(343, 214);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(126, 16);
            LoginLabel.TabIndex = 6;
            LoginLabel.Text = "Логин";
            // 
            // EmailLabel
            // 
            EmailLabel.BackColor = Color.Transparent;
            EmailLabel.ForeColor = Color.PaleTurquoise;
            EmailLabel.Location = new Point(343, 285);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(126, 16);
            EmailLabel.TabIndex = 7;
            EmailLabel.Text = "Почта";
            // 
            // EditProfileDataButton
            // 
            EditProfileDataButton.Location = new Point(420, 346);
            EditProfileDataButton.Margin = new Padding(3, 2, 3, 2);
            EditProfileDataButton.Name = "EditProfileDataButton";
            EditProfileDataButton.Size = new Size(254, 28);
            EditProfileDataButton.TabIndex = 8;
            EditProfileDataButton.Text = "Редактировать профиль";
            EditProfileDataButton.Click += EditProfileDataButton_Click;
            // 
            // ProfileNameTextBox
            // 
            ProfileNameTextBox.Location = new Point(343, 176);
            ProfileNameTextBox.Margin = new Padding(3, 2, 3, 2);
            ProfileNameTextBox.Name = "ProfileNameTextBox";
            ProfileNameTextBox.Size = new Size(432, 23);
            ProfileNameTextBox.TabIndex = 12;
            // 
            // ProfileLoginTextBox
            // 
            ProfileLoginTextBox.Location = new Point(343, 237);
            ProfileLoginTextBox.Margin = new Padding(3, 2, 3, 2);
            ProfileLoginTextBox.Name = "ProfileLoginTextBox";
            ProfileLoginTextBox.Size = new Size(432, 23);
            ProfileLoginTextBox.TabIndex = 13;
            // 
            // ProfileEmailTextBox
            // 
            ProfileEmailTextBox.Location = new Point(343, 304);
            ProfileEmailTextBox.Margin = new Padding(3, 2, 3, 2);
            ProfileEmailTextBox.Name = "ProfileEmailTextBox";
            ProfileEmailTextBox.Size = new Size(432, 23);
            ProfileEmailTextBox.TabIndex = 14;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(835, 532);
            Controls.Add(ProfileEmailTextBox);
            Controls.Add(ProfileLoginTextBox);
            Controls.Add(ProfileNameTextBox);
            Controls.Add(EditProfileDataButton);
            Controls.Add(EmailLabel);
            Controls.Add(LoginLabel);
            Controls.Add(NameLabel);
            Controls.Add(ChangePhotoButton);
            Controls.Add(ProfilePictureBox);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Профиль";
            FormClosing += ProfileForm_FormClosing;
            Load += ProfileForm_Load;
            ((System.ComponentModel.ISupportInitialize)ProfilePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ProfilePictureBox;
        private Button ChangePhotoButton;
        private Label NameLabel;
        private Label LoginLabel;
        private Label EmailLabel;
        private Button EditProfileDataButton;
        public TextBox ProfileLoginTextBox;
        public TextBox ProfileEmailTextBox;
        public TextBox ProfileNameTextBox;
    }
}