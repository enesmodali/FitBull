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
    public partial class KisiselKaloriAnalizi : Form
    {
        public KisiselKaloriAnalizi()
        {
            InitializeComponent();
        }

        private void btnKKAOgunlereDon_Click(object sender, EventArgs e)
        {
            Ogunler ogunler = new Ogunler();
            ogunler.Show();
            this.Hide();
        }
    }
}
