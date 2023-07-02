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
    public partial class Form1 : Form 
    {
        private SqlConnection baglanti;
        public Form1()
        {
            InitializeComponent();
           // SqlConnection baglan = Class1.baglan();

        }
        SqlCommand cmd;
        SqlDataReader dr;

        
      
        private void GirisButton_Click(object sender, EventArgs e)
        {
            string KayitTuru = MevkiTextBox.Text;
            string KullaniciAdi = KullaniciTextBox.Text;
            string Sifre = SifreTextBox.Text;
            baglanti = Class1.baglan();
            cmd = new SqlCommand();
            cmd.Connection = baglanti;
            cmd.CommandText = "SELECT * FROM YeniKayit Where KullaniciAdi='" + KullaniciTextBox.Text + "' AND Sifre='" + SifreTextBox.Text + "' AND KayitTuru='" + MevkiTextBox.Text + "'";
            baglanti.Open();
            dr=cmd.ExecuteReader();
            if (dr.Read())
            {
                if (MevkiTextBox.Text == "yönetici")
                {
                    Form2 Form2 = new Form2();
                    Form2.Show();
                    this.Hide();
                }
                else if (MevkiTextBox.Text == "admin")
                {
                    Form4 Form4 = new Form4();
                    Form4.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("lütfen giriş türünü kontrol ediniz.");
                }
                baglanti.Close();

            } 
            else
            {
                MessageBox.Show("Kullanıcı adınızı, şifrenizi ve kayıt türünüzü kontrol ediniz. ");
            }
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                GirisButton.PerformClick();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void KayıtEKleButton_Click(object sender, EventArgs e)
        {
            
            Form5 Form5 = new Form5();
            Form5.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SifreUnuttumButton_Click(object sender, EventArgs e)
        {
            SifremiUnuttum SifremiUnuttum = new SifremiUnuttum();
            SifremiUnuttum.Show();
            this.Hide();



        }

      
    }
}
