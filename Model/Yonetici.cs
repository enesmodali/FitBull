using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Yonetici
    {
        public int YoneticiID { get; set; } 
        public string YoneticiAdi { get; set; }
        public string Sifre { get; set; } //Şifre kolay girilemez. Harf ve rakam yer almalı

        public ICollection<Yemek> Yemekler { get; set; } //1'e Çok.
        public Yonetici()
        {
            Yemekler = new List<Yemek>();
        }

        public static explicit operator Yonetici(string v)      //Veri Ekleme safyamda Admini kullanabilmek için bunu oluşturduk.
        {
            throw new NotImplementedException();
        }

        
    }
}
