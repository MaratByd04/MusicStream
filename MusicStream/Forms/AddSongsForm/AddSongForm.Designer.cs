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
            AuthorTextBox = new TextBox();
            SongNameLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            AddNewSongButton = new Button();
            GenreComboBox = new ComboBox();
            MoodComboBox = new ComboBox();
            DurationComboBox = new ComboBox();
            SuspendLayout();
            // 
            // SongNameTextBox
            // 
            SongNameTextBox.Location = new Point(101, 138);
            SongNameTextBox.Margin = new Padding(3, 2, 3, 2);
            SongNameTextBox.Name = "SongNameTextBox";
            SongNameTextBox.Size = new Size(563, 23);
            SongNameTextBox.TabIndex = 0;
            // 
            // SongCountryTextBox
            // 
            SongCountryTextBox.Location = new Point(101, 302);
            SongCountryTextBox.Margin = new Padding(3, 2, 3, 2);
            SongCountryTextBox.Name = "SongCountryTextBox";
            SongCountryTextBox.Size = new Size(563, 23);
            SongCountryTextBox.TabIndex = 1;
            // 
            // SongYearsTextBox
            // 
            SongYearsTextBox.Location = new Point(101, 359);
            SongYearsTextBox.Margin = new Padding(3, 2, 3, 2);
            SongYearsTextBox.Name = "SongYearsTextBox";
            SongYearsTextBox.Size = new Size(563, 23);
            SongYearsTextBox.TabIndex = 2;
            // 
            // AuthorTextBox
            // 
            AuthorTextBox.Location = new Point(101, 190);
            AuthorTextBox.Margin = new Padding(3, 2, 3, 2);
            AuthorTextBox.Name = "AuthorTextBox";
            AuthorTextBox.Size = new Size(563, 23);
            AuthorTextBox.TabIndex = 6;
            // 
            // SongNameLabel
            // 
            SongNameLabel.BackColor = Color.Transparent;
            SongNameLabel.ForeColor = Color.PaleTurquoise;
            SongNameLabel.Location = new Point(101, 116);
            SongNameLabel.Name = "SongNameLabel";
            SongNameLabel.Size = new Size(161, 20);
            SongNameLabel.TabIndex = 7;
            SongNameLabel.Text = "Введите название песни";
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.PaleTurquoise;
            label1.Location = new Point(101, 168);
            label1.Name = "label1";
            label1.Size = new Size(161, 20);
            label1.TabIndex = 8;
            label1.Text = "Введите автора песни";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.PaleTurquoise;
            label2.Location = new Point(101, 338);
            label2.Name = "label2";
            label2.Size = new Size(181, 20);
            label2.TabIndex = 9;
            label2.Text = "Введите годы выхода песни";
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.PaleTurquoise;
            label3.Location = new Point(101, 280);
            label3.Name = "label3";
            label3.Size = new Size(161, 20);
            label3.TabIndex = 10;
            label3.Text = "Введите страну песни";
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.PaleTurquoise;
            label4.Location = new Point(101, 224);
            label4.Name = "label4";
            label4.Size = new Size(161, 20);
            label4.TabIndex = 11;
            label4.Text = "Введите жанр песни";
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.PaleTurquoise;
            label5.Location = new Point(101, 392);
            label5.Name = "label5";
            label5.Size = new Size(344, 20);
            label5.TabIndex = 12;
            label5.Text = "Введите настроение под которое вы бы это включили песни";
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.ForeColor = Color.PaleTurquoise;
            label6.Location = new Point(101, 445);
            label6.Name = "label6";
            label6.Size = new Size(232, 20);
            label6.TabIndex = 13;
            label6.Text = "Введите продолжительность песни";
            // 
            // AddNewSongButton
            // 
            AddNewSongButton.BackColor = Color.Black;
            AddNewSongButton.ForeColor = Color.PaleTurquoise;
            AddNewSongButton.Location = new Point(716, 445);
            AddNewSongButton.Margin = new Padding(3, 2, 3, 2);
            AddNewSongButton.Name = "AddNewSongButton";
            AddNewSongButton.Size = new Size(225, 42);
            AddNewSongButton.TabIndex = 14;
            AddNewSongButton.Text = "Добавить новую песню";
            AddNewSongButton.UseVisualStyleBackColor = false;
            AddNewSongButton.Click += AddNewSongButton_Click;
            // 
            // GenreComboBox
            // 
            GenreComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            GenreComboBox.FormattingEnabled = true;
            GenreComboBox.Location = new Point(101, 247);
            GenreComboBox.Margin = new Padding(3, 2, 3, 2);
            GenreComboBox.Name = "GenreComboBox";
            GenreComboBox.Size = new Size(563, 23);
            GenreComboBox.TabIndex = 15;
            // 
            // MoodComboBox
            // 
            MoodComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            MoodComboBox.FormattingEnabled = true;
            MoodComboBox.Location = new Point(101, 415);
            MoodComboBox.Margin = new Padding(3, 2, 3, 2);
            MoodComboBox.Name = "MoodComboBox";
            MoodComboBox.Size = new Size(563, 23);
            MoodComboBox.TabIndex = 16;
            // 
            // DurationComboBox
            // 
            DurationComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DurationComboBox.FormattingEnabled = true;
            DurationComboBox.Location = new Point(101, 467);
            DurationComboBox.Margin = new Padding(3, 2, 3, 2);
            DurationComboBox.Name = "DurationComboBox";
            DurationComboBox.Size = new Size(563, 23);
            DurationComboBox.TabIndex = 17;
            // 
            // AddSongForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1038, 524);
            Controls.Add(DurationComboBox);
            Controls.Add(MoodComboBox);
            Controls.Add(GenreComboBox);
            Controls.Add(AddNewSongButton);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SongNameLabel);
            Controls.Add(AuthorTextBox);
            Controls.Add(SongYearsTextBox);
            Controls.Add(SongCountryTextBox);
            Controls.Add(SongNameTextBox);
            Margin = new Padding(3, 2, 3, 2);
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
        private Label SongNameLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button AddNewSongButton;
        public TextBox SongNameTextBox;
        public TextBox SongCountryTextBox;
        public TextBox SongYearsTextBox;
        public TextBox AuthorTextBox;
        public ComboBox GenreComboBox;
        public ComboBox MoodComboBox;
        public ComboBox DurationComboBox;
    }
}