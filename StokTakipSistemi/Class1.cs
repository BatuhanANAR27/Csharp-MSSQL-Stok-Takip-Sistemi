using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace StokTakipSistemi
{
    class Class1
    {
        private SqlConnection baglanti;

        public static SqlConnection baglan()
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString= ("Data Source=SQL5053.site4now.net;Initial Catalog=db_a4ee64_stoktakipsistemi;User Id=db_a4ee64_stoktakipsistemi_admin;Password=Bth12345.");
            return baglanti;
        }

        public static DataTable dtdoldur(string Sqlsorgusu)
        {
            SqlConnection baglanti = baglan();
            baglanti.Open();
            SqlDataAdapter sda = new SqlDataAdapter(Sqlsorgusu, baglanti);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            baglanti.Close();
            return dt;
        }
      
    }
}
