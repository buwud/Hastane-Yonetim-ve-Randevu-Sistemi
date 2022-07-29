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
    public partial class frmSekreterDetay : Form
    {
        public frmSekreterDetay()
        {
            InitializeComponent();
        }
        public string sekreterTc;
        private void frmSekreterDetay_Load(object sender, EventArgs e)
        {
            lblTc.Text = sekreterTc;
            lblAdSoyad.Text = DatabaseSekreter.SekreterAdSoyadCekme(sekreterTc).ToString();
            
            dataBranslar.DataSource = DatabaseSekreter.BranslariCekme().Tables[0];
            dataDoktorlar.DataSource = DatabaseSekreter.DoktorlariCekme().Tables[0];

            DataSet ds = DatabaseSekreter.BranslariCekme();
            cmbBrans.DisplayMember="BransAd";
            cmbBrans.ValueMember = "BransId";
            cmbBrans.DataSource = ds.Tables[0];
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            DatabaseSekreter.RandevuKaydetme(mskTarih.Text, mskSaat.Text, cmbBrans.Text, cmbDoktor.Text);
            MessageBox.Show("Randevu kaydı başarılı! ", "Randevu Kaydı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            List<string> doktorlar = DatabaseSekreter.DoktorlariComboyaCekme(cmbBrans.Text);
            int sayac = doktorlar.Count;
            while (sayac > 0)
            {
                sayac--;
                cmbDoktor.Items.Add(doktorlar[sayac]);
            }
        }
        private void btnOlustur_Click(object sender, EventArgs e)
        {
            DatabaseSekreter.DuyuruOlusturma(rchDuyuru.Text);
            rchDuyuru.Clear();
            MessageBox.Show("Duyuru başarıyla oluşturuldu!", "Duyuru Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDoktorPanel_Click(object sender, EventArgs e)
        {
            frmDoktorPanel doktorPanel = new frmDoktorPanel();
            doktorPanel.Show();
        }

        private void btnBransPanel_Click(object sender, EventArgs e)
        {
            frmBransPanel bransPanel = new frmBransPanel();
            bransPanel.Show();
        }

        private void btnRandevuList_Click(object sender, EventArgs e)
        {
            frmRandevuListesi randevular = new frmRandevuListesi();
            randevular.Show();
        }
        static public string id, tarih, saat, brans, doktor, tc;
        private void button1_Click(object sender, EventArgs e)
        {
            txtId.Text = id;
            mskTarih.Text = tarih;
            mskSaat.Text = saat;
            cmbBrans.Text = brans;
            cmbDoktor.Text = doktor;
            mskTc.Text = tc;
        }
    }
}
