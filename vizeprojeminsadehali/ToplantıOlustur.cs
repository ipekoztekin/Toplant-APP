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
    public partial class ToplantıOlustur : Form
    {
        public ToplantıOlustur()
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
        private const string filePath = @"C:\Users\ipek\Desktop\projeninyeni hali\vizeprojeminsadehali\Textlercik\ToplantiBilgicikleri.txt";

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // StreamWriter kullanarak dosyayı aç ve ListBox'taki öğeleri ve TextBox'taki metni yaz
                using (StreamWriter sw = new StreamWriter(filePath, false)) // 'false' parametresi dosyanın üzerine yazılmasını sağlar
                {
                    // ListBox'taki öğeleri dosyaya yaz
                    foreach (var item in listBox1.Items)
                    {
                        sw.WriteLine(item.ToString());
                    }

                    // TextBox'taki metni dosyaya yaz
                    sw.WriteLine(textBox1.Text);
                }

                MessageBox.Show("Veriler başarıyla dosyaya yazıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Uzunluğu 5 olan bir rastgele kod oluştur
            string randomCode = GenerateRandomCode(5);

            // Oluşturulan kodu ListBox'a ekle
            listBox2.Items.Add(randomCode);

        }

        private static string GenerateRandomCode(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] codeArray = new char[length];

            for (int i = 0; i < length; i++)
            {
                codeArray[i] = chars[random.Next(chars.Length)];
            }

            return new string(codeArray);
        }
        private const string FFilePath = @"C:\Users\ipek\Desktop\projeninyeni hali\vizeprojeminsadehali\Textlercik\Kodlarcık.txt";

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {

                using (StreamWriter sw = new StreamWriter(FFilePath, false)) // 'false' parametresi dosyanın üzerine yazılmasını sağlar
                {
                    // ListBox'taki öğeleri dosyaya yaz
                    foreach (var item in listBox2.Items)
                    {
                        sw.WriteLine(item.ToString());
                    }
                }

                //Erişim kodu isteme sonu

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin agit = new Admin();
            agit.Show();
            this.Hide();
        }
    }
}
