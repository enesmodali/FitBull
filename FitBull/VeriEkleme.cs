using Data;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitBull
{
    public partial class VeriEkleme : Form
    {
        FitBullDbContext db;

        public VeriEkleme()
        {
            InitializeComponent();
            
        }


        private void btnVeriEkle_Click(object sender, EventArgs e)
        {
            if(txtYemekAdi.Text==null|| txtKategoriler.Text == null || txtBirim.Text == null || txtKalori.Text == null )
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!");
            }
            else
            {
                db.YemekBilgileri.Add(new Yemek()
                {
                    YemekKategorisi = txtKategoriler.Text,
                    YemekAdi = txtYemekAdi.Text,
                    Kalori = Convert.ToInt32(txtKalori.Text),
                    Birim = txtBirim.Text,
                    Admin = (Yonetici)ProgramYoneticisiGirisi.x     //Yönetici.cs'de Bunun metodu oluştu.
                });
            }
            db.SaveChanges();


            MessageBox.Show("Verileriniz başarılı bir şekilde kayıt edilmiştir.");
            txtKategoriler.Clear();
            txtYemekAdi.Clear();
            txtBirim.Clear();
            txtKalori.Clear();
            
        }

        private void btnVeriEklemeCikis_Click(object sender, EventArgs e)
        {
            ProgramYoneticisiIslemleri islemler = new ProgramYoneticisiIslemleri();
            islemler.Show();
            this.Hide();
        }
    }
}
