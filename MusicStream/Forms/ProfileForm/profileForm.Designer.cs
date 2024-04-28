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
            ProfileNameLabel = new Label();
            ProfileLoginLabel = new Label();
            ProfileEmailLabel = new Label();
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
            // ChangePhotoButton
            // 
            ChangePhotoButton.Location = new Point(57, 378);
            ChangePhotoButton.Name = "ChangePhotoButton";
            ChangePhotoButton.Size = new Size(213, 56);
            ChangePhotoButton.TabIndex = 1;
            ChangePhotoButton.Text = "Изменить фото";
            ChangePhotoButton.UseVisualStyleBackColor = true;
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
            // 
            // ProfileNameLabel
            // 
            ProfileNameLabel.Location = new Point(392, 233);
            ProfileNameLabel.Name = "ProfileNameLabel";
            ProfileNameLabel.Size = new Size(493, 28);
            ProfileNameLabel.TabIndex = 9;
            // 
            // ProfileLoginLabel
            // 
            ProfileLoginLabel.Location = new Point(392, 315);
            ProfileLoginLabel.Name = "ProfileLoginLabel";
            ProfileLoginLabel.Size = new Size(493, 28);
            ProfileLoginLabel.TabIndex = 10;
            // 
            // ProfileEmailLabel
            // 
            ProfileEmailLabel.Location = new Point(392, 406);
            ProfileEmailLabel.Name = "ProfileEmailLabel";
            ProfileEmailLabel.Size = new Size(493, 28);
            ProfileEmailLabel.TabIndex = 11;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(954, 710);
            Controls.Add(ProfileEmailLabel);
            Controls.Add(ProfileLoginLabel);
            Controls.Add(ProfileNameLabel);
            Controls.Add(EditProfileDataButton);
            Controls.Add(EmailLabel);
            Controls.Add(LoginLabel);
            Controls.Add(NameLabel);
            Controls.Add(ChangePhotoButton);
            Controls.Add(ProfilePictureBox);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Профиль";
            FormClosing += ProfileForm_FormClosing;
            Load += ProfileForm_Load;
            ((System.ComponentModel.ISupportInitialize)ProfilePictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ProfilePictureBox;
        private Button ChangePhotoButton;
        private Label NameLabel;
        private Label LoginLabel;
        private Label EmailLabel;
        private Button EditProfileDataButton;
        private Label ProfileNameLabel;
        private Label ProfileLoginLabel;
        private Label ProfileEmailLabel;
    }
}