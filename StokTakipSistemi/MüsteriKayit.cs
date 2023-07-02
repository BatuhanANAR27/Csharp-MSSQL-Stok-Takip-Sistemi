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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StokTakipSistemi
{
    public partial class MüsteriKayit : Form
    {
        SqlConnection baglanti = Class1.baglan();
        public MüsteriKayit()
        {
            InitializeComponent();
        }
        SqlCommand cmd;


        void bilgigetir()
        {
            baglanti.Open();
            MüsteridataGridView.DataSource = Class1.dtdoldur("select * from MüsteriKayit");
            baglanti.Close();
        }


        private void MüsteriKayit_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'db_a4ee64_stoktakipsistemiDataSet.MüsteriKayit' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.müsteriKayitTableAdapter.Fill(this.db_a4ee64_stoktakipsistemiDataSet.MüsteriKayit);
            bilgigetir();

        }

        private void temizle()
        {
            MüsteriAdiTextbox.Text = "";
            MüsteriSoyadTextBox.Text = "";
            MüsteriÜcretTextBox.Text = "";
            MüsteriNumaraTextBox.Text = "";
            MüsteriMarkaTextBox.Text = "";
            MüsteriTarihTextBox.Text = "";

        }

        private void MüsteriAraTextBox_TextChanged(object sender, EventArgs e)
        {
            MüsteridataGridView.DataSource = Class1.dtdoldur("select * from MüsteriKayit where Ad like '%" + MüsteriAraTextBox.Text + "%'");
        }


        bool durum;
        void TekrarKayit()
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from MüsteriKayit Where Id=@Id", baglanti);
            cmd.Parameters.AddWithValue("@Id", MüsteriIdTextbox.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
            baglanti.Close();
        }

        private void MüsteriKaydetButton_Click(object sender, EventArgs e)
        {
            TekrarKayit();
            if (durum == true)
            {

                if (System.Text.RegularExpressions.Regex.IsMatch(MüsteriÜcretTextBox.Text, "[-]") )
                {
                    MessageBox.Show("Lütfen ücret kısmına negatif değer girmeyiniz.");
                }
                if (MüsteriNumaraTextBox.Text.Length > 11)
                {
                    MessageBox.Show("Telefon numarası uzunluğunu kontrol ediniz.");
                }

                else
                {
                    string sorgu = "Insert into MüsteriKayit (Ad,Soyad,Numara,ArabaMarkasi,AlinanÜcret,Tarih) values (@Ad, @Soyad, @Numara, @ArabaMarkasi, @AlinanÜcret, @Tarih)";
                    cmd = new SqlCommand(sorgu, baglanti);
                    cmd.Parameters.AddWithValue("@Ad", MüsteriAdiTextbox.Text);
                    cmd.Parameters.AddWithValue("@Soyad", MüsteriSoyadTextBox.Text);
                    cmd.Parameters.AddWithValue("@Numara", MüsteriNumaraTextBox.Text);
                    cmd.Parameters.AddWithValue("@ArabaMarkasi", MüsteriMarkaTextBox.Text);
                    cmd.Parameters.AddWithValue("@AlinanÜcret", MüsteriÜcretTextBox.Text);
                    cmd.Parameters.AddWithValue("@Tarih", DateTime.Parse(MüsteriTarihTextBox.Text = DateTime.Now.ToLongDateString()));
                    baglanti.Open();
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Müşteri bilgisi başarı ile kaydedildi");
                    bilgigetir();
                    temizle();
                }
            }
            else
            {
                MessageBox.Show("Bu kayıt sisteminizde mevcuttur");
            }
        }

        private void MüsteriGuncelleButton_Click(object sender, EventArgs e)
        {
            string sorgu = "update MüsteriKayit Set Ad=@Ad, Soyad=@Soyad, Numara=@Numara, ArabaMarkasi=@ArabaMarkasi, AlinanÜcret=@AlinanÜcret, Tarih=@Tarih Where Id=@Id";
            cmd = new SqlCommand(sorgu, baglanti);
            cmd.Parameters.AddWithValue("@Ad", MüsteriAdiTextbox.Text);
            cmd.Parameters.AddWithValue("@Soyad", MüsteriSoyadTextBox.Text);
            cmd.Parameters.AddWithValue("@Numara", MüsteriNumaraTextBox.Text);
            cmd.Parameters.AddWithValue("@ArabaMarkasi", MüsteriMarkaTextBox.Text);
            cmd.Parameters.AddWithValue("@AlinanÜcret", MüsteriÜcretTextBox.Text);
            cmd.Parameters.AddWithValue("@Tarih", DateTime.Parse(MüsteriTarihTextBox.Text = DateTime.Now.ToLongDateString()));
            if (System.Text.RegularExpressions.Regex.IsMatch(MüsteriÜcretTextBox.Text,"[-]"))
            {
                MessageBox.Show("Lütfen negatif değer girmeyiniz.");
            }
            if (MüsteriNumaraTextBox.Text.Length > 11)
            {
                MessageBox.Show("Telefon numarası uzunluğunu kontrol ediniz.");
            }
            else
            {
                baglanti.Open();
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Müşteri bilgisi başarı ile güncellendi");
                bilgigetir();
                temizle();
            }
        }

        private void MüsteridataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = MüsteridataGridView.CurrentRow;
            MüsteriIdTextbox.Text = satır.Cells[0].Value.ToString();
            MüsteriAdiTextbox.Text = satır.Cells[1].Value.ToString();
            MüsteriSoyadTextBox.Text = satır.Cells[2].Value.ToString();
            MüsteriNumaraTextBox.Text = satır.Cells[3].Value.ToString();
            MüsteriMarkaTextBox.Text = satır.Cells[4].Value.ToString();
            MüsteriÜcretTextBox.Text = satır.Cells[5].Value.ToString();
            MüsteriTarihTextBox.Text = satır.Cells[6].Value.ToString();
            
        }

        private void MüsteriSilButton_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE MüsteriKayit Where Id=@Id";
            cmd = new SqlCommand(sorgu, baglanti);
            cmd.Parameters.AddWithValue("@Id", MüsteridataGridView.CurrentRow.Cells[0].Value);
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Bilgileri Başarıyla Silindi...");
            bilgigetir();
            temizle();
        }

        private void MüsteriCikisButton_Click(object sender, EventArgs e)
        {
            Application.Exit();        
        }

        private void MüsteriGeriButton_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
            this.Hide();
        }
    }

        
 }

