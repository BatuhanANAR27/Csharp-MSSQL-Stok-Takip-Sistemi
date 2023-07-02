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
using System.Data.OleDb;


namespace StokTakipSistemi
{
    
    public partial class SifremiUnuttum : Form
    {
        SqlConnection baglanti = Class1.baglan();
        public SifremiUnuttum()
        {
            InitializeComponent();
        }
        SqlCommand cmd;
        SqlDataReader dr;
        private void GuncelleButton_Click(object sender, EventArgs e)
        {
            
            if (UnuttumSifreTextBox.Text == YeniUnuttumSifreTextBox.Text)
            {
                string Soru = UnuttumComboBox.Text;
                string Cevap = UnuttumCevapTextBox.Text;
                baglanti = Class1.baglan();
                cmd = new SqlCommand();
                cmd.Connection = baglanti;
                cmd.CommandText = "SELECT * FROM YeniKayit Where Soru='" + UnuttumComboBox.Text + "' AND Cevap='" + UnuttumCevapTextBox.Text + "'";
                baglanti.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    string sorgu = "update YeniKayit Set Sifre=@Sifre, Soru=@Soru,Cevap=@Cevap where KullaniciAdi=@KullaniciAdi";
                    cmd = new SqlCommand(sorgu, baglanti);
                    cmd.Parameters.AddWithValue("@Sifre", UnuttumSifreTextBox.Text);
                    cmd.Parameters.AddWithValue("@Soru", UnuttumComboBox.Text);
                    cmd.Parameters.AddWithValue("@Cevap", UnuttumCevapTextBox.Text);
                    cmd.Parameters.AddWithValue("@KullaniciAdi", UnuttumKullanıcıTextBox.Text);
                    baglanti.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Şifre güncelledi");
                    temizle();

                }
                else
                {
                    MessageBox.Show("Güvenlik sorusunu veya cevabınızı kontrol ediniz. ");
                }
                
            }
            else
            {
                MessageBox.Show("Girmiş olduğunuz şifreler eşleşmiyor.Lütfen kontrol ediniz.");
            }
            baglanti.Close();

        }

        void temizle()
        {
            UnuttumKullanıcıTextBox.Text = "";
            UnuttumSifreTextBox.Text = "";
            YeniUnuttumSifreTextBox.Text = "";
            UnuttumComboBox.Text = "";
            UnuttumCevapTextBox.Text = "";
        }

       
    }
}



