namespace MusicStream
{
    partial class SavedSongsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SavedSongsForm));
            SavedTracksListBox = new ListBox();
            DeleteSongButton = new Button();
            SuspendLayout();
            // 
            // SavedTracksListBox
            // 
            SavedTracksListBox.BackColor = Color.Black;
            SavedTracksListBox.Font = new Font("Modern No. 20", 13.7999992F, FontStyle.Bold);
            SavedTracksListBox.ForeColor = Color.PaleTurquoise;
            SavedTracksListBox.FormattingEnabled = true;
            SavedTracksListBox.ItemHeight = 25;
            SavedTracksListBox.Location = new Point(12, 150);
            SavedTracksListBox.Name = "SavedTracksListBox";
            SavedTracksListBox.Size = new Size(1131, 254);
            SavedTracksListBox.TabIndex = 0;
            // 
            // DeleteSongButton
            // 
            DeleteSongButton.BackColor = Color.Black;
            DeleteSongButton.FlatStyle = FlatStyle.Flat;
            DeleteSongButton.Font = new Font("Modern No. 20", 13.7999992F, FontStyle.Bold);
            DeleteSongButton.ForeColor = Color.PaleTurquoise;
            DeleteSongButton.Location = new Point(850, 500);
            DeleteSongButton.Name = "DeleteSongButton";
            DeleteSongButton.Size = new Size(293, 62);
            DeleteSongButton.TabIndex = 2;
            DeleteSongButton.Text = "Удалить трек";
            DeleteSongButton.UseVisualStyleBackColor = false;
            DeleteSongButton.Visible = false;
            DeleteSongButton.Click += DeleteSongButton_Click;
            // 
            // SavedSongsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1155, 679);
            Controls.Add(DeleteSongButton);
            Controls.Add(SavedTracksListBox);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SavedSongsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Мои треки";
            FormClosing += SavedSongsForm_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private ListBox SavedTracksListBox;
        private Button DeleteSongButton;
    }
}