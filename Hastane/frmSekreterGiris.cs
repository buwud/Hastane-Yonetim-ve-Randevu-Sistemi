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
    public partial class frmSekreterGiris : Form
    {
        public frmSekreterGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (DatabaseSekreter.SekreterGirisKontrol(mskTc.Text, textSifre.Text))
            {
                MessageBox.Show("Giriş Başarılı!", "Sekreter Giriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmSekreterDetay sekreterDetay = new frmSekreterDetay();
                sekreterDetay.sekreterTc = mskTc.Text;
                sekreterDetay.Show();
                this.Hide();
                
            }
            else
                MessageBox.Show("Girilen TC no veya şifre yanlış!", "Sekreter Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
