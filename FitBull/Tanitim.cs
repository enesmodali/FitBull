using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitBull
{
    public partial class Tanitim : Form
    {
        public Tanitim()
        {
            InitializeComponent(); 
        }

        private void btnIleri_Click(object sender, EventArgs e)
        {
            KullaniciTipi kullaniciTipi = new KullaniciTipi();
            kullaniciTipi.Show();

            this.Hide();

        }
    }
}
