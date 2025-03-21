namespace WinFormsAppTest
{
    partial class Pictures
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
            button1 = new Button();
            Images = new ListBox();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 35);
            button1.Name = "button1";
            button1.Size = new Size(67, 70);
            button1.TabIndex = 2;
            button1.Text = "Загрузка из папки";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Images
            // 
            Images.FormattingEnabled = true;
            Images.ItemHeight = 15;
            Images.Location = new Point(12, 127);
            Images.Name = "Images";
            Images.Size = new Size(144, 184);
            Images.TabIndex = 4;
            Images.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Location = new Point(211, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(485, 276);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(211, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(485, 23);
            textBox1.TabIndex = 6;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button2
            // 
            button2.Location = new Point(12, 327);
            button2.Name = "button2";
            button2.Size = new Size(144, 45);
            button2.TabIndex = 7;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(85, 35);
            button3.Name = "button3";
            button3.Size = new Size(71, 70);
            button3.TabIndex = 8;
            button3.Text = "Загрузка из текстового файла";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Pictures
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(840, 494);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(Images);
            Controls.Add(button1);
            Name = "Pictures";
            Text = "Pictures";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private ListBox Images;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
    }
}
