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
    public partial class Form2 : Form
    {
        SqlConnection baglanti = Class1.baglan();
        public Form2()
        {
            InitializeComponent();
        }
        SqlCommand cmd; 

        void bilgigetir()
        {
            baglanti.Open();
            dataGridView1.DataSource = Class1.dtdoldur("select * from StokBilgi");
            baglanti.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'stokTakipSistemiDataSet.StokBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
           // this.stokBilgiTableAdapter.Fill(this.stokTakipSistemiDataSet.StokBilgi);
      
            bilgigetir();
            dataGridView1.Columns[8].HeaderText = "Resim";


        }

        private void temizle()
        {
            KodTextBox.Text = "";
            AdTextBox.Text = "";
            AracTextBox.Text = "";
            AdetTextBox.Text = "";
            AlısTextBox.Text = "";
            SatısTextBox.Text = "";
            TarihTextBox.Text = "";
        }

        private void AraTextBox_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Class1.dtdoldur("select * from StokBilgi where UrunAdi like '%" + AraTextBox.Text + "%'");

        }

        bool durum;
        void TekrarKayit()
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select * from StokBilgi Where Urunkodu=@Urunkodu", baglanti);
            cmd.Parameters.AddWithValue("@UrunKodu", KodTextBox.Text);
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


        private void KaydetButton_Click(object sender, EventArgs e)
        {
            TekrarKayit();
            if (durum == true)
            {
                
                if (System.Text.RegularExpressions.Regex.IsMatch(AlısTextBox.Text, "[-]") || System.Text.RegularExpressions.Regex.IsMatch(SatısTextBox.Text, "[-]") || System.Text.RegularExpressions.Regex.IsMatch(AdetTextBox.Text, "[-]") )
                {
                    MessageBox.Show("Lütfen negatif değer girmeyiniz.");
                }
                else
                {
                    string sorgu = "Insert into StokBilgi (UrunKodu, UrunAdi, Arac, AlisFiyati, SatisFiyati, StokAdedi, StokTarihi,Resim) values (@UrunKodu, @UrunAdi, @Arac, @AlisFiyati, @SatisFiyati, @StokAdedi, @StokTarihi,@Resim)";
                    cmd = new SqlCommand(sorgu, baglanti);
                    cmd.Parameters.AddWithValue("@UrunKodu", KodTextBox.Text);
                    cmd.Parameters.AddWithValue("@UrunAdi", AdTextBox.Text);
                    cmd.Parameters.AddWithValue("@Arac", AracTextBox.Text);
                    cmd.Parameters.AddWithValue("@AlisFiyati", AlısTextBox.Text);
                    cmd.Parameters.AddWithValue("@SatisFiyati", SatısTextBox.Text);
                    cmd.Parameters.AddWithValue("@StokAdedi", AdetTextBox.Text);
                    cmd.Parameters.AddWithValue("@StokTarihi", DateTime.Parse(TarihTextBox.Text = DateTime.Now.ToLongDateString()));
                    cmd.Parameters.AddWithValue("@Resim", YolTextBox.Text);
                    baglanti.Open();
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Ürün bilgisi başarı ile kaydedildi");
                    bilgigetir();
                    temizle();
                }
            }
            else
            {
                MessageBox.Show("Bu kayıt sisteminizde mevcuttur");
            }
            
            
        }

        private void GuncelleButton_Click(object sender, EventArgs e)
        {
            string sorgu = "update StokBilgi Set UrunKodu=@UrunKodu, UrunAdi=@UrunAdi, Arac=@Arac, AlisFiyati=@AlisFiyati, SatisFiyati=@SatisFiyati, StokAdedi=@StokAdedi, StokTarihi=@StokTarihi, Resim=@Resim Where Id=@Id";
            cmd = new SqlCommand(sorgu, baglanti);
            cmd.Parameters.AddWithValue("@UrunKodu", KodTextBox.Text);
            cmd.Parameters.AddWithValue("@UrunAdi", AdTextBox.Text);
            cmd.Parameters.AddWithValue("@Arac", AracTextBox.Text);
            cmd.Parameters.AddWithValue("@AlisFiyati", AlısTextBox.Text);
            cmd.Parameters.AddWithValue("@SatisFiyati", SatısTextBox.Text);
            cmd.Parameters.AddWithValue("@StokAdedi", AdetTextBox.Text);
            cmd.Parameters.AddWithValue("@StokTarihi", DateTime.Parse(TarihTextBox.Text = DateTime.Now.ToLongDateString()));
            cmd.Parameters.AddWithValue("@Resim", YolTextBox.Text);
            cmd.Parameters.AddWithValue("@Id", dataGridView1.CurrentRow.Cells[0].Value);
            if (System.Text.RegularExpressions.Regex.IsMatch(AlısTextBox.Text, "[-]") || System.Text.RegularExpressions.Regex.IsMatch(SatısTextBox.Text, "[-]") || System.Text.RegularExpressions.Regex.IsMatch(AdetTextBox.Text, "[-]"))
            {
                MessageBox.Show("Lütfen negatif değer girmeyiniz.");
            }
            else
            {
                baglanti.Open();
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ürün bilgisi başarı ile güncellendi");
                bilgigetir();
                temizle();
            }
           
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            KodTextBox.Text = satır.Cells[1].Value.ToString();
            AdTextBox.Text = satır.Cells[2].Value.ToString();
            AracTextBox.Text = satır.Cells[3].Value.ToString();
            AdetTextBox.Text = satır.Cells[6].Value.ToString();
            AlısTextBox.Text = satır.Cells[4].Value.ToString();
            SatısTextBox.Text = satır.Cells[5].Value.ToString();
            TarihTextBox.Text = satır.Cells[7].Value.ToString();
            YolTextBox.Text = satır.Cells[8].Value.ToString();
            pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells[8].Value.ToString();

        }

        private void SilButton_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE StokBilgi Where Id=@Id";
            cmd = new SqlCommand(sorgu, baglanti);
            cmd.Parameters.AddWithValue("@Id", dataGridView1.CurrentRow.Cells[0].Value);
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Parça Bilgileri Başarıyla Silindi...");
            bilgigetir();
            temizle();
        }

        private void CikisButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ResimEkleButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png;*.jpeg |  Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            YolTextBox.Text = dosyayolu;
            pictureBox1.ImageLocation = dosyayolu;
        }

        private void eksikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();
            Form3.Show();
            this.Hide();
            
        }

        private void kullanıcıDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }

        private void tümVerileriSilToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            string sorgu = "DELETE StokBilgi" ;
            cmd = new SqlCommand(sorgu, baglanti);
            baglanti.Open();
            cmd.ExecuteNonQuery();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            string sorgu2 = "DBCC checkident(StokBilgi,RESEED,0)";
            cmd = new SqlCommand(sorgu2, baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        private void SatıldıButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(AdetTextBox.Text, out int sayi))
            {
                sayi--; // Sayıyı azaltma işlemi
                AdetTextBox.Text = sayi.ToString(); // TextBox'a yeni değeri atama
                string sorgu = "update StokBilgi Set UrunKodu=@UrunKodu, UrunAdi=@UrunAdi, Arac=@Arac, AlisFiyati=@AlisFiyati, SatisFiyati=@SatisFiyati, StokAdedi=@StokAdedi, StokTarihi=@StokTarihi, Resim=@Resim Where Id=@Id";
                cmd = new SqlCommand(sorgu, baglanti);
                cmd.Parameters.AddWithValue("@UrunKodu", KodTextBox.Text);
                cmd.Parameters.AddWithValue("@UrunAdi", AdTextBox.Text);
                cmd.Parameters.AddWithValue("@Arac", AracTextBox.Text);
                cmd.Parameters.AddWithValue("@AlisFiyati", AlısTextBox.Text);
                cmd.Parameters.AddWithValue("@SatisFiyati", SatısTextBox.Text);
                cmd.Parameters.AddWithValue("@StokAdedi", AdetTextBox.Text);
                cmd.Parameters.AddWithValue("@StokTarihi", DateTime.Parse(TarihTextBox.Text = DateTime.Now.ToLongDateString()));
                cmd.Parameters.AddWithValue("@Resim", YolTextBox.Text);
                cmd.Parameters.AddWithValue("@Id", dataGridView1.CurrentRow.Cells[0].Value);
                baglanti.Open();
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Üründeki stokda eksilme yapıldı");
                bilgigetir();
                temizle();

            }
            else
            {
                MessageBox.Show("Geçerli bir sayı girin.");
            }
        }

        private void müşteriKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MüsteriKayit MüsteriKayit = new MüsteriKayit();
            MüsteriKayit.Show();
            this.Hide();
        }
    }
}
