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
    public partial class frmDoktorPanel : Form
    {
        public frmDoktorPanel()
        {
            InitializeComponent();
        }

        private void frmDoktorPanel_Load(object sender, EventArgs e)
        {
            DataSet ds = DatabaseSekreter.DoktorPanel();
            dataGridView1.DataSource = ds.Tables[0];

            DataSet ds1 = DatabaseSekreter.DoktorPanelBransCmb();
            cmbBrans.DisplayMember = "BransAd";
            cmbBrans.ValueMember = "BransId";
            cmbBrans.DataSource = ds1.Tables[0];
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != "" && txtSoyad.Text != "" && txtSifre.Text != "" && mskTc.Text.ToString().Length == 11)
            {
                DatabaseSekreter.DoktorPaneldenDrEkleme(txtAd.Text, txtSoyad.Text, cmbBrans.Text, mskTc.Text, txtSifre.Text);
                MessageBox.Show("Yeni doktor eklemesi başarıyla gerçekleştirildi!", "Doktor Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Yanlış veya eksik bilgi girişi yaptınız, tekrar deneyiniz!", "Doktor Kaydı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbBrans.Text= dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskTc.Text= dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtSifre.Text= dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != "" && txtSoyad.Text != "" && txtSifre.Text != "" && mskTc.Text.ToString().Length == 11)
            {
                DatabaseSekreter.DoktorPaneldenDrGuncelleme(txtAd.Text, txtSoyad.Text, cmbBrans.Text, mskTc.Text, txtSifre.Text);
                MessageBox.Show("Doktor güncellemesi başarıyla gerçekleştirildi!", "Doktor Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Yanlış veya eksik bilgi girişi yaptınız, tekrar deneyiniz!", "Doktor Kaydı", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DatabaseSekreter.DoktorPaneldenDrSilme(mskTc.Text);
            MessageBox.Show("Doktor silme başarıyla gerçekleştirildi!", "Doktor Silme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
