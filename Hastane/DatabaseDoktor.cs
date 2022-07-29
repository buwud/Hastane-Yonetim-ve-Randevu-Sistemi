using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Hastane
{
    internal class DatabaseDoktor
    {
        static SqlConnection baglanti = new SqlConnection(Baglanti.baglantiAdres);
        static public bool GirisYap(string tc, string sifre)
        {
            bool girdi = false;
            string sql = "select * from Doktor where DoktorTC=@pTc and DoktorSifre=@pSifre ";
            SqlCommand cmd = new SqlCommand(sql, baglanti);
            cmd.Parameters.AddWithValue("@pTc", tc);
            cmd.Parameters.AddWithValue("@pSifre", sifre);
            baglanti.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                girdi = true;
            }
            baglanti.Close();
            return girdi;
        }
        static string adsoyad;
        static public string DoktorAdSoyadCekme(string tc)
        {
            string sql = "select DoktorAdi, DoktorSoyadi from Doktor where DoktorTC=@pTc";
            SqlCommand cmd = new SqlCommand(sql, baglanti);
            cmd.Parameters.AddWithValue("@pTc", tc);
            baglanti.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                adsoyad = dr[0].ToString() + " " + dr[1].ToString();
            }
            baglanti.Close();
            return adsoyad;
        }
        static public DataSet RandevuCekme(string adsoyad1)
        {
            string sql = "select * from Randevular where RandevuDoktor = @pDoktor";
            SqlCommand cmd = new SqlCommand(sql, baglanti);
            cmd.Parameters.AddWithValue("@pDoktor", adsoyad1);
            SqlDataAdapter da=new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds);
            baglanti.Close();
            return ds;
        }
        static public void DoktorBilgiDuzenle(string ad, string soyad, string brans,string tc,string sifre)
        {
            string sql = "update Doktor set DoktorAdi=@pAd,DoktorSoyadi=@pSoyad,DoktorBrans=@pBrans,DoktorSifre=@pSifre" +
                " where DoktorTC=@pTc";
            SqlCommand cmd = new SqlCommand(sql, baglanti);
            cmd.Parameters.AddWithValue("@pAd", ad);
            cmd.Parameters.AddWithValue("@pSoyad", soyad);
            cmd.Parameters.AddWithValue("@pTc", tc);
            cmd.Parameters.AddWithValue("@pBrans", brans);
            cmd.Parameters.AddWithValue("@pSifre", sifre);
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }
        static public List<string> DoktorBilgiDuzenle1(string tc)
        {
            List<string> list = new List<string>();
            string sql = "select * from Doktor where DoktorTC=@pTc";
            SqlCommand cmd = new SqlCommand(sql, baglanti);
            cmd.Parameters.AddWithValue("@pTc", tc);
            baglanti.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list.Add(dr[1].ToString());
                list.Add(dr[2].ToString());
                list.Add(dr[3].ToString());
                list.Add(dr[5].ToString());
            }
            baglanti.Close();
            return list;
        }
        static public DataTable DoktorCmb()
        {
            string sql = "select * from Brans ";
            SqlCommand cmd = new SqlCommand(sql, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            baglanti.Open();
            da.Fill(dt);
            baglanti.Close();
            return dt;
        }
    }
}