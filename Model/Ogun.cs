using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Ogun
    {
        //public enum OgunAdi { Kahvalti, OgleYemegi, AksamYemegi, Aperatif }
        public int OgunID { get; set; }
        public DateTime Tarih { get; set; }
        public string OgunAdi { get; set; }
        public Kullanici Kullanıcı { get; set; }    //1'e Çok
        public int KullaniciID { get; set; }  //KullanıcıAdı için ForeignKey
        public ICollection<Yemek> Yemekler { get; set; }    //Çoka Çok
        
        public int OgunKalorisi 
        {
            get 
            {
                int toplamKalori = 0;
                foreach (Yemek item in this.Yemekler)
                {
                    toplamKalori += item.Kalori;
                }
                return toplamKalori;
            }
        }
        
        public Ogun()
        {
            Yemekler = new List<Yemek>();
        }
    }
}
