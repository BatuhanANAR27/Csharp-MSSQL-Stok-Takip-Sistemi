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
    public partial class Form3 : Form
    {
        SqlConnection baglanti = Class1.baglan();
        public Form3()
        {
            InitializeComponent();
        }
        SqlCommand cmd;
        SqlDataReader dr;


        void bilgigetir()
        {
            baglanti.Open();
            dataGridView2.DataSource = Class1.dtdoldur("select * from EksikBilgi");
            baglanti.Close();
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'stokTakipSistemiDataSet3.EksikBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.eksikBilgiTableAdapter1.Fill(this.stokTakipSistemiDataSet3.EksikBilgi);
            // TODO: Bu kod satırı 'stokTakipSistemiDataSet1.EksikBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.eksikBilgiTableAdapter.Fill(this.stokTakipSistemiDataSet1.EksikBilgi);

            bilgigetir();
        }
            
        private void temiz()
        {
            EksikKodTextBox.Text = "";
            EksikAdTextbox.Text = "";
            EksikAracTextbox.Text = "";
            EksikAdetTextBox.Text = "";
        }

        bool durum;
        void tekrarkayit()
        {
            baglanti.Open();
            SqlCommand cmd=new SqlCommand("select * from EksikBilgi Where UrunKodu=@UrunKodu", baglanti);
            cmd.Parameters.AddWithValue("@UrunKodu", EksikKodTextBox.Text);
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

        private void EksikAraTextBox_TextChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = Class1.dtdoldur("select * from EksikBilgi where UrunAdi like '%" + EksikAraTextBox.Text + "%'");
        }

        private void EksikKaydetButton_Click(object sender, EventArgs e)
        {
            tekrarkayit();
            if (durum == true)
            {
                string sorgu = "Insert into EksikBilgi (UrunKodu, UrunAdi, Arac, Adet) values (@UrunKodu, @UrunAdi, @Arac, @Adet)";
                cmd = new SqlCommand(sorgu, baglanti);
                cmd.Parameters.AddWithValue("@UrunKodu", EksikKodTextBox.Text);
                cmd.Parameters.AddWithValue("@UrunAdi", EksikAdTextbox.Text);
                cmd.Parameters.AddWithValue("@Arac", EksikAracTextbox.Text);
                cmd.Parameters.AddWithValue("@Adet", EksikAdetTextBox.Text);
                if (System.Text.RegularExpressions.Regex.IsMatch(EksikAdetTextBox.Text, "[-]"))
                {
                    MessageBox.Show("Lütfen negatif değer girmeyiniz.");
                }
                else
                {
                    baglanti.Open();
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Ürün bilgisi başarı ile kaydedildi");
                    bilgigetir();
                    temiz();
                }
            }
            else
            {
                MessageBox.Show("Bu kayıt sisteminizde mevcuttur");
            }
           
        }

        private void EksikGuncelleButton_Click(object sender, EventArgs e)
        {
            string sorgu = "update EksikBilgi Set UrunKodu=@UrunKodu, UrunAdi=@UrunAdi, Arac=@Arac, Adet=@Adet Where Id=@Id ";
            cmd = new SqlCommand(sorgu, baglanti);
            cmd.Parameters.AddWithValue("@UrunKodu", EksikKodTextBox.Text);
            cmd.Parameters.AddWithValue("@UrunAdi", EksikAdTextbox.Text);
            cmd.Parameters.AddWithValue("@Arac", EksikAracTextbox.Text);
            cmd.Parameters.AddWithValue("@Adet", EksikAdetTextBox.Text);
            cmd.Parameters.AddWithValue("@Id", dataGridView2.CurrentRow.Cells[0].Value);
            if (System.Text.RegularExpressions.Regex.IsMatch(EksikAdetTextBox.Text, "[-]"))
            {
                MessageBox.Show("Lütfen negatif değer girmeyiniz.");
            }
            else
            {
                baglanti.Open();
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ürün bilgisi başarı ile kaydedildi");
                bilgigetir();
                temiz();
            }
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView2.CurrentRow;
            EksikKodTextBox.Text = satır.Cells[1].Value.ToString();
            EksikAdTextbox.Text = satır.Cells[2].Value.ToString();
            EksikAracTextbox.Text = satır.Cells[3].Value.ToString();
            EksikAdetTextBox.Text = satır.Cells[4].Value.ToString();

        }

        private void EksikSilButton_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE EksikBilgi Where Id=@Id";
            cmd = new SqlCommand(sorgu, baglanti);
            cmd.Parameters.AddWithValue("@Id", dataGridView2.CurrentRow.Cells[0].Value);
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Parça Bilgileri Başarıyla Silindi...");
            bilgigetir();
            temiz();
        }

        private void EksikCikisButton_Click(object sender, EventArgs e)
        {
            Application.Exit();        
        }

        private void GeriButton_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
            this.Hide();
        }

  
        private void verileriTemizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE EksikBilgi";
            cmd = new SqlCommand(sorgu, baglanti);
            baglanti.Open();
            cmd.ExecuteNonQuery();
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();
            string sorgu2 = "DBCC checkident(EksikBilgi,RESEED,0)";
            cmd = new SqlCommand(sorgu2, baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            temiz();
        }

       
    }
}
