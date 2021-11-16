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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void btnOgunler_Click(object sender, EventArgs e)
        {
            Ogunler ogunler = new Ogunler();
            ogunler.Show();
            this.Hide();
        }


        private void btnKisiselKaloriAnalizi_Click(object sender, EventArgs e)
        {
            KisiselKaloriAnalizi kisiselKaloriAnalizi = new KisiselKaloriAnalizi();
            kisiselKaloriAnalizi.Show();
            this.Hide();
        }

        private void btnGenelKaloriAnalizi_Click(object sender, EventArgs e)
        {
            GenelKaloriAnalizi genelKaloriAnalizi = new GenelKaloriAnalizi();
            genelKaloriAnalizi.Show();
            this.Hide();
        }

        private void btnYemekCesidiRaporu_Click(object sender, EventArgs e)
        {
            YemekCesidiRaporu yemekCesidiRaporu = new YemekCesidiRaporu();
            yemekCesidiRaporu.Show();
            this.Hide();
        }
    }
}
