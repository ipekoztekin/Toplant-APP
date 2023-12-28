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
    public partial class Mehmet : Form
    {
        public Mehmet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String selectedDate = dateTimePicker1.Text;
            listBox1.Items.Add(selectedDate);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KayitlariDosyayaKaydet();
        }

        private const string FilePath = @"C:\Users\ipek\Desktop\projeninyeni hali\vizeprojeminsadehali\Textlercik\Mehmetcik.txt";
        private void KayitlariDosyayaKaydet()
        {
            try
            {
                // ListBox'taki verileri bir metin dosyasına kaydet
                using (StreamWriter sw = new StreamWriter(FilePath))
                {
                    // Label'ın içeriğini başlık olarak dosyaya ekle
                    //sw.WriteLine(Mehmet.Text);

                    // ListBox'taki her öğeyi dosyaya ekle
                    foreach (var item in listBox1.Items)
                    {
                        sw.WriteLine(item.ToString());
                    }
                }

                MessageBox.Show("Veriler başarıyla dosyaya kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Dosyaya yazma hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            // Text dosyasının yolu
            string filePath = "C:\\Users\\ipek\\Desktop\\projeninyeni hali\\vizeprojeminsadehali\\Textlercik\\Kodlarcık.txt";

            // TextBox'tan girilen metni al
            string userInput = textBox1.Text;

            try
            {
                // Text dosyasındaki kayıtları oku
                string[] lines = File.ReadAllLines(filePath);

                // Text dosyasındaki her satırı kontrol et
                foreach (string line in lines)
                {
                    // Girilen metin ile dosyadaki metin karşılaştır
                    if (userInput == line)
                    {
                        // Eğer eşleşme varsa, yönlendirilecek formu göster
                        ToplantıBilgileri redirectForm = new ToplantıBilgileri();
                        redirectForm.Show();

                        // Giriş formunu gizle (opsiyonel)
                        this.Hide();
                        return;
                    }
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı kod girdiniz..", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
