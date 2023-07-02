using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StokTakipSistemi
{
    public partial class Form5 : Form
    {
        SqlConnection baglanti = Class1.baglan();
        public Form5()
        {
            InitializeComponent();
        }
        SqlCommand cmd;

        private void temizle()
        {
            YeniAdTextBox.Text = "";
            YeniSifreTextBox.Text = "";
            YeniSifreTekTextBox.Text = "";
            YeniAdSoyadTextBox.Text = "";
            YeniCevapTextBox.Text = "";
            SoruComboBox.Text = "";
            YeniKayitTuruTextBox.Text = "";
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'stokTakipSistemiDataSet4.YeniKayit' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.yeniKayitTableAdapter.Fill(this.stokTakipSistemiDataSet4.YeniKayit);
          

        }

        private void YeniKayıtEKleButton_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into YeniKayit (KullaniciAdi,Sifre,AdSoyad,Soru,Cevap,KayitTuru) values (@KullaniciAdi,@Sifre,@AdSoyad,@Soru,@Cevap,@KayitTuru )";
            cmd = new SqlCommand(sorgu, baglanti);
            cmd.Parameters.AddWithValue("@KullaniciAdi", YeniAdTextBox.Text);
            cmd.Parameters.AddWithValue("@Sifre", YeniSifreTextBox.Text);
            cmd.Parameters.AddWithValue("@AdSoyad", YeniAdSoyadTextBox.Text);
            cmd.Parameters.AddWithValue("@Soru", SoruComboBox.Text);
            cmd.Parameters.AddWithValue("@Cevap", YeniCevapTextBox.Text);
            cmd.Parameters.AddWithValue("@KayitTuru", YeniKayitTuruTextBox.Text);
            if (YeniSifreTextBox.Text == YeniSifreTekTextBox.Text)
            {
                baglanti.Open();
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Yeni kayıt başarılı şekilde eklendi");
                temizle();

            }
            else
            {
                MessageBox.Show("Şifreler uyuşmuyor, lütfen girmiş olduğunuz şifreleri konrtrol ediniz.");
            }

        }

        private void YeniCıkısButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void YeniKayitTuruTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void SoruComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void KayıtEkleGeriButton_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }
    }
}
