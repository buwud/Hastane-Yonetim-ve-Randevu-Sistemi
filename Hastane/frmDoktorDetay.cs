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
    public partial class frmDoktorDetay : Form
    {
        public frmDoktorDetay()
        {
            InitializeComponent();
        }
        public string tc;
        private void frmDoktorDetay_Load(object sender, EventArgs e)
        {
            lblTc.Text = tc;

            lblAdSoyad.Text = DatabaseDoktor.DoktorAdSoyadCekme(tc);

            DataSet ds = DatabaseDoktor.RandevuCekme(lblAdSoyad.Text);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            frmDoktorBilgiDuzenle doktorBilgiDuzenle = new frmDoktorBilgiDuzenle();
            doktorBilgiDuzenle.tc = lblTc.Text;
            
            
            doktorBilgiDuzenle.Show();

        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            frmDuyurular duyurular = new frmDuyurular();
            duyurular.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            rchSikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
