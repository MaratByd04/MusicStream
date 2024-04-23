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
            SadnessPlaylistButton = new Button();
            WorkPlaylistButton = new Button();
            SportPlaylistButton = new Button();
            PlaylistListBox = new ListBox();
            HidePlaylistButton = new Button();
            SaveTrackButton = new Button();
            SuspendLayout();
            // 
            // RecommendationButton
            // 
            RecommendationButton.FlatStyle = FlatStyle.Flat;
            RecommendationButton.Font = new Font("Modern No. 20", 13.7999992F, FontStyle.Bold);
            RecommendationButton.ForeColor = Color.PaleTurquoise;
            RecommendationButton.Location = new Point(31, 98);
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
            TrackListButton.Location = new Point(310, 96);
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
            CreateSongButton.Location = new Point(588, 96);
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
            ProfileButton.Location = new Point(867, 96);
            ProfileButton.Name = "ProfileButton";
            ProfileButton.Size = new Size(260, 65);
            ProfileButton.TabIndex = 3;
            ProfileButton.Text = "Профиль";
            ProfileButton.UseVisualStyleBackColor = true;
            ProfileButton.Click += ProfileButton_Click;
            // 
            // SadnessPlaylistButton
            // 
            SadnessPlaylistButton.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SadnessPlaylistButton.ForeColor = SystemColors.ActiveCaptionText;
            SadnessPlaylistButton.Image = (Image)resources.GetObject("SadnessPlaylistButton.Image");
            SadnessPlaylistButton.Location = new Point(128, 227);
            SadnessPlaylistButton.Margin = new Padding(30, 10, 30, 10);
            SadnessPlaylistButton.Name = "SadnessPlaylistButton";
            SadnessPlaylistButton.Size = new Size(259, 269);
            SadnessPlaylistButton.TabIndex = 1;
            SadnessPlaylistButton.Text = "Погрустить";
            SadnessPlaylistButton.TextAlign = ContentAlignment.BottomCenter;
            SadnessPlaylistButton.UseVisualStyleBackColor = true;
            SadnessPlaylistButton.Click += SadnessPlaylistButton_Click;
            // 
            // WorkPlaylistButton
            // 
            WorkPlaylistButton.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            WorkPlaylistButton.ForeColor = SystemColors.ActiveCaptionText;
            WorkPlaylistButton.Image = (Image)resources.GetObject("WorkPlaylistButton.Image");
            WorkPlaylistButton.Location = new Point(447, 227);
            WorkPlaylistButton.Margin = new Padding(30, 10, 30, 10);
            WorkPlaylistButton.Name = "WorkPlaylistButton";
            WorkPlaylistButton.Size = new Size(274, 269);
            WorkPlaylistButton.TabIndex = 2;
            WorkPlaylistButton.Text = "Для работы";
            WorkPlaylistButton.TextAlign = ContentAlignment.BottomCenter;
            WorkPlaylistButton.UseVisualStyleBackColor = true;
            WorkPlaylistButton.Click += WorkPlaylistButton_Click;
            // 
            // SportPlaylistButton
            // 
            SportPlaylistButton.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SportPlaylistButton.ForeColor = SystemColors.ActiveCaptionText;
            SportPlaylistButton.Image = (Image)resources.GetObject("SportPlaylistButton.Image");
            SportPlaylistButton.Location = new Point(781, 227);
            SportPlaylistButton.Margin = new Padding(30, 10, 30, 10);
            SportPlaylistButton.Name = "SportPlaylistButton";
            SportPlaylistButton.Size = new Size(277, 269);
            SportPlaylistButton.TabIndex = 0;
            SportPlaylistButton.Text = "Для спорта";
            SportPlaylistButton.TextAlign = ContentAlignment.BottomCenter;
            SportPlaylistButton.UseVisualStyleBackColor = true;
            SportPlaylistButton.Click += SportPlaylistButton_Click;
            // 
            // PlaylistListBox
            // 
            PlaylistListBox.BackColor = Color.Black;
            PlaylistListBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PlaylistListBox.ForeColor = Color.PaleTurquoise;
            PlaylistListBox.FormattingEnabled = true;
            PlaylistListBox.ItemHeight = 37;
            PlaylistListBox.Location = new Point(31, 188);
            PlaylistListBox.Name = "PlaylistListBox";
            PlaylistListBox.Size = new Size(1093, 337);
            PlaylistListBox.TabIndex = 4;
            PlaylistListBox.Visible = false;
            // 
            // HidePlaylistButton
            // 
            HidePlaylistButton.BackColor = Color.Black;
            HidePlaylistButton.ForeColor = Color.PaleTurquoise;
            HidePlaylistButton.Location = new Point(1023, 188);
            HidePlaylistButton.Name = "HidePlaylistButton";
            HidePlaylistButton.Size = new Size(101, 29);
            HidePlaylistButton.TabIndex = 5;
            HidePlaylistButton.Text = "Свернуть";
            HidePlaylistButton.UseVisualStyleBackColor = false;
            HidePlaylistButton.Visible = false;
            HidePlaylistButton.Click += HidePlaylistButton_Click;
            // 
            // SaveTrackButton
            // 
            SaveTrackButton.BackColor = Color.Black;
            SaveTrackButton.ForeColor = Color.PaleTurquoise;
            SaveTrackButton.Location = new Point(31, 548);
            SaveTrackButton.Name = "SaveTrackButton";
            SaveTrackButton.Size = new Size(208, 60);
            SaveTrackButton.TabIndex = 6;
            SaveTrackButton.Text = "Добавить в избранное";
            SaveTrackButton.UseVisualStyleBackColor = false;
            SaveTrackButton.Visible = false;
            SaveTrackButton.Click += SaveTrackButton_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1168, 667);
            Controls.Add(SaveTrackButton);
            Controls.Add(HidePlaylistButton);
            Controls.Add(SadnessPlaylistButton);
            Controls.Add(WorkPlaylistButton);
            Controls.Add(ProfileButton);
            Controls.Add(SportPlaylistButton);
            Controls.Add(CreateSongButton);
            Controls.Add(TrackListButton);
            Controls.Add(RecommendationButton);
            Controls.Add(PlaylistListBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuForm";
            FormClosed += MenuForm_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Button RecommendationButton;
        private Button TrackListButton;
        private Button CreateSongButton;
        private Button ProfileButton;
        private Button SportPlaylistButton;
        private Button SadnessPlaylistButton;
        private Button WorkPlaylistButton;
        private ListBox PlaylistListBox;
        private Button HidePlaylistButton;
        private Button SaveTrackButton;
    }
}