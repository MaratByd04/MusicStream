namespace MusicStream
{
    partial class RecommendationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecommendationForm));
            GenreComboBox = new ComboBox();
            CountryComboBox = new ComboBox();
            YearsComboBox = new ComboBox();
            MoodComboBox = new ComboBox();
            ResultsListBox = new ListBox();
            SearchButton = new Button();
            DurationComboBox = new ComboBox();
            SaveTrackButton = new Button();
            SuspendLayout();
            // 
            // GenreComboBox
            // 
            GenreComboBox.BackColor = Color.Black;
            GenreComboBox.Font = new Font("Modern No. 20", 14F, FontStyle.Bold);
            GenreComboBox.ForeColor = Color.PaleTurquoise;
            GenreComboBox.FormattingEnabled = true;
            GenreComboBox.Location = new Point(12, 222);
            GenreComboBox.Name = "GenreComboBox";
            GenreComboBox.Size = new Size(224, 33);
            GenreComboBox.TabIndex = 0;
            // 
            // CountryComboBox
            // 
            CountryComboBox.BackColor = Color.Black;
            CountryComboBox.FlatStyle = FlatStyle.Flat;
            CountryComboBox.Font = new Font("Modern No. 20", 14F, FontStyle.Bold);
            CountryComboBox.ForeColor = Color.PaleTurquoise;
            CountryComboBox.FormattingEnabled = true;
            CountryComboBox.Location = new Point(260, 222);
            CountryComboBox.Name = "CountryComboBox";
            CountryComboBox.Size = new Size(224, 33);
            CountryComboBox.TabIndex = 1;
            // 
            // YearsComboBox
            // 
            YearsComboBox.BackColor = Color.Black;
            YearsComboBox.Font = new Font("Modern No. 20", 14F, FontStyle.Bold);
            YearsComboBox.ForeColor = Color.PaleTurquoise;
            YearsComboBox.FormattingEnabled = true;
            YearsComboBox.Location = new Point(510, 222);
            YearsComboBox.Name = "YearsComboBox";
            YearsComboBox.Size = new Size(224, 33);
            YearsComboBox.TabIndex = 2;
            // 
            // MoodComboBox
            // 
            MoodComboBox.BackColor = Color.Black;
            MoodComboBox.Font = new Font("Modern No. 20", 14F, FontStyle.Bold);
            MoodComboBox.ForeColor = Color.PaleTurquoise;
            MoodComboBox.FormattingEnabled = true;
            MoodComboBox.Location = new Point(765, 222);
            MoodComboBox.Name = "MoodComboBox";
            MoodComboBox.Size = new Size(224, 33);
            MoodComboBox.TabIndex = 3;
            // 
            // ResultsListBox
            // 
            ResultsListBox.BackColor = Color.Black;
            ResultsListBox.Font = new Font("Modern No. 20", 14F, FontStyle.Bold);
            ResultsListBox.ForeColor = Color.PaleTurquoise;
            ResultsListBox.FormattingEnabled = true;
            ResultsListBox.ItemHeight = 25;
            ResultsListBox.Location = new Point(12, 306);
            ResultsListBox.Name = "ResultsListBox";
            ResultsListBox.Size = new Size(1231, 204);
            ResultsListBox.TabIndex = 4;
            // 
            // SearchButton
            // 
            SearchButton.FlatStyle = FlatStyle.Flat;
            SearchButton.Font = new Font("Modern No. 20", 14F, FontStyle.Bold);
            SearchButton.ForeColor = Color.PaleTurquoise;
            SearchButton.Location = new Point(949, 565);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(294, 44);
            SearchButton.TabIndex = 5;
            SearchButton.Text = "Поиск";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // DurationComboBox
            // 
            DurationComboBox.BackColor = Color.Black;
            DurationComboBox.Font = new Font("Modern No. 20", 14F, FontStyle.Bold);
            DurationComboBox.ForeColor = Color.PaleTurquoise;
            DurationComboBox.FormattingEnabled = true;
            DurationComboBox.Location = new Point(1015, 222);
            DurationComboBox.Name = "DurationComboBox";
            DurationComboBox.Size = new Size(224, 33);
            DurationComboBox.TabIndex = 6;
            // 
            // SaveTrackButton
            // 
            SaveTrackButton.FlatStyle = FlatStyle.Flat;
            SaveTrackButton.Font = new Font("Modern No. 20", 14F, FontStyle.Bold);
            SaveTrackButton.ForeColor = Color.PaleTurquoise;
            SaveTrackButton.Location = new Point(624, 565);
            SaveTrackButton.Name = "SaveTrackButton";
            SaveTrackButton.Size = new Size(294, 44);
            SaveTrackButton.TabIndex = 7;
            SaveTrackButton.Text = "Сохранить в избранное ";
            SaveTrackButton.UseVisualStyleBackColor = true;
            SaveTrackButton.Click += SaveTrackButton_Click;
            // 
            // RecommendationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1255, 698);
            Controls.Add(SaveTrackButton);
            Controls.Add(DurationComboBox);
            Controls.Add(SearchButton);
            Controls.Add(ResultsListBox);
            Controls.Add(MoodComboBox);
            Controls.Add(YearsComboBox);
            Controls.Add(CountryComboBox);
            Controls.Add(GenreComboBox);
            Name = "RecommendationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Рекомендации";
            FormClosed += this.RecommendationForm_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox GenreComboBox;
        private ComboBox CountryComboBox;
        private ComboBox YearsComboBox;
        private ComboBox MoodComboBox;
        private ListBox ResultsListBox;
        private Button SearchButton;
        private ComboBox DurationComboBox;
        private Button SaveTrackButton;
    }
}