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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKullanici.Text == "zeynep" && txtSifre.Text == "123")// Kullanıcı ve şifre doğruysa eğer
            {
                Form2 frm = new Form2();// yeni form oluşturur
                frm.Show();// diğer form sayfasını ekrana gösterir
                this.Hide(); // Form geçişi 
            }
            else// eğer koşulum değilse sağlanmıyorsa
            {
                MessageBox.Show("Hatalı giriş!");// bu yazıyı gösterir
            }
        }
    }
}
