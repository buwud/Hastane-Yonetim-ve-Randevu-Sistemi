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
    public partial class frmDoktorGiris : Form
    {
        public frmDoktorGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {

            if (DatabaseDoktor.GirisYap(maskedTc.Text, textSifre.Text))
            {
                frmDoktorDetay doktorDetay = new frmDoktorDetay();
                MessageBox.Show("Giriş başarılı!", "Doktor Girişi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                doktorDetay.tc = maskedTc.Text;
                doktorDetay.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Hatalı kullanıcı adı veya şifre!", "Doktor Girişi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
