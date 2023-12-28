using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vizeprojeminsadehali
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Metin dosyasının yolu
            string filePath = @"C:\Users\ipek\Desktop\projeninyeni hali\vizeprojeminsadehali\Textlercik\Mervecik.txt";

            try
            {
                // Dosyadan satırları oku
                string[] lines = File.ReadAllLines(filePath);

                // ListBox'ı temizle
                listBox1.Items.Clear();

                // Her satırı ListBox'a ekle
                foreach (string line in lines)
                {
                    listBox1.Items.Add(line);
                }

                MessageBox.Show("Veriler başarıyla yüklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Metin dosyasının yolu
            string filePath = @"C:\Users\ipek\Desktop\projeninyeni hali\vizeprojeminsadehali\Textlercik\Mehmetcik.txt";

            try
            {
                // Dosyadan satırları oku
                string[] lines = File.ReadAllLines(filePath);

                // ListBox'ı temizle
                listBox2.Items.Clear();

                // Her satırı ListBox'a ekle
                foreach (string line in lines)
                {
                    listBox2.Items.Add(line);
                }

                MessageBox.Show("Veriler başarıyla yüklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Metin dosyasının yolu
            string filePath = @"C:\Users\ipek\Desktop\projeninyeni hali\vizeprojeminsadehali\Textlercik\Ayşecik.txt";

            try
            {
                // Dosyadan satırları oku
                string[] lines = File.ReadAllLines(filePath);

                // ListBox'ı temizle
                listBox3.Items.Clear();

                // Her satırı ListBox'a ekle
                foreach (string line in lines)
                {
                    listBox3.Items.Add(line);
                }

                MessageBox.Show("Veriler başarıyla yüklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Metin dosyasının yolu
            string filePath = @"C:\Users\ipek\Desktop\projeninyeni hali\vizeprojeminsadehali\Textlercik\Alicik.txt";

            try
            {
                // Dosyadan satırları oku
                string[] lines = File.ReadAllLines(filePath);

                // ListBox'ı temizle
                listBox4.Items.Clear();

                // Her satırı ListBox'a ekle
                foreach (string line in lines)
                {
                    listBox4.Items.Add(line);
                }

                MessageBox.Show("Veriler başarıyla yüklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ToplantıOlustur olusgit = new ToplantıOlustur();
            olusgit.Show();
            this.Hide();
        }
    }
}
