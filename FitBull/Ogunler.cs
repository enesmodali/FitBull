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

    public partial class Ogunler : Form
    {
        FitBullDbContext db = new FitBullDbContext();

        public static DateTime tarih;

        public Ogunler()
        {
            InitializeComponent();
        }

        private void Ogunler_Load(object sender, EventArgs e)
        {

            //dgvKahvalti.DataSource = db.OgunBilgileri.Where(x => x.Tarih.ToShortDateString() == DateTime.Now.ToShortDateString()).Where(x => x.OgunAdi.Contains("Kahvalti")).Where(x => x.KullaniciID == db.KullanıcıBilgileri.Find(KullaniciGirisi.kullaniciID).ToList();//LINQ ile KullanıcıID nasıl bulunacak ve getirilecek.


            //dgvKahvalti.DataSource = db.OgunBilgileri.Where(x => x.Tarih.ToShortDateString() == DateTime.Now.ToShortDateString()).Where(x => x.OgunAdi.Contains("Ogle")).Where(x => x.KullaniciID == 1).ToList();


            //dgvKahvalti.DataSource = db.OgunBilgileri.Where(x => x.Tarih.ToShortDateString() == DateTime.Now.ToShortDateString()).Where(x => x.OgunAdi.Contains("Aksam")).Where(x => x.KullaniciID == 1).ToList();


            //dgvKahvalti.DataSource = db.OgunBilgileri.Where(x => x.Tarih.ToShortDateString() == DateTime.Now.ToShortDateString()).Where(x => x.OgunAdi.Contains("Apertif")).Where(x => x.KullaniciID == 1).ToList();


            //tarih = DateTime.Parse(lblTarih.Text);
        }

        
        private void btnKisiselBilgiler_Click(object sender, EventArgs e)
        {
            KisiselBilgiler kisiselBilgiler = new KisiselBilgiler();
            kisiselBilgiler.Show();

            this.Hide();
        }

        private void btnKahvaltiListeyiTemizle_Click(object sender, EventArgs e)
        {
            dgvKahvalti.DataSource = null;
        }

        private void btnOgleListeyiTemizle_Click(object sender, EventArgs e)
        {
            dgvOgle.DataSource = null;
        }

        private void btnAksamListeyiTemizle_Click(object sender, EventArgs e)
        {
            dgvAksam.DataSource = null;
        }

        private void btnAperatifListeyiTemizle_Click(object sender, EventArgs e)
        {
            dgvAperatif.DataSource = null;
        }

        private void btnKisiselKaloriAnalizi2_Click(object sender, EventArgs e)
        {
            KisiselKaloriAnalizi kisiselKaloriAnalizi = new KisiselKaloriAnalizi();
            kisiselKaloriAnalizi.Show();
            this.Hide();
        }

        private void btnGenelKaloriAnalizi2_Click(object sender, EventArgs e)
        {
            GenelKaloriAnalizi genelKaloriAnalizi = new GenelKaloriAnalizi();
            genelKaloriAnalizi.Show();
            this.Hide();
        }

        private void btnYemekCesidiRaporu_Click(object sender, EventArgs e)
        {
            YemekCesidiRaporu yemekCesidiRaporu = new YemekCesidiRaporu();
            yemekCesidiRaporu.Show();
            this.Hide();
        }

        private void btnOgunlerCikis_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void lblTarih_Click(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToShortDateString();

        }

        private void btnKahvaltiEkle_Click(object sender, EventArgs e)
        {
            Yemekler yemekler = new Yemekler();
            yemekler.Show();
            this.Hide();
        }

        private void btnÖgleYemegiEkle_Click(object sender, EventArgs e)
        {

            Yemekler yemekler = new Yemekler();
            yemekler.Show();
            this.Hide();
        }

        private void btnAksamYemegiEkle_Click(object sender, EventArgs e)
        {

            Yemekler yemekler = new Yemekler();
            yemekler.Show();
            this.Hide();
        }

        private void btnAperatifEkle_Click(object sender, EventArgs e)
        {

            Yemekler yemekler = new Yemekler();
            yemekler.Show();
            this.Hide();
        }

        private void btnKahvaltiSil_Click(object sender, EventArgs e)
        {
            if (dgvKahvalti.SelectedRows.Count > 0)
            {
                dgvKahvalti.Rows.RemoveAt(dgvKahvalti.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Lüffen Silinecek Satırı Seçin!");
            }
        }

        private void btnOgleYemegiSil_Click(object sender, EventArgs e)
        {
            if (dgvOgle.SelectedRows.Count > 0)
            {
                dgvOgle.Rows.RemoveAt(dgvOgle.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Lüffen Silinecek Satırı Seçin!");
            }
        }

        private void btnAksamYemegiSil_Click(object sender, EventArgs e)
        {
            if (dgvAksam.SelectedRows.Count > 0)
            {
                dgvAksam.Rows.RemoveAt(dgvAksam.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Lüffen Silinecek Satırı Seçin!");
            }
        }

        private void btnAperatifSil_Click(object sender, EventArgs e)
        {
            if (dgvAperatif.SelectedRows.Count > 0)
            {
                dgvAperatif.Rows.RemoveAt(dgvAperatif.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Lüffen Silinecek Satırı Seçin!");
            }
        }



        private int KahvaltiKaloriHesapla()
        {
            int toplamKalori = 0;
            for (int i = 0; i < dgvKahvalti.RowCount; i++)
            {
                int kahvaltiOgunu = (int)dgvKahvalti.Rows[i].Cells[3].Value;    //Kalori Miktarını TextBox'a aktarıcaz.
                toplamKalori += kahvaltiOgunu;

            }
            txtKahvaltiKalorisi.Text = toplamKalori.ToString();

            return toplamKalori;
        }
        private int OgleKaloriHesapla()
        {
            int toplamKalori = 0;
            for (int i = 0; i < dgvOgle.RowCount; i++)
            {
                int ogleOgunu = (int)dgvOgle.Rows[i].Cells[3].Value;    
                toplamKalori += ogleOgunu;

            }
            txtOgleYemegiKalorisi.Text = toplamKalori.ToString();

            return toplamKalori;
        }
        private int AksamKaloriHesapla()
        {
            int toplamKalori = 0;
            for (int i = 0; i < dgvAksam.RowCount; i++)
            {
                int aksamOgunu = (int)dgvAksam.Rows[i].Cells[3].Value;  
                toplamKalori += aksamOgunu;

            }
            txtAksamYemegiKalorisi.Text = toplamKalori.ToString();

            return toplamKalori;
        }
        private int AperatifKaloriHesapla()
        {
            int toplamKalori = 0;
            for (int i = 0; i < dgvAperatif.RowCount; i++)
            {
                int aperatifOgunu = (int)dgvAperatif.Rows[i].Cells[3].Value;    
                toplamKalori += aperatifOgunu;

            }
            txtAperatifKalorisi.Text = toplamKalori.ToString();

            return toplamKalori;
        }
        

        private void txtKahvaltiKalorisi_TextChanged(object sender, EventArgs e)
        {
            KahvaltiKaloriHesapla();
        }

        private void txtOgleYemegiKalorisi_TextChanged(object sender, EventArgs e)
        {
            OgleKaloriHesapla();
        }

        private void txtAksamYemegiKalorisi_TextChanged(object sender, EventArgs e)
        {
            AksamKaloriHesapla();
        }

        private void txtAperatifKalorisi_TextChanged(object sender, EventArgs e)
        {
            AperatifKaloriHesapla();
        }

        private void txtToplamKalori_TextChanged(object sender, EventArgs e)
        {
            txtToplamKalori.Text = (Convert.ToInt32(txtKahvaltiKalorisi.Text) + Convert.ToInt32(txtOgleYemegiKalorisi.Text) + Convert.ToInt32(txtAksamYemegiKalorisi.Text) + Convert.ToInt32(txtAperatifKalorisi.Text)).ToString();
        }

        public static implicit operator Ogunler(Ogun v)
        {
            throw new NotImplementedException();
        }
    }
}
