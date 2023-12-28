namespace vizeprojeminsadehali
{
    partial class ToplantıOlustur
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
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            listBox2 = new ListBox();
            button6 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(184, 266);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(230, 24);
            listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(184, 68);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(427, 192);
            textBox1.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(184, 296);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(230, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(420, 266);
            button1.Name = "button1";
            button1.Size = new Size(94, 26);
            button1.TabIndex = 3;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(519, 266);
            button2.Name = "button2";
            button2.Size = new Size(92, 26);
            button2.TabIndex = 4;
            button2.Text = "Sil";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(450, 296);
            button3.Name = "button3";
            button3.Size = new Size(118, 27);
            button3.TabIndex = 5;
            button3.Text = "Oluştur";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(30, 12);
            button4.Name = "button4";
            button4.Size = new Size(51, 33);
            button4.TabIndex = 6;
            button4.Text = "<";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(308, 387);
            button5.Name = "button5";
            button5.Size = new Size(106, 30);
            button5.TabIndex = 7;
            button5.Text = "Onayla";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(184, 36);
            label1.Name = "label1";
            label1.Size = new Size(186, 25);
            label1.TabIndex = 8;
            label1.Text = "Toplantı Notu Giriniz";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(184, 357);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(230, 24);
            listBox2.TabIndex = 9;
            // 
            // button6
            // 
            button6.Location = new Point(184, 387);
            button6.Name = "button6";
            button6.Size = new Size(118, 30);
            button6.TabIndex = 10;
            button6.Text = "Kod İste";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // ToplantıOlustur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(listBox2);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Name = "ToplantıOlustur";
            Text = "ToplantıOlustur";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
        private ListBox listBox2;
        private Button button6;
    }
}