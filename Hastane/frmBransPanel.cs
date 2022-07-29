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
    public partial class frmBransPanel : Form
    {
        public frmBransPanel()
        {
            InitializeComponent();
        }

        private void frmBransPanel_Load(object sender, EventArgs e)
        {
            DataTable dt = DatabaseSekreter.BransPaneliCekme();
            dataGridView1.DataSource= dt;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtBrans.Text != "")
            {
                DatabaseSekreter.BransPaneliEkleme(txtBrans.Text);
                MessageBox.Show("Yeni branş eklemesi başarıyla gerçekleştirildi!", "Branş Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Yanlış veya eksik bilgi girişi yaptınız, tekrar deneyiniz!", "Branş Kaydı", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtBrans.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DatabaseSekreter.BransPaneliSilme(txtID.Text);
            MessageBox.Show("Branş silme başarıyla gerçekleştirildi!", "Branş Silme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" && txtID.Text != "")
            {
                DatabaseSekreter.BransPanelGuncelleme(txtID.Text, txtBrans.Text);
                MessageBox.Show("Branş güncellemesi başarıyla gerçekleştirildi!", "Branş Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Yanlış veya eksik bilgi girişi yaptınız, tekrar deneyiniz!", "Branş Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
