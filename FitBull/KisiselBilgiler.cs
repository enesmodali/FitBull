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
    public partial class KisiselBilgiler : Form
    {

        FitBullDbContext db;

        public KisiselBilgiler()
        {
            InitializeComponent();
        }

        private void txtKBAdi_TextChanged(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();          //LINQ İLE VERİLERİ GETİRCEZ.
            txtKBAdi.Text = kullanici.Adi;
            txtKBAdi.Enabled = false;
        }

        private void txtKBSoyad_TextChanged(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();
            txtKBSoyad.Text = kullanici.Soyadi;
            txtKBSoyad.Enabled = false;
        }

        private void txtKBKullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();
            txtKBKullaniciAdi.Text = kullanici.KullaniciAdi;
            txtKBKullaniciAdi.Enabled = false;
        }

        private void cmbKBCinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();
            cmbKBCinsiyet.Text = Convert.ToString(kullanici.Cinsiyet);
            cmbKBCinsiyet.Enabled = false;
        }

        private void dtpKBDogumTarihi_ValueChanged(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();
            dtpKBDogumTarihi.Value = kullanici.DogumTarihi;
            dtpKBDogumTarihi.Enabled = false;
        }

        private void nmrKBBoy_ValueChanged(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();
            nmrKBBoy.Value =Convert.ToDecimal(kullanici.Boy);
            nmrKBBoy.Enabled = false;

        }

        private void nmrKBKilo_ValueChanged(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();
            nmrKBKilo.Value = Convert.ToDecimal(kullanici.Kilo);
            nmrKBKilo.Enabled = false;
        }

        private void txtKBSifre_TextChanged(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();
            txtKBSifre.Text = kullanici.Sifre;
            txtKBSifre.Enabled = false;
        }

        private void btnKbGeri_Click(object sender, EventArgs e)
        {
            Ogunler ogun = new Ogunler();
            ogun.Show();
            this.Hide();
        }

        private void btnKbDuzenle_Click(object sender, EventArgs e)
        {
            txtKBAdi.Enabled = true;
            txtKBSoyad.Enabled = true;
            txtKBKullaniciAdi.Enabled = true;
            cmbKBCinsiyet.Enabled = true;
            dtpKBDogumTarihi.Enabled = true;
            nmrKBBoy.Enabled = true;
            nmrKBKilo.Enabled = true;
            txtKBSifre.Enabled = true;
        }

        private void btnKbDegisiklikleriKaydet_Click(object sender, EventArgs e)
        {
            if (BosAlanVarMi())
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
            }
            else
            {
                db.KullanıcıBilgileri.Add(new Kullanici()
                {
                    KullaniciAdi = txtKBKullaniciAdi.Text,
                    Adi = txtKBAdi.Text,
                    Soyadi = txtKBSoyad.Text,
                    Sifre = txtKBSifre.Text,
                    Cinsiyet = (CinsiyetTürü)(cmbKBCinsiyet.SelectedIndex),
                    DogumTarihi = dtpKBDogumTarihi.Value,
                    Boy = (double)nmrKBBoy.Value,
                    Kilo = (double)nmrKBKilo.Value,
                });
                db.SaveChanges();

                MessageBox.Show("Kayıt işlemi başarı ile gerçekleşmiştir.");

                txtKBAdi.Clear();
                txtKBSoyad.Clear();
                txtKBSifre.Clear();
                cmbKBCinsiyet.SelectedIndex=0;
                dtpKBDogumTarihi.Value = DateTime.Now.Date;
                nmrKBBoy.Value = 100;
                nmrKBKilo.Value = 35;
                txtKBKullaniciAdi.Clear();


                Ogunler ogunler = new Ogunler();
                ogunler.Show();
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
                else if (item is ComboBox)
                {
                    if (((ComboBox)item).SelectedIndex == 0)
                        return true;
                }
            }
            return false;
        }

        
    }
}
