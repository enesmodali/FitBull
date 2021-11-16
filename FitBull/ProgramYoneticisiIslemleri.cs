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
    public partial class ProgramYoneticisiIslemleri : Form
    {
        public ProgramYoneticisiIslemleri()
        {
            InitializeComponent();
        }

        

        private void btnPYIVeriEkle_Click(object sender, EventArgs e)
        {
            VeriEkleme veriEkleme = new VeriEkleme();
            veriEkleme.Show();
            this.Hide();
        }

        private void btnPYIVeriSil_Click(object sender, EventArgs e)
        {
            VeriSilme veriSilme = new VeriSilme();
            veriSilme.Show();
            this.Hide();
        }

        private void btnPYICikis_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
