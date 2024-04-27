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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // GenreComboBox
            // 
            GenreComboBox.BackColor = Color.Black;
            GenreComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            GenreComboBox.FlatStyle = FlatStyle.Flat;
            GenreComboBox.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
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
            CountryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CountryComboBox.FlatStyle = FlatStyle.Flat;
            CountryComboBox.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
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
            YearsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            YearsComboBox.FlatStyle = FlatStyle.Flat;
            YearsComboBox.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
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
            MoodComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            MoodComboBox.FlatStyle = FlatStyle.Flat;
            MoodComboBox.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
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
            DurationComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DurationComboBox.FlatStyle = FlatStyle.Flat;
            DurationComboBox.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
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
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.2F);
            label1.ForeColor = Color.PaleTurquoise;
            label1.Location = new Point(12, 173);
            label1.Name = "label1";
            label1.Size = new Size(206, 31);
            label1.TabIndex = 8;
            label1.Text = "Выберите жанр";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.ForeColor = Color.PaleTurquoise;
            label2.Location = new Point(765, 173);
            label2.Name = "label2";
            label2.Size = new Size(224, 31);
            label2.TabIndex = 9;
            label2.Text = "Выберите настроение ";
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.ForeColor = Color.PaleTurquoise;
            label3.Location = new Point(510, 173);
            label3.Name = "label3";
            label3.Size = new Size(224, 31);
            label3.TabIndex = 10;
            label3.Text = "Выберите годы";
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.ForeColor = Color.PaleTurquoise;
            label4.Location = new Point(260, 173);
            label4.Name = "label4";
            label4.Size = new Size(206, 31);
            label4.TabIndex = 11;
            label4.Text = "Выберите страну";
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10.2F);
            label5.ForeColor = Color.PaleTurquoise;
            label5.Location = new Point(1015, 173);
            label5.Name = "label5";
            label5.Size = new Size(224, 31);
            label5.TabIndex = 12;
            label5.Text = "Выберите длительность";
            // 
            // RecommendationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1255, 698);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SaveTrackButton);
            Controls.Add(DurationComboBox);
            Controls.Add(SearchButton);
            Controls.Add(ResultsListBox);
            Controls.Add(MoodComboBox);
            Controls.Add(YearsComboBox);
            Controls.Add(CountryComboBox);
            Controls.Add(GenreComboBox);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RecommendationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Рекомендации";
            FormClosed += RecommendationForm_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox GenreComboBox;
        private ComboBox CountryComboBox;
        private ComboBox YearsComboBox;
        private ComboBox MoodComboBox;
        private Button SearchButton;
        private ComboBox DurationComboBox;
        private Button SaveTrackButton;
        public ListBox ResultsListBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}