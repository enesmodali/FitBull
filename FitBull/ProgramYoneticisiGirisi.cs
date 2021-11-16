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
    public partial class ProgramYoneticisiGirisi : Form
    {
        public ProgramYoneticisiGirisi()
        {
            InitializeComponent();
        }

        public static string x;

        

        public void btnPYGGiris_Click(object sender, EventArgs e)
        {
            if (txtPYGKullaniciAdi.Text == "enesmodali@gmail.com" && txtPYGSifre.Text== "kd7boostfitbull")
            {
                ProgramYoneticisiIslemleri islemler = new ProgramYoneticisiIslemleri();
                islemler.Show();

                this.Hide();
            }
            else if (txtPYGKullaniciAdi.Text == "mesutylmaz492@gmail.com" && txtPYGSifre.Text == "kd5boostfitbull")
            {
                ProgramYoneticisiIslemleri islemler = new ProgramYoneticisiIslemleri();
                islemler.Show();

                this.Hide();
            }
            else if (txtPYGKullaniciAdi.Text == "zeynephande.altuner@gmail.com" && txtPYGSifre.Text == "kd6boostfitbull")
            {
                ProgramYoneticisiIslemleri islemler = new ProgramYoneticisiIslemleri();
                islemler.Show();

                this.Hide();
            }
            else
            {
                DialogResult Çıkış = new DialogResult();
                Çıkış = MessageBox.Show("Devam etmek ister misiniz? ", "Uyarı",MessageBoxButtons.YesNo);
                if (Çıkış==DialogResult.Yes)
                {
                    MessageBox.Show("Girdiğiniz kullanıcı adı veya şifre hatalıdır.Lütfen tekrar giriniz.");
                    txtPYGKullaniciAdi.Clear();
                    txtPYGSifre.Clear();
                    
                }
            }

            x = txtPYGKullaniciAdi.Text;
        }
    }
}
