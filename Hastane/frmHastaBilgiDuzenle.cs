using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane
{
    public partial class frmHastaBilgiDuzenle : Form
    {
        public frmHastaBilgiDuzenle()
        {
            InitializeComponent();
        }
        public string hastaTc;
        private void frmHastaBilgiDuzenle_Load(object sender, EventArgs e)
        {
            textTc.Text = hastaTc;
            List<string> list = DatabaseHasta.HastaBilgiDuzenleVeriCek(hastaTc);
            textAd.Text = list[0];
            textSoyad.Text = list[1];
            textTelNo.Text = list[2];
            textSifre.Text = list[3];
            comboCins.Text = list[4];
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            if (textAd.Text != "" && textSoyad.Text != "" && textTelNo.Text != "" &&
            textSifre.Text != "" && comboCins.Text != "" && textTelNo.Text.ToString().Length == 14)
            {
                DatabaseHasta.HastaBilgiGuncelle(textAd.Text, textSoyad.Text, textTelNo.Text, textSifre.Text, comboCins.Text, textTc.Text);
                MessageBox.Show("Hasta bilgileriniz başarıyla güncellendi!", "Bilgi Düzenleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Yanlış veya eksik bilgi girişi yaptınız, tekrar deneyiniz!", "Hasta Kaydı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
