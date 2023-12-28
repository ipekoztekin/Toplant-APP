namespace vizeprojeminsadehali
{
    partial class Mehmet
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dateTimePicker1 = new DateTimePicker();
            listBox1 = new ListBox();
            button4 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(381, 64);
            button1.Name = "button1";
            button1.Size = new Size(119, 47);
            button1.TabIndex = 0;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(381, 133);
            button2.Name = "button2";
            button2.Size = new Size(119, 45);
            button2.TabIndex = 1;
            button2.Text = "Sil";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(381, 307);
            button3.Name = "button3";
            button3.Size = new Size(119, 45);
            button3.TabIndex = 2;
            button3.Text = "Kaydet";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(21, 248);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(269, 27);
            dateTimePicker1.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(21, 64);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(269, 164);
            listBox1.TabIndex = 4;
            // 
            // button4
            // 
            button4.Location = new Point(626, 135);
            button4.Name = "button4";
            button4.Size = new Size(119, 45);
            button4.TabIndex = 5;
            button4.Text = "Eriş";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(612, 64);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 6;
            label1.Text = "Erişim Kodu";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(612, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(146, 27);
            textBox1.TabIndex = 7;
            // 
            // button5
            // 
            button5.Location = new Point(21, 3);
            button5.Name = "button5";
            button5.Size = new Size(38, 31);
            button5.TabIndex = 8;
            button5.Text = "<";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Mehmet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(listBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Mehmet";
            Text = "Mehmet";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private DateTimePicker dateTimePicker1;
        private ListBox listBox1;
        private Button button4;
        private Label label1;
        private TextBox textBox1;
        private Button button5;
    }
}