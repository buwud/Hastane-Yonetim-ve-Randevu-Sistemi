using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Hastane
{
    internal class DatabaseHasta
    {
        static SqlConnection baglanti = new SqlConnection(Baglanti.baglantiAdres);


        public static void HastaKaydiYap(string ad, string soyad, string tc, string tel, 
            string sifre, string cinsiyet)
        {
           
            string sql = "insert into Hasta (HastaAdi,HastaSoyadi,HastaTC," +
                "HastaTelefon,HastaSifre,HastaCinsiyet) values (@pAd,@pSoyad,@pTc,@pTel,@pSifre,@pCins)";
            SqlCommand cmd = new SqlCommand(sql, baglanti);
            cmd.Parameters.AddWithValue("@pAd", ad);
            cmd.Parameters.AddWithValue("@pSoyad", soyad);
            cmd.Parameters.AddWithValue("@pTc", tc);
            cmd.Parameters.AddWithValue("@pTel", tel);
            cmd.Parameters.AddWithValue("@pSifre", sifre);
            cmd.Parameters.AddWithValue("@pCins", cinsiyet);

            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }
        public static bool HastaTcKontrol(string tc)//aynı tc ile başka biri kayıt olamasın
        {
            bool varMi = false;
            string sql = "select * from Hasta where HastaTC=@pTc";
            SqlCommand cmd = new SqlCommand(sql, baglanti);
            cmd.Parameters.AddWithValue("@pTc", tc);
            baglanti.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                varMi = true;
            }
            baglanti.Close();
            return varMi;
        }
        public static bool HastaGirisi(string tc , string sifre)
        {
            bool dogru = false;
            baglanti.Open();
            string sql = "select * from Hasta where HastaTC=@pTc and HastaSifre=@pSifre";
            SqlCommand cmd = new SqlCommand(sql, baglanti);
            cmd.Parameters.AddWithValue("@pTc", tc);
            cmd.Parameters.AddWithValue("@pSifre", sifre);
            
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dogru = true;
            }
            baglanti.Close();
            return dogru;
        }
        static string adSoyad;
        public static string AdSoyadCekme(string tc)
        {
            baglanti.Open();
            string sql = "select HastaAdi, HastaSoyadi from Hasta where HastaTC=@pTc";
            SqlCommand cmd = new SqlCommand(sql, baglanti);
            cmd.Parameters.AddWithValue("@pTc", tc);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                adSoyad = dr[0] + " " + dr[1];
            }
            baglanti.Close();
            return adSoyad;
        }
        public static DataTable DataGecmişRandevu(string tc)
        {
            DataTable dt = new DataTable();
            string sql = "select * from Randevular where HastaTC=" + tc;
            SqlDataAdapter adaptor = new SqlDataAdapter(sql, baglanti);
            adaptor.Fill(dt);
            return dt;
        }
        public static DataSet BranslariCekme()
        {
            baglanti.Open();
            string sql = "select BransAd from Brans";
            SqlCommand cmd = new SqlCommand(sql, baglanti);

            SqlDataAdapter adaptor = new SqlDataAdapter(cmd);
           // adaptor.SelectCommand = cmd;

            DataSet ds = new DataSet();
            adaptor.Fill(ds);
            baglanti.Close();
            return ds;
        }
        
        public static List<string> DoktorlariCekme(string brans)
        {
            List<string> doktorlar = new List<string>();
            doktorlar.Clear();
            baglanti.Open();
            string sql = "select DoktorAdi, DoktorSoyadi from Doktor where DoktorBrans=@pBrans";
            SqlCommand cmd = new SqlCommand(sql, baglanti);
            cmd.Parameters.AddWithValue("@pBrans", brans);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                doktorlar.Add(dr[0] + " " + dr[1]);
            }
            baglanti.Close();
            return doktorlar;
        }
        public static DataTable RandevuCekme(string doktor)
        {
            baglanti.Open();
            string sql = "select * from Randevular where RandevuDoktor='" + doktor + "' and RandevuDurum=0";
            SqlCommand cmd = new SqlCommand(sql,baglanti);
            SqlDataAdapter adaptor = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adaptor.Fill(dt);
            baglanti.Close();
            return dt;
        }
        public static List<string> HastaBilgiDuzenleVeriCek(string tc)
        {
            baglanti.Open();
            List<string> hastalar = new List<string>();
            string sql = "select * from Hasta where HastaTC = '" + tc + "'";
            SqlCommand cmd = new SqlCommand(sql, baglanti);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                hastalar.Add(dr[1].ToString());
                hastalar.Add(dr[2].ToString());
                hastalar.Add(dr[4].ToString());
                hastalar.Add(dr[5].ToString());
                hastalar.Add(dr[6].ToString());
            }
            baglanti.Close();
            return hastalar;
        }
        public static void HastaBilgiGuncelle(string ad, string soyad, string tel, string sifre, string cins, string tc)
        {
            string sql = "update Hasta set HastaAdi=@pAd, HastaSoyadi=@pSoyad, HastaTelefon=@pTel ," +
                "HastaSifre=@pSifre, HastaCinsiyet=@pCins where HastaTC=@pTc";
            SqlCommand cmd = new SqlCommand(sql, baglanti);
            cmd.Parameters.AddWithValue("@pAd", ad);
            cmd.Parameters.AddWithValue("@pSoyad", soyad);
            cmd.Parameters.AddWithValue("@pTel", tel);
            cmd.Parameters.AddWithValue("@pSifre", sifre);
            cmd.Parameters.AddWithValue("@pCins", cins);
            cmd.Parameters.AddWithValue("@pTc", tc);
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }
        public static void RandevuAlma(string tc,string sikayet,string id)
        {
            string sql = "update Randevular set RandevuDurum=1 , HastaTc=@pTc , HastaSikayet=@pSkyt where Id=@pId";
            SqlCommand cmd = new SqlCommand(sql, baglanti);
            cmd.Parameters.AddWithValue("@pTc", tc);
            cmd.Parameters.AddWithValue("@pSkyt", sikayet);
            cmd.Parameters.AddWithValue("@pId",id);
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
