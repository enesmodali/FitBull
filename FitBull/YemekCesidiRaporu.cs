using Data;
using Model;
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
    public partial class YemekCesidiRaporu : Form
    {
        FitBullDbContext db;


        public YemekCesidiRaporu()
        {
            InitializeComponent();
        }

        private void btnYcrOgunlereDon_Click(object sender, EventArgs e)
        {
            Ogunler ogunler = new Ogunler();
            ogunler.Show();
            this.Hide();
        }

        //private void txtEnFazlaKahvalti_TextChanged(object sender, EventArgs e)
        //{
        //    txtEnFazlaKahvalti.Text = db.OgunBilgileri.GroupBy(x => x.OgunAdi.Contains("Kahvalti")).Select(y => new
        //    {
        //        YemekAdi = y.ToList();
        //    });   
        //}

        //private void txtEnFazlaOgle_TextChanged(object sender, EventArgs e)
        //{
        //    txtEnFazlaKahvalti.Text = db.OgunBilgileri.GroupBy(x => x.OgunAdi.Contains("OgleYemegi")).Select(y => new
        //    {
        //        YemekAdi = y.ToList();
        //    });   
        //}

        //private void txtEnFazlaAksam_TextChanged(object sender, EventArgs e)
        //{
        //    txtEnFazlaOgle.Text = db.OgunBilgileri.GroupBy(x => x.OgunAdi.Contains("AksamYemegi")).Select(y => new
        //    {
        //        YemekAdi = y.ToList();
        //    }); 
        //}

        //private void txtEnFazlaAperatif_TextChanged(object sender, EventArgs e)
        //{
        //    txtEnFazlaAksam.Text = db.OgunBilgileri.GroupBy(x => x.OgunAdi.Contains("Aperatif")).Select(y => new
        //    {
        //        YemekAdi = y.ToList();
        //    }); 
        //}

        //private void txtAdetKahvalti_TextChanged(object sender, EventArgs e)
        //{
        //    txtEnFazlaAperatif.Text = db.OgunBilgileri.GroupBy(x => x.OgunAdi.Contains("Kahvalti")).Select(y => new
        //    {
        //        YemekAdi = y.Miktar.ToString()
        //    }).Where(a => a.MAX(Count(b => b.YemekAdi)).ToList();
        //}

        //private void txtAdetOgle_TextChanged(object sender, EventArgs e)
        //{
        //    txtEnFazlaOgle.Text = db.OgunBilgileri.GroupBy(x => x.OgunAdi.Contains("AksamYemegi")).Select(y => new
        //    {
        //        YemekAdi = y.Miktar.ToString()
        //    }).Where(a => a.MAX(Count(b => b.YemekAdi)).ToList();
        //}

        //private void txtAdetAksam_TextChanged(object sender, EventArgs e)
        //{
        //    txtEnFazlaOgle.Text = db.OgunBilgileri.GroupBy(x => x.OgunAdi.Contains("AksamYemegi")).Select(y => new
        //    {
        //        YemekAdi = y.Miktar.ToString()
        //    }).Where(a => a.MAX(Count(b => b.YemekAdi)).ToList();
        //}

        //private void txtAdetAperatif_TextChanged(object sender, EventArgs e)
        //{
        //    txtEnFazlaAksam.Text = db.OgunBilgileri.GroupBy(x => x.OgunAdi.Contains("Aperatifler")).Select(y => new
        //    {
        //        YemekAdi = y.Miktar.ToString()
        //    }).Where(a => a.MAX(Count(b => b.YemekAdi)).ToList();
        //}
    }
}
