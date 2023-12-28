namespace vizeprojeminsadehali
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Ayşe" && textBox2.Text == "ayşe123")
            {
                Ayşe aygit = new Ayşe();
                aygit.Show();
                this.Hide();
            }
            else if (textBox1.Text == "Ali" && textBox2.Text == "ali123")
            {
                Ali algit = new Ali();
                algit.Show();
                this.Hide();
            }
            else if (textBox1.Text == "Merve" && textBox2.Text == "merve123")
            {
                Merve mergit = new Merve();
                mergit.Show();
                this.Hide();
            }
            else if (textBox1.Text == "Mehmet" && textBox2.Text == "Mehmet123")
            {
                Mehmet mehgit = new Mehmet();
                mehgit.Show();
                this.Hide();
            }
            else if (textBox1.Text == "Admin" && textBox2.Text == "admin123")
            {
                Admin adgit = new Admin();
                adgit.Show();
                this.Hide();
            }
            else
            { MessageBox.Show("Kullanıcı Adı veya Parola Hatalı", "Hata"); }
        }


    }
}