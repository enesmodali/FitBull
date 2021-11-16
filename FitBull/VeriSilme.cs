using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Migrations;
using Model;
using Data;

namespace FitBull
{
    public partial class VeriSilme : Form
    {
        FitBullDbContext db;
        public VeriSilme()
        {
            InitializeComponent();
        }

        private void btnVeriSil_Click(object sender, EventArgs e)
        {
            
            Yemek yemek = db.YemekBilgileri.Find("cmbYemekID.Text");        // BURASI SORULACAK.
            db.YemekBilgileri.Remove(yemek);
            db.SaveChanges();

            
        }

        private void btnVeriSilCikis_Click(object sender, EventArgs e)
        {
            ProgramYoneticisiIslemleri islemler = new ProgramYoneticisiIslemleri();
            islemler.Show();
            this.Hide();
        }

        private void cmbYemekAdi_SelectedIndexChanged(object sender, EventArgs e)
        {

            //int toplam = (db.YemekBilgileri.Count(a => a.YemekID));

            //for (int i = 1; i <= toplam; i++)
            //{
            //    cmbYemekID.Text=YemekBilgileri.YemekID.Find(i);
            //}

            cmbYemekID.Text = Convert.ToString(db.YemekBilgileri.OrderBy(x=>x.YemekID).ToString());
        }
    }
}
