using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dönemsonuprojesi
{
    public partial class Form2 : Form
    {
        // Global Değişkenler
        string[] ogrenciler = new string[30];
        int index = 0;

        public Form2()
        {
            InitializeComponent();
        }

        // TEXTBOX TEMİZLEME METODU 
        void TextboxlariTemizle()
        {
            txtAd.Clear();
            txtNot.Clear();
            
        }

        // METOT 
        void ListeyeEkle(string veri)
        {
            if (index < ogrenciler.Length)
            {
                ogrenciler[index] = veri;
                index++;
            }
            else
            {
                MessageBox.Show("Dizi dolu!");
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
          
        
            try // TRY-CATCH 
            {
                string ad = txtAd.Text;
                int not = Convert.ToInt32(txtNot.Text); 

                ListeyeEkle(ad + " - " + not);

                // bilgi veren  MessageBox
                MessageBox.Show("Öğrenci başarıyla eklendi!", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                // Hata durumunda da uyarı  ikonu 
                MessageBox.Show("Not kısmına lütfen geçerli bir sayı girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                TextboxlariTemizle();
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            // DÖNGÜ 
            foreach (string item in ogrenciler)
            {
                if (item != null)
                    listBox1.Items.Add(item);
            }

            TextboxlariTemizle(); // Butona basılınca temizler
        }

        private void btnRandomNo_Click(object sender, EventArgs e)
        {
            Random rnd = new Random(); // RANDOM 
            int no = rnd.Next(1000, 9999);

            MessageBox.Show("Rastgele öğrenci no: " + no);

            TextboxlariTemizle(); // Butona basılınca temizler
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Array.Clear(ogrenciler, 0, ogrenciler.Length);
            listBox1.Items.Clear();
            index = 0;

            MessageBox.Show("Liste temizlendi!");

            TextboxlariTemizle(); // Butona basılınca temizler
        }
    }
}