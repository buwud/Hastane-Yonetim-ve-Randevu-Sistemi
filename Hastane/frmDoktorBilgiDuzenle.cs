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

namespace Hastane
{
    public partial class frmDoktorBilgiDuzenle : Form
    {
        public frmDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            DatabaseDoktor.DoktorBilgiDuzenle(textAd.Text, textSoyad.Text, cmbBrans.Text, textTc.Text, textSifre.Text);
            MessageBox.Show("Bilgileriniz başarıyla güncellendi!", "Doktor Bilgi Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public string tc;
        private void frmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            textTc.Text = tc;
            List<string> branslar = DatabaseDoktor.DoktorBilgiDuzenle1(tc);
            textAd.Text = branslar[0];
            textSoyad.Text=branslar[1];
            cmbBrans.Text=branslar[2];
            textSifre.Text = branslar[3];

            DataTable dt = DatabaseDoktor.DoktorCmb();
            cmbBrans.DisplayMember = "BransAd";
            cmbBrans.ValueMember = "BransId";
            cmbBrans.DataSource = dt;
        }
    }
}
