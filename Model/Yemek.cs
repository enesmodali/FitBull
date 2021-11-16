using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Yemek
    {
        public int YemekID { get; set; }
        public string YemekKategorisi { get; set; }
        public string YemekAdi { get; set; }
        public string Birim { get; set; }
        public int Kalori { get; set; }
        public Yonetici Admin { get; set; }  //1'e ÇOK
        public int AdminID { get; set; }  //ForeignKey  
        
        public ICollection<Kullanici> Kullanicilar { get; set; }    //Çoka Çok
        
        public ICollection<Ogun> Ogunler { get; set; }  //Çoka Çok

        public Yemek()
        {
            Kullanicilar = new List<Kullanici>();
            Ogunler = new List<Ogun>();
        }
    }
}
