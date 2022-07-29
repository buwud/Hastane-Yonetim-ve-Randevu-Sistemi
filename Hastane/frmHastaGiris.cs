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
    public partial class frmHastaGiris : Form
    {
        public frmHastaGiris()
        {
            InitializeComponent();
        }

        private void linklblUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmHastaKayit hastaKayit = new frmHastaKayit();
            hastaKayit.Show();

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (DatabaseHasta.HastaGirisi(maskedTc.Text, textSifre.Text)&& maskedTc.Text!=""&& textSifre.Text!="")
            {
                
                MessageBox.Show("Giriş Başarılı!", "Hasta Giriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmHastaDetay hastaDetay = new frmHastaDetay();
                hastaDetay.tc = maskedTc.Text;
                hastaDetay.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Girilen TC no veya şifre yanlış!", "Hasta Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
