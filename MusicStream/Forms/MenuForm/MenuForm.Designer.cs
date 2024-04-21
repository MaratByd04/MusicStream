namespace MusicStream
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            RecommendationButton = new Button();
            TrackListButton = new Button();
            CreateSongButton = new Button();
            ProfileButton = new Button();
            SuspendLayout();
            // 
            // RecommendationButton
            // 
            RecommendationButton.FlatStyle = FlatStyle.Flat;
            RecommendationButton.Font = new Font("Modern No. 20", 13.7999992F, FontStyle.Bold);
            RecommendationButton.ForeColor = Color.PaleTurquoise;
            RecommendationButton.Location = new Point(12, 184);
            RecommendationButton.Name = "RecommendationButton";
            RecommendationButton.Size = new Size(260, 65);
            RecommendationButton.TabIndex = 0;
            RecommendationButton.Text = "Посмотреть рекомендации";
            RecommendationButton.UseVisualStyleBackColor = true;
            RecommendationButton.Click += RecommendationButton_Click;
            // 
            // TrackListButton
            // 
            TrackListButton.FlatStyle = FlatStyle.Flat;
            TrackListButton.Font = new Font("Modern No. 20", 13.7999992F, FontStyle.Bold);
            TrackListButton.ForeColor = Color.PaleTurquoise;
            TrackListButton.Location = new Point(12, 293);
            TrackListButton.Name = "TrackListButton";
            TrackListButton.Size = new Size(260, 65);
            TrackListButton.TabIndex = 1;
            TrackListButton.Text = "Избранное";
            TrackListButton.UseVisualStyleBackColor = true;
            TrackListButton.Click += TrackListButton_Click;
            // 
            // CreateSongButton
            // 
            CreateSongButton.FlatStyle = FlatStyle.Flat;
            CreateSongButton.Font = new Font("Modern No. 20", 13.7999992F, FontStyle.Bold);
            CreateSongButton.ForeColor = Color.PaleTurquoise;
            CreateSongButton.Location = new Point(12, 397);
            CreateSongButton.Name = "CreateSongButton";
            CreateSongButton.Size = new Size(260, 67);
            CreateSongButton.TabIndex = 2;
            CreateSongButton.Text = "Добавить композицию в список сервиса";
            CreateSongButton.UseVisualStyleBackColor = true;
            CreateSongButton.Click += CreateSongButton_Click;
            // 
            // ProfileButton
            // 
            ProfileButton.FlatStyle = FlatStyle.Flat;
            ProfileButton.Font = new Font("Modern No. 20", 13.7999992F, FontStyle.Bold);
            ProfileButton.ForeColor = Color.PaleTurquoise;
            ProfileButton.Location = new Point(12, 503);
            ProfileButton.Name = "ProfileButton";
            ProfileButton.Size = new Size(260, 65);
            ProfileButton.TabIndex = 3;
            ProfileButton.Text = "Профиль";
            ProfileButton.UseVisualStyleBackColor = true;
            ProfileButton.Click += ProfileButton_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1168, 667);
            Controls.Add(ProfileButton);
            Controls.Add(CreateSongButton);
            Controls.Add(TrackListButton);
            Controls.Add(RecommendationButton);
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuForm";
            FormClosing += this.MenuForm_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button RecommendationButton;
        private Button TrackListButton;
        private Button CreateSongButton;
        private Button ProfileButton;
    }
}