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
    public partial class KullaniciTipi : Form
    {
        public KullaniciTipi()
        {
            InitializeComponent();
        }

        private void btnKTYoneticiGirisiDevam_Click(object sender, EventArgs e)
        {
            ProgramYoneticisiGirisi programYönetici = new ProgramYoneticisiGirisi();
            programYönetici.Show();

            this.Hide();
        }

        private void btnKTKullaniciGirisiIleDevam_Click(object sender, EventArgs e)
        {
            KullaniciGirisi kullaniciGiris = new KullaniciGirisi();
            kullaniciGiris.Show();

            this.Hide();
        }
    }
}
