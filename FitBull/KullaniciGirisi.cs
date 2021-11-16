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
    public partial class KullaniciGirisi : Form
    {
        FitBullDbContext db;

        public KullaniciGirisi()
        {
            InitializeComponent();
        }

        public static string kullaniciIsim;
        public static string kullaniciPasword;

        
        

        private void btnKGKayitOl_Click(object sender, EventArgs e)
        {
            KayitSayfasi kayitSayfasi = new KayitSayfasi();
            kayitSayfasi.Show();
            this.Hide();

        }

        private void btnKGGiris_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();

            if(txtKGKullaniciAdi.Text==null || txtKGSifre.Text==null)
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifrenizi giriniz.");
                txtKGKullaniciAdi.Text = "";
                txtKGSifre.Text = "";
            }
            else if(kullaniciIsim!=txtKGKullaniciAdi.Text)         
            {
                MessageBox.Show("Kullanıcı adınız hatalı! Lütfen tekrar giriniz.");
                txtKGKullaniciAdi.Text = "";
            }
            else if (kullaniciPasword!= txtKGSifre.Text)
            {
                MessageBox.Show("Şifreniz hatalı! Lütfen tekrar giriniz.");
                txtKGSifre.Text = "";
            }
            else
            {
                AnaSayfa anaSayfa = new AnaSayfa();
                anaSayfa.Show();
                this.Hide();
            }
            kullaniciIsim = txtKGKullaniciAdi.Text;
            kullaniciPasword = txtKGSifre.Text;
        }
    }
}
