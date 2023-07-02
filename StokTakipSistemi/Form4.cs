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
    public partial class Form4 : Form
    {
        SqlConnection baglanti = Class1.baglan();
        public Form4()
        {
            InitializeComponent();
        }

        void bilgigetir()
        {
            baglanti.Open();
            dataGridView3.DataSource = Class1.dtdoldur("select * from StokBilgi");
            baglanti.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'stokTakipSistemiDataSet.StokBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.stokBilgiTableAdapter.Fill(this.stokTakipSistemiDataSet.StokBilgi);
            bilgigetir();
            dataGridView3.Columns[8].HeaderText = "Resim";
        }

        private void AdminAraTextBox_TextChanged(object sender, EventArgs e)
        {
            dataGridView3.DataSource = Class1.dtdoldur("select * from StokBilgi where UrunAdi like '%" + AdminAraTextBox.Text + "%'");
        }

        private void AdminCikisButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView3.CurrentRow;
            pictureBox1.ImageLocation = dataGridView3.CurrentRow.Cells[8].Value.ToString();
        }

        private void AdminYolTextBox_TextChanged(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png |  Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            AdminYolTextBox.Text = dosyayolu;
            pictureBox1.ImageLocation = dosyayolu;
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        
    }
}
