using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public enum CinsiyetTürü {erkek=1,kadın=0 }
    public class Kullanici
    {
        public int KullaniciID { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string SifreDogrulama { get; set; }
        public CinsiyetTürü Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }
        public double Boy { get; set; }
        public double Kilo { get; set; }
        public string AdSoyad
        {
            get
            {
                return Adi + " " + Soyadi;
            }
        }
        public ICollection<Yemek> Yemekler { get; set; }    //Çoka Çok
        public ICollection<Ogun> Ogunler { get; set; }  //1'e Çok

        public Kullanici()
        {
            Yemekler = new List<Yemek>();
            Ogunler = new List<Ogun>();
        }
    }
}
