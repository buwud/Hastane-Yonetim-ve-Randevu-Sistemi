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
    }
}
