namespace MusicStream
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            LogintextBox = new TextBox();
            label2 = new Label();
            PasswordTextBox = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 48);
            label1.Name = "label1";
            label1.Size = new Size(476, 72);
            label1.TabIndex = 0;
            label1.Text = "MusicStream";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LogintextBox
            // 
            LogintextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LogintextBox.Location = new Point(64, 289);
            LogintextBox.Multiline = true;
            LogintextBox.Name = "LogintextBox";
            LogintextBox.Size = new Size(476, 55);
            LogintextBox.TabIndex = 1;
            LogintextBox.Text = "Введите логин";
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(96, 144);
            label2.Name = "label2";
            label2.Size = new Size(417, 50);
            label2.TabIndex = 2;
            label2.Text = "Войдите в учетную запись";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PasswordTextBox.Location = new Point(64, 398);
            PasswordTextBox.Multiline = true;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(476, 55);
            PasswordTextBox.TabIndex = 3;
            PasswordTextBox.Text = "Введите пароль";
            PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(201, 508);
            button1.Name = "button1";
            button1.Size = new Size(176, 56);
            button1.TabIndex = 4;
            button1.Text = "Войти";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.BackColor = Color.DarkRed;
            label3.Location = new Point(64, 261);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 5;
            label3.Text = "Логин";
            // 
            // label4
            // 
            label4.BackColor = Color.DarkRed;
            label4.Location = new Point(64, 370);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 6;
            label4.Text = "Пароль";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1517407299172450247;
            ClientSize = new Size(615, 590);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(PasswordTextBox);
            Controls.Add(label2);
            Controls.Add(LogintextBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox LogintextBox;
        private Label label2;
        private TextBox PasswordTextBox;
        private Button button1;
        private Label label3;
        private Label label4;
    }
}