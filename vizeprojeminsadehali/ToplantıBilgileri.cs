using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace vizeprojeminsadehali
{
    public partial class ToplantıBilgileri : Form
    {
        public ToplantıBilgileri()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\ipek\Desktop\projeninyeni hali\vizeprojeminsadehali\Textlercik\ToplantiBilgicikleri.txt";

            try
            {
                textBox1.Clear();
                // Dosyayı oku

                string fileContent = File.ReadAllText(filePath);

                // Okunan veriyi TextBox'a yerleştir
                textBox1.Text = fileContent;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dosya okuma hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 git = new Form1();
            git.Show();
            this.Hide();
        }
    }
}
