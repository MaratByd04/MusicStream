﻿namespace MusicStream
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
            SongNameLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            AddNewSongButton = new Button();
            SuspendLayout();
            // 
            // SongNameTextBox
            // 
            SongNameTextBox.Location = new Point(115, 184);
            SongNameTextBox.Name = "SongNameTextBox";
            SongNameTextBox.Size = new Size(643, 27);
            SongNameTextBox.TabIndex = 0;
            // 
            // SongCountryTextBox
            // 
            SongCountryTextBox.Location = new Point(115, 402);
            SongCountryTextBox.Name = "SongCountryTextBox";
            SongCountryTextBox.Size = new Size(643, 27);
            SongCountryTextBox.TabIndex = 1;
            // 
            // SongYearsTextBox
            // 
            SongYearsTextBox.Location = new Point(115, 479);
            SongYearsTextBox.Name = "SongYearsTextBox";
            SongYearsTextBox.Size = new Size(643, 27);
            SongYearsTextBox.TabIndex = 2;
            // 
            // MoodTextBox
            // 
            MoodTextBox.Location = new Point(115, 551);
            MoodTextBox.Name = "MoodTextBox";
            MoodTextBox.Size = new Size(643, 27);
            MoodTextBox.TabIndex = 3;
            // 
            // DurationTextBox
            // 
            DurationTextBox.Location = new Point(115, 622);
            DurationTextBox.Name = "DurationTextBox";
            DurationTextBox.Size = new Size(643, 27);
            DurationTextBox.TabIndex = 4;
            // 
            // GenreTextBox
            // 
            GenreTextBox.Location = new Point(115, 328);
            GenreTextBox.Name = "GenreTextBox";
            GenreTextBox.Size = new Size(643, 27);
            GenreTextBox.TabIndex = 5;
            // 
            // AuthorTextBox
            // 
            AuthorTextBox.Location = new Point(115, 253);
            AuthorTextBox.Name = "AuthorTextBox";
            AuthorTextBox.Size = new Size(643, 27);
            AuthorTextBox.TabIndex = 6;
            // 
            // SongNameLabel
            // 
            SongNameLabel.BackColor = Color.Transparent;
            SongNameLabel.ForeColor = Color.PaleTurquoise;
            SongNameLabel.Location = new Point(115, 155);
            SongNameLabel.Name = "SongNameLabel";
            SongNameLabel.Size = new Size(184, 26);
            SongNameLabel.TabIndex = 7;
            SongNameLabel.Text = "Введите название песни";
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.PaleTurquoise;
            label1.Location = new Point(115, 224);
            label1.Name = "label1";
            label1.Size = new Size(184, 26);
            label1.TabIndex = 8;
            label1.Text = "Введите автора песни";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.PaleTurquoise;
            label2.Location = new Point(115, 450);
            label2.Name = "label2";
            label2.Size = new Size(207, 26);
            label2.TabIndex = 9;
            label2.Text = "Введите годы выхода песни";
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.PaleTurquoise;
            label3.Location = new Point(115, 373);
            label3.Name = "label3";
            label3.Size = new Size(184, 26);
            label3.TabIndex = 10;
            label3.Text = "Введите страну песни";
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.PaleTurquoise;
            label4.Location = new Point(115, 299);
            label4.Name = "label4";
            label4.Size = new Size(184, 26);
            label4.TabIndex = 11;
            label4.Text = "Введите жанр песни";
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.PaleTurquoise;
            label5.Location = new Point(115, 522);
            label5.Name = "label5";
            label5.Size = new Size(393, 26);
            label5.TabIndex = 12;
            label5.Text = "Введите настроение под которое вы бы это включили песни";
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.ForeColor = Color.PaleTurquoise;
            label6.Location = new Point(115, 593);
            label6.Name = "label6";
            label6.Size = new Size(265, 26);
            label6.TabIndex = 13;
            label6.Text = "Введите продолжительность песни";
            // 
            // AddNewSongButton
            // 
            AddNewSongButton.BackColor = Color.Black;
            AddNewSongButton.ForeColor = Color.PaleTurquoise;
            AddNewSongButton.Location = new Point(818, 593);
            AddNewSongButton.Name = "AddNewSongButton";
            AddNewSongButton.Size = new Size(257, 56);
            AddNewSongButton.TabIndex = 14;
            AddNewSongButton.Text = "Добавить новую песню";
            AddNewSongButton.UseVisualStyleBackColor = false;
            AddNewSongButton.Click += AddNewSongButton_Click;
            // 
            // AddSongForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1186, 699);
            Controls.Add(AddNewSongButton);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SongNameLabel);
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
        private Label SongNameLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button AddNewSongButton;
    }
}