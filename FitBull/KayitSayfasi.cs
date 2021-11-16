using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
using Model;

namespace FitBull
{
    public partial class KayitSayfasi : Form
    {
        FitBullDbContext db;

        

        public KayitSayfasi()
        {
            InitializeComponent();
        }

        

        private void btnKSKayitOl_Click(object sender, EventArgs e)
        {
            if (BosAlanVarMi())
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
            }
            
            
            
            else
            {
                db.KullanıcıBilgileri.Add(new Kullanici()
                {
                    KullaniciAdi = txtKSKullaniciAdi.Text,
                    Adi = txtKSAd.Text,
                    Soyadi = txtKSSoyadi.Text,
                    Sifre = txtKSSifre.Text,
                    SifreDogrulama = txtKSSifreDogrulama.Text,
                    Cinsiyet = (CinsiyetTürü)(cmbKSCinsiyet.SelectedIndex),
                    DogumTarihi =dtmKSDogumTarihi.Value,
                    Boy=(double)nmrKSBoy.Value,
                    Kilo=(double)nmrKSKilo.Value,
                });
                db.SaveChanges();

                MessageBox.Show("Kayıt işlemi başarı ile gerçekleşmiştir.");

                txtKSKullaniciAdi.Clear();
                txtKSAd.Clear();
                txtKSSoyadi.Clear();
                txtKSSifre.Clear();
                txtKSSifreDogrulama.Clear();
                cmbKSCinsiyet.SelectedIndex = 0;
                dtmKSDogumTarihi.Value = DateTime.Now.Date;
                nmrKSBoy.Value = 100;
                nmrKSKilo.Value = 35;


                KullaniciGirisi kullaniciGirisi = new KullaniciGirisi();
                kullaniciGirisi.Show();
                this.Hide();
            }
            
        }

        private bool BosAlanVarMi()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    if (item.Text == "")
                    {
                        return true;
                    }
                }
                else if (item is DateTimePicker)
                {
                    if (((DateTimePicker)item).Value.Date == DateTime.Now.Date)
                        return true;
                }
            }
            return false;
        }

        

        private void dtmKSDogumTarihi_Leave(object sender, EventArgs e)
        {
            if ((dtmKSDogumTarihi.Value).Year <= DateTime.Now.Year - 18)
            {
                MessageBox.Show("Kullanıcı olabilmeniz için 18 yaşından büyük olmanız gerekmektedir!");
            }
        }

        private void txtKSSifre_Leave(object sender, EventArgs e)
        {
            if (txtKSSifre.Text != txtKSSifre.Text)
            {
                MessageBox.Show("Şifreniz ve doğrulama şifreniz birbiriyle aynı olmalıdır!");
            }


            char[] karakter = (txtKSSifre.Text).ToCharArray();
            int toplam = 0;
            foreach (char item in karakter)
            {
                if (item != null)
                {
                    toplam++;
                }
            }
            if (toplam > 20)
            {
                MessageBox.Show("Şifre için yazabileceğiniz karakter sayısı 15'den fazla olamaz.");
            }
        }

        private void txtKSSifreDogrulama_Leave(object sender, EventArgs e)
        {
            if (txtKSSifre.Text != txtKSSifreDogrulama.Text)
            {
                MessageBox.Show("Şifreniz ve doğrulama şifreniz birbiriyle aynı olmalıdır!");
            }



            char[] karakter = (txtKSSifre.Text).ToCharArray();
            int toplam = 0;
            foreach (char item in karakter)
            {
                if (item != null)
                {
                    toplam++;
                }
            }
            if (toplam > 20)
            {
                MessageBox.Show("Şifre doğrulama için yazabileceğiniz karakter sayısı 15'den fazla olamaz.");
            }
        }

        private void txtKSAd_Leave(object sender, EventArgs e)
        {
            char[] karakter = (txtKSAd.Text).ToCharArray();
            int toplam = 0;
            foreach (char item in karakter)
            {
                if(item!=null)
                {
                    toplam++;
                }
            }
            if(toplam>20)
            {
                MessageBox.Show("İsim için yazabileceğiniz karakter sayısı 20'den fazla olamaz.");
            }
        }

        private void txtKSSoyadi_Leave(object sender, EventArgs e)
        {
            char[] karakter = (txtKSSoyadi.Text).ToCharArray();
            int toplam = 0;
            foreach (char item in karakter)
            {
                if (item != null)
                {
                    toplam++;
                }
            }
            if (toplam > 30)
            {
                MessageBox.Show("Soyad için yazabileceğiniz karakter sayısı 30'dan fazla olamaz.");
            }
        }

        private void txtKSKullaniciAdi_Leave(object sender, EventArgs e)
        {
            char[] karakter = (txtKSKullaniciAdi.Text).ToCharArray();
            int toplam = 0;
            foreach (char item in karakter)
            {
                if (item != null)
                {
                    toplam++;
                }
            }
            if (toplam > 50)
            {
                MessageBox.Show("Kullanıcı adı için yazabileceğiniz karakter sayısı 50'den fazla olamaz.");
            }
        }
    }
}
