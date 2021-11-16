using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Data;

namespace FitBull
{
    public partial class Yemekler : Form
    {
        FitBullDbContext db = new FitBullDbContext();

        public Yemekler()
        {
            InitializeComponent();
        }


        private void Yemekler_Load(object sender, EventArgs e)
        {
            dgvYemekListesi.Columns[0].Name = "Yemek Adi";
            dgvYemekListesi.Columns[1].Name = "Yemek Kategorisi";
            dgvYemekListesi.Columns[2].Name = "Birim";
            dgvYemekListesi.Columns[3].Name = "Kalori";
            dgvYemekListesi.Columns[4].Name = "Ogun Adi";


        }


        public void btnOgunEkle_Click(object sender, EventArgs e)   //Girilen yemek bilgilerini DataGridView'a ekleyecek. Ekran bu sayfada kalıcak.
        {
            dgvYemekListesi.Rows.Add(cmbYemekler.Text, cmbKategorilerYemekÇeşitleri.Text, txtYemeklerBirim.Text, txtYemeklerKalori.Text, cmbOgunSec.Text);                                                          //Burası Doğru mu?         

            dgvYemekListesi.DataSource = db.OgunBilgileri.ToList();

            MessageBox.Show("Yemekler Eklenmiştir.");

            foreach (Control item in Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
                else if(item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        public void cmbKategorilerYemekÇeşitleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbKategorilerYemekÇeşitleri.Text = Convert.ToString(db.YemekBilgileri.OrderBy(x => x.YemekKategorisi).ToList());
        }

        private void cmbYemekler_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbYemekler.Text = Convert.ToString(db.YemekBilgileri.OrderBy(x => x.YemekAdi).ToList());
        }

        public void txtYemeklerKalori_TextChanged(object sender, EventArgs e)
        {
            txtYemeklerKalori.Text = Convert.ToString(db.YemekBilgileri.OrderBy(x => x.Kalori).Where(y=>y.YemekAdi==cmbYemekler.Text).ToString());
        }

        private void txtYemeklerBirim_TextChanged(object sender, EventArgs e)
        {
            txtYemeklerKalori.Text = Convert.ToString(db.YemekBilgileri.OrderBy(x => x.Birim).Where(y => y.YemekAdi == cmbYemekler.Text).ToString());
        }

        private void cmbOgunSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbOgunSec.Text = Convert.ToString(db.OgunBilgileri.OrderBy(x => x.OgunAdi).ToList());
        }

        public void btnOgunlereDon_Click(object sender, EventArgs e)    //Öğün bilgilerimi database'e kaydedicek. Sonra da Öğünler Sayfama gidicek.
        {


            int ID = db.YemekBilgileri.Where(x => x.YemekAdi == cmbYemekler.Text).FirstOrDefault().YemekID;

            Ogunler ogunler = new Ogun { OgunAdi = "cmbSec.Text", Tarih = Ogunler.tarih, };

            


            //MessageBox.Show("Verileriniz başarılı bir şekilde kayıt edilmiştir.");
            //txtKategoriler.Clear();
            //txtYemekAdi.Clear();
            //txtBirim.Clear();
            //txtKalori.Clear();


            MessageBox.Show("Öğün Eklenmiştir.");
            
            Ogunler ogunler2 = new Ogunler();
            ogunler2.Show();
            this.Hide();
        }
    }
}
