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
            EditProfilePicture = new Button();
            NameTextBox = new TextBox();
            EmailTextBox = new TextBox();
            LoginTextBox = new TextBox();
            NameLabel = new Label();
            LoginLabel = new Label();
            EmailLabel = new Label();
            EditProfileDataButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ProfilePictureBox).BeginInit();
            SuspendLayout();
            // 
            // ProfilePictureBox
            // 
            ProfilePictureBox.Location = new Point(39, 155);
            ProfilePictureBox.Name = "ProfilePictureBox";
            ProfilePictureBox.Size = new Size(251, 188);
            ProfilePictureBox.TabIndex = 0;
            ProfilePictureBox.TabStop = false;
            // 
            // EditProfilePicture
            // 
            EditProfilePicture.Location = new Point(57, 378);
            EditProfilePicture.Name = "EditProfilePicture";
            EditProfilePicture.Size = new Size(213, 56);
            EditProfilePicture.TabIndex = 1;
            EditProfilePicture.Text = "Изменить фото";
            EditProfilePicture.UseVisualStyleBackColor = true;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(392, 235);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(496, 27);
            NameTextBox.TabIndex = 2;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(392, 410);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(496, 27);
            EmailTextBox.TabIndex = 3;
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(392, 321);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(496, 27);
            LoginTextBox.TabIndex = 4;
            // 
            // NameLabel
            // 
            NameLabel.BackColor = Color.Transparent;
            NameLabel.ForeColor = Color.PaleTurquoise;
            NameLabel.Location = new Point(392, 197);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(144, 22);
            NameLabel.TabIndex = 5;
            NameLabel.Text = "Имя";
            // 
            // LoginLabel
            // 
            LoginLabel.BackColor = Color.Transparent;
            LoginLabel.ForeColor = Color.PaleTurquoise;
            LoginLabel.Location = new Point(392, 286);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(144, 22);
            LoginLabel.TabIndex = 6;
            LoginLabel.Text = "Логин";
            // 
            // EmailLabel
            // 
            EmailLabel.BackColor = Color.Transparent;
            EmailLabel.ForeColor = Color.PaleTurquoise;
            EmailLabel.Location = new Point(392, 380);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(144, 22);
            EmailLabel.TabIndex = 7;
            EmailLabel.Text = "Почта";
            // 
            // EditProfileDataButton
            // 
            EditProfileDataButton.Location = new Point(480, 461);
            EditProfileDataButton.Name = "EditProfileDataButton";
            EditProfileDataButton.Size = new Size(290, 37);
            EditProfileDataButton.TabIndex = 8;
            EditProfileDataButton.Text = "Редактировать профиль";
            EditProfileDataButton.Click += EditProfileDataButton_Click;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(954, 710);
            Controls.Add(EditProfileDataButton);
            Controls.Add(EmailLabel);
            Controls.Add(LoginLabel);
            Controls.Add(NameLabel);
            Controls.Add(LoginTextBox);
            Controls.Add(EmailTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(EditProfilePicture);
            Controls.Add(ProfilePictureBox);
            Name = "ProfileForm";
            Text = "Профиль";
            FormClosing += this.ProfileForm_FormClosing;
            Load += ProfileForm_Load;
            ((System.ComponentModel.ISupportInitialize)ProfilePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ProfilePictureBox;
        private Button EditProfilePicture;
        private TextBox NameTextBox;
        private TextBox EmailTextBox;
        private TextBox LoginTextBox;
        private Label NameLabel;
        private Label LoginLabel;
        private Label EmailLabel;
        private Button EditProfileDataButton;
    }
}