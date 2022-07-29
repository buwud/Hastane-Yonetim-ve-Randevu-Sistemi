using System.Configuration;
namespace Hastane
{
    public partial class Hastane : Form
    {
        public Hastane()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmHastaGiris hastaGiris = new frmHastaGiris();
            hastaGiris.Show();
            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmDoktorGiris doktorGiris = new frmDoktorGiris();
            doktorGiris.Show();
            //this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmSekreterGiris sekreterGiris = new frmSekreterGiris();
            sekreterGiris.Show();
            //this.Hide();
        }
    }
}
