using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Hastane
{
    internal class DatabaseSekreter
    {
        static SqlConnection baglanti = new SqlConnection(Baglanti.baglantiAdres);
        static public bool SekreterGirisKontrol(string tc, string sifre)
        {
            baglanti.Open();
            bool girdi = false;
            string sql = "select * from Sekreter where SekreterTC = @pTc and SekreterSifre = @pSifre";
            SqlCommand cmd = new SqlCommand(sql, baglanti);
            cmd.Parameters.AddWithValue("@pTc", tc);
            cmd.Parameters.AddWithValue("@pSifre", sifre);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                girdi = true;
            }
            baglanti.Close();
            return girdi;
        }
        static string adsoyad;
        static public string SekreterAdSoyadCekme(string tc)
        {
            string sql = "select SekreterAdSoyad from Sekreter where SekreterTC=@pTc";
            SqlCommand cmd = new SqlCommand(sql, baglanti);
            cmd.Parameters.AddWithValue("@pTc", tc);
            baglanti.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                adsoyad = dr[0].ToString();
            }
            baglanti.Close();
            return adsoyad;
        }
        static public DataSet BranslariCekme()
        {
            string sql = "select BransAd from Brans";
            SqlCommand cmd = new SqlCommand(sql, baglanti);
            SqlDataAdapter adaptor = new SqlDataAdapter();
            adaptor.SelectCommand = cmd;
            DataSet ds = new DataSet();
            baglanti.Open();
            adaptor.Fill(ds);
            baglanti.Close();
            return ds;
        }
        static public DataSet DoktorlariCekme()
        {
            string sql = "select (DoktorAdi+ ' '+ DoktorSoyadi) as Doktorlar,DoktorBrans as Branşlar from Doktor";
            SqlCommand cmd = new SqlCommand(sql, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds);
            baglanti.Close();
            return ds;
        }
        static public void RandevuKaydetme(string tarih, string saat, string brans, string doktor)
        {
            string sql = "insert into Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) " +
                "values (@pTarih,@pSaat,@pBrans,@pDoktor)";
            SqlCommand cmd = new SqlCommand(sql, baglanti);
            cmd.Parameters.AddWithValue("@pTarih", tarih);
            cmd.Parameters.AddWithValue("@pSaat", saat);
            cmd.Parameters.AddWithValue("@pBrans", brans);
            cmd.Parameters.AddWithValue("@pDoktor", doktor);
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }
        static public DataSet BranslariComboyaCekme()
        {
            string sql = "select BransAd from Brans";
            SqlCommand cmd = new SqlCommand(sql, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds);
            baglanti.Close();
            return ds;
        }
        static public List<string> DoktorlariComboyaCekme(string brans)
        {
            List<string> doktorlar = new List<string>();
            string sql = "select DoktorAdi,DoktorSoyadi from Doktor where DoktorBrans=@pBrans";
            SqlCommand cmd = new SqlCommand(sql, baglanti);
            cmd.Parameters.AddWithValue("@pBrans", brans);
            baglanti.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                doktorlar.Add(dr[0] + " " + dr[1]);
            }
            baglanti.Close();
            return doktorlar;
        }
        static public void DuyuruOlusturma(string duyuru)
        {
            string sql = "insert into Duyurular (Duyuru) values (@pDuyuru)";
            SqlCommand cmd = new SqlCommand(sql, baglanti);
            cmd.Parameters.AddWithValue("@pDuyuru", duyuru);
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }
        static public DataSet DoktorPanel()
        {
            string sql = "select * from Doktor";
            SqlCommand cmd = new SqlCommand(sql, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds);
            baglanti.Close();
            return ds;
        }
        static public void DoktorPaneldenDrEkleme(string ad, string soyad, string brans,string tc,string sifre)
        {
            string sql = "insert into Doktor (DoktorAdi,DoktorSoyadi,DoktorBrans,DoktorTC,DoktorSifre)" +
                " values (@pAd,@pSoyad,@pBrans,@pTC,@pSifre)";
            SqlCommand cmd = new SqlCommand(sql, baglanti);
            cmd.Parameters.AddWithValue("@pAd", ad);
            cmd.Parameters.AddWithValue("@pSoyad", soyad);
            cmd.Parameters.AddWithValue("@pBrans", brans);
            cmd.Parameters.AddWithValue("@pTC", tc);
            cmd.Parameters.AddWithValue("@pSifre", sifre);
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }
        static public DataSet DoktorPanelBransCmb()
        {
            string sql = "select BransAd from Brans";
            SqlCommand cmd = new SqlCommand(sql, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            baglanti.Open();
            da.Fill(ds);
            baglanti.Close();
            return ds;
        }
        static public void DoktorPaneldenDrGuncelleme(string ad, string soyad, string brans, string tc, string sifre)
        {
            string sql = "update Doktor set DoktorAdi=@pAd,DoktorSoyadi=@pSoyad,DoktorBrans=@pBrans," +
                "DoktorSifre=@pSifre where DoktorTC=@pTc";
            SqlCommand cmd = new SqlCommand(sql, baglanti);
            cmd.Parameters.AddWithValue("@pAd", ad);
            cmd.Parameters.AddWithValue("@pSoyad", soyad);
            cmd.Parameters.AddWithValue("@pBrans", brans);
            cmd.Parameters.AddWithValue("@pTc", tc);
            cmd.Parameters.AddWithValue("@pSifre", sifre);
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }
        static public void DoktorPaneldenDrSilme(string tc)
        {
            string sql = "delete from Doktor where DoktorTC=@pTc";
            SqlCommand cmd = new SqlCommand(sql, baglanti);
            cmd.Parameters.AddWithValue("@pTc", tc);
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }
        static public DataTable BransPaneliCekme()
        {
            string sql = "select * from Brans";
            SqlCommand cmd = new SqlCommand(sql, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            baglanti.Open();
            da.Fill(dt);
            baglanti.Close();
            return dt;
        }
        static public void BransPaneliEkleme(string ad)
        {
            string sql = "insert into Brans (BransAd) values (@pAd)";
            SqlCommand cmd = new SqlCommand(sql, baglanti);
            cmd.Parameters.AddWithValue("@pAd", ad);
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }
        static public void BransPaneliSilme(string id)
        {
            string sql = "delete from Brans where BransId=@pId ";
            SqlCommand cmd = new SqlCommand(sql, baglanti);
            cmd.Parameters.AddWithValue("@pId", id);
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }
        static public void BransPanelGuncelleme(string id,string ad)
        {
            string sql = "update Brans set BransAd=@pAd where BransId=@pId";
            SqlCommand cmd = new SqlCommand(sql, baglanti);
            cmd.Parameters.AddWithValue("@pAd", ad);
            cmd.Parameters.AddWithValue("@pId", id);
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }
        static public DataTable RandevuPanel()
        {
            string sql = "select * from Randevular";
            SqlCommand cmd = new SqlCommand(sql, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            baglanti.Open();
            da.Fill(dt);
            baglanti.Close();
            return dt;
        }
        static public DataTable Duyurular()
        {
            string sql = "select * from Duyurular";
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