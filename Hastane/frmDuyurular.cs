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
    public partial class frmDuyurular : Form
    {
        public frmDuyurular()
        {
            InitializeComponent();
        }

        private void frmDuyurular_Load(object sender, EventArgs e)
        {
            DataTable dt = DatabaseSekreter.Duyurular();
            dataGridView1.DataSource = dt;
        }
    }
}
