using Data;
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
    public partial class GenelKaloriAnalizi : Form
    {
        public GenelKaloriAnalizi()
        {
            InitializeComponent();
        }

        FitBullDbContext db = new FitBullDbContext();

        private void btnGKAOgunlereDon_Click(object sender, EventArgs e)
        {
            Ogunler ogunler = new Ogunler();
            ogunler.Show();
            this.Hide();
        }

        private void btnGunluk_Click(object sender, EventArgs e)
        {
            txtGKAEnazKaloriKategori.Text = Convert.ToString(db.OgunBilgileri.Where(y=>y.Tarih==DateTime.Now).Min(z => z.OgunKalorisi).ToString());

            txtGKAEnFazlaKaloriOgun.Text = Convert.ToString(db.OgunBilgileri.Where(y => y.Tarih == DateTime.Now).Max(z => z.OgunKalorisi).ToString());

            txtGKAEnazKaloriKategori.Text = db.YemekBilgileri.GroupBy(y => y.YemekKategorisi).Select(k => new
            {
                EnAzKalori = k.Min(o=>o.Kalori)
            }).ToString();

            txtGKAEnFazlaKaloriKategori.Text = db.YemekBilgileri.GroupBy(y => y.YemekKategorisi).Select(k => new
            {
                EnFazlaKalori = k.Max(o => o.Kalori)
            }).ToString();
        }

        private void GenelKaloriAnalizi_Load(object sender, EventArgs e)
        {
            txtGKAEnazKaloriKategori.Text = "";
            txtGKAEnAzKaloriOgun.Text = "";
            txtGKAEnFazlaKaloriKategori.Text = "";
            txtGKAEnFazlaKaloriOgun.Text = "";
        }

        private void btnHaftalik_Click(object sender, EventArgs e)
        {
            //txtGKAEnazKaloriKategori.Text = db.OgunBilgileri.Select(k=>"DateDiff(DAY,DateTime.Now.Day,GetDate())").Min(z => z.OgunKalorisi).ToString());

            txtGKAEnFazlaKaloriOgun.Text = Convert.ToString(db.OgunBilgileri.Where(y => y.Tarih == DateTime.Now).Max(z => z.OgunKalorisi).ToString());

            txtGKAEnazKaloriKategori.Text = db.YemekBilgileri.GroupBy(y => y.YemekKategorisi).Select(k => new
            {
                EnAzKalori = k.Min(o => o.Kalori)
            }).ToString();

            txtGKAEnFazlaKaloriKategori.Text = db.YemekBilgileri.GroupBy(y => y.YemekKategorisi).Select(k => new
            {
                EnFazlaKalori = k.Max(o => o.Kalori)
            }).ToString();
        }
    }
}
