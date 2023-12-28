namespace vizeprojeminsadehali
{
    partial class Admin
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
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            listBox4 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(12, 80);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(190, 264);
            listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(209, 80);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(189, 264);
            listBox2.TabIndex = 1;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 20;
            listBox3.Location = new Point(404, 80);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(189, 264);
            listBox3.TabIndex = 2;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 20;
            listBox4.Location = new Point(599, 80);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(189, 264);
            listBox4.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(12, 36);
            button1.Name = "button1";
            button1.Size = new Size(86, 30);
            button1.TabIndex = 8;
            button1.Text = "Merve";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(205, 39);
            button2.Name = "button2";
            button2.Size = new Size(86, 32);
            button2.TabIndex = 9;
            button2.Text = "Mehmet";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(404, 42);
            button3.Name = "button3";
            button3.Size = new Size(86, 32);
            button3.TabIndex = 10;
            button3.Text = "Ayşe";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(599, 42);
            button4.Name = "button4";
            button4.Size = new Size(86, 32);
            button4.TabIndex = 11;
            button4.Text = "Ali";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(12, 1);
            button5.Name = "button5";
            button5.Size = new Size(54, 29);
            button5.TabIndex = 12;
            button5.Text = "<";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(404, 372);
            button6.Name = "button6";
            button6.Size = new Size(357, 48);
            button6.TabIndex = 13;
            button6.Text = "TOPLANTI OLUŞTUR";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox4);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "Admin";
            Text = "Admin";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private ListBox listBox4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}