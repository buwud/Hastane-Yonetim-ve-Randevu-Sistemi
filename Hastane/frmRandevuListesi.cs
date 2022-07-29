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
    public partial class frmRandevuListesi : Form
    {
        public frmRandevuListesi()
        {
            InitializeComponent();
        }

        private void frmRandevuListesi_Load(object sender, EventArgs e)
        {
            DataTable dt = DatabaseSekreter.RandevuPanel();
            dataGridView1.DataSource = dt;
        }
        public static int secilen;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            frmSekreterDetay.id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            frmSekreterDetay.tarih= dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            frmSekreterDetay.saat= dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            frmSekreterDetay.brans= dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            frmSekreterDetay.doktor= dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            frmSekreterDetay.tc= dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            this.Close();

        }
    }
}
