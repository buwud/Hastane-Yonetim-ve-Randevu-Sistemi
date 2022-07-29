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
    public partial class frmHastaDetay : Form
    {
        public frmHastaDetay()
        {
            InitializeComponent();
        }
        public string tc;

        private void frmHastaDetay_Load(object sender, EventArgs e)
        {
            lblTc.Text = tc;
            lblAdSoyad.Text = DatabaseHasta.AdSoyadCekme(tc);
            dataGridView1.DataSource = DatabaseHasta.DataGecmişRandevu(tc);

            DataSet ds = DatabaseHasta.BranslariCekme();
            cmbBrans.DisplayMember = "BransAd";
            cmbBrans.ValueMember = "BransId";
            cmbBrans.DataSource = ds.Tables[0];  
        }
        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            int sayac = DatabaseHasta.DoktorlariCekme(cmbBrans.Text).Count;
            while (sayac > 0)
            {
                sayac--;
                cmbDoktor.Items.Add(DatabaseHasta.DoktorlariCekme(cmbBrans.Text)[sayac]);
            }
            
        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = DatabaseHasta.RandevuCekme(cmbDoktor.Text);
        }

        private void lnkBilgiDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmHastaBilgiDuzenle frmHastaBilgiDuzenle = new frmHastaBilgiDuzenle();
            frmHastaBilgiDuzenle.hastaTc = lblTc.Text;
            frmHastaBilgiDuzenle.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            cmbBrans.Text = dataGridView2.Rows[secilen].Cells[3].Value.ToString();
            cmbDoktor.Text = dataGridView2.Rows[secilen].Cells[4].Value.ToString();

        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                DatabaseHasta.RandevuAlma(lblTc.Text, rchSikayet.Text, txtId.Text);
                MessageBox.Show("Randevu alma işleminiz başarılı!", "Randevu Alma", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Lütfen bir randevu seçiniz!", "Randevu Alma", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cmbDoktor.Text = "";
            cmbBrans.Text = "";
        }
    }
}
