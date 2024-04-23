namespace MusicStream
{
    partial class AddSongForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSongForm));
            SongNameTextBox = new TextBox();
            SongCountryTextBox = new TextBox();
            SongYearsTextBox = new TextBox();
            MoodTextBox = new TextBox();
            DurationTextBox = new TextBox();
            GenreTextBox = new TextBox();
            AuthorTextBox = new TextBox();
            SuspendLayout();
            // 
            // SongNameTextBox
            // 
            SongNameTextBox.Location = new Point(251, 66);
            SongNameTextBox.Name = "SongNameTextBox";
            SongNameTextBox.Size = new Size(643, 27);
            SongNameTextBox.TabIndex = 0;
            // 
            // SongCountryTextBox
            // 
            SongCountryTextBox.Location = new Point(251, 284);
            SongCountryTextBox.Name = "SongCountryTextBox";
            SongCountryTextBox.Size = new Size(643, 27);
            SongCountryTextBox.TabIndex = 1;
            // 
            // SongYearsTextBox
            // 
            SongYearsTextBox.Location = new Point(251, 361);
            SongYearsTextBox.Name = "SongYearsTextBox";
            SongYearsTextBox.Size = new Size(643, 27);
            SongYearsTextBox.TabIndex = 2;
            // 
            // MoodTextBox
            // 
            MoodTextBox.Location = new Point(251, 433);
            MoodTextBox.Name = "MoodTextBox";
            MoodTextBox.Size = new Size(643, 27);
            MoodTextBox.TabIndex = 3;
            // 
            // DurationTextBox
            // 
            DurationTextBox.Location = new Point(251, 504);
            DurationTextBox.Name = "DurationTextBox";
            DurationTextBox.Size = new Size(643, 27);
            DurationTextBox.TabIndex = 4;
            // 
            // GenreTextBox
            // 
            GenreTextBox.Location = new Point(251, 210);
            GenreTextBox.Name = "GenreTextBox";
            GenreTextBox.Size = new Size(643, 27);
            GenreTextBox.TabIndex = 5;
            // 
            // AuthorTextBox
            // 
            AuthorTextBox.Location = new Point(251, 135);
            AuthorTextBox.Name = "AuthorTextBox";
            AuthorTextBox.Size = new Size(643, 27);
            AuthorTextBox.TabIndex = 6;
            // 
            // AddSongForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1173, 584);
            Controls.Add(AuthorTextBox);
            Controls.Add(GenreTextBox);
            Controls.Add(DurationTextBox);
            Controls.Add(MoodTextBox);
            Controls.Add(SongYearsTextBox);
            Controls.Add(SongCountryTextBox);
            Controls.Add(SongNameTextBox);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddSongForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosing += AddSongForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SongNameTextBox;
        private TextBox SongCountryTextBox;
        private TextBox SongYearsTextBox;
        private TextBox MoodTextBox;
        private TextBox DurationTextBox;
        private TextBox GenreTextBox;
        private TextBox AuthorTextBox;
    }
}