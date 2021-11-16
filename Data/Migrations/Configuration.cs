namespace Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Model;

    internal sealed class Configuration : DbMigrationsConfiguration<Data.FitBullDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        FitBullDbContext db = new FitBullDbContext();
        protected override void Seed(Data.FitBullDbContext context)
        {
            //Yemek YemekIsimleri = new Yemek()
            //{ YemekKategorisi = "Salatalar", YemekAdi = "Karışık Yeşillikli Sade Salata", Birim = "1Kase(55gr)", Kalori = 9, Admin = db.YoneticiBilgileri.Find(1) };
            //Yemek YemekIsimleri1 = new Yemek()
            //{ YemekKategorisi = "Salatalar", YemekAdi = "Mercimekli Lor Peynirli Salata", Birim = "1Kase(255gr)", Kalori = 180, Admin = db.YoneticiBilgileri.Find(2) };
            //Yemek YemekIsimleri2 = new Yemek()
            //{ YemekKategorisi = "Salatalar", YemekAdi = "Tavuklu Salata", Birim = "1Kase(255gr)", Kalori = 225, Admin = db.YoneticiBilgileri.Find(3) };





            //Yonetici yoneticiIsimleri = new Yonetici()
            //{ YoneticiAdi = "mesutylmaz492@gmail.com", Sifre = "kd5boostfitbull" };
            //Yonetici yoneticiIsimleri1 = new Yonetici()
            //{ YoneticiAdi = "zeynephande.altuner@gmail.com", Sifre = "kd6boostfitbull" };
            //Yonetici yoneticiIsimleri2 = new Yonetici()
            //{ YoneticiAdi = "enesmodali@gmail.com", Sifre = "kd7boostfitbull" };




            //Ogun Ogunİsimleri = new Ogun()
            //{ OgunAdi = "Kahvaltı", Tarih = DateTime.Parse("2021/12/11"), Kullanıcı = db.KullanıcıBilgileri.Find(1) }; //Kullanıcı Adını Bu şekilde getirebilecek miyiz? ÖğünKalorisi neden çıkmıyor, set özelliği olmadığından mı? tabloda nasıl göstericez?
            //Ogun Ogunİsimleri1 = new Ogun()
            //{ OgunAdi = "Öğle", Tarih = DateTime.Parse("2021/12/11"), Kullanıcı = db.KullanıcıBilgileri.Find(1) };
            //Ogun Ogunİsimleri2 = new Ogun()
            //{ OgunAdi = "Akşam", Tarih = DateTime.Parse("2021/12/11"), Kullanıcı = db.KullanıcıBilgileri.Find(1) };
            //Ogun Ogunİsimleri3 = new Ogun()
            //{ OgunAdi = "Aperatif", Tarih = DateTime.Parse("2021/12/11"), Kullanıcı = db.KullanıcıBilgileri.Find(1) };
            Ogun Ogunİsimleri4 = new Ogun()
            { OgunAdi = "Aperatif", Tarih = DateTime.Parse("2021/11/16"), Kullanıcı = db.KullanıcıBilgileri.Find(1) };
            Ogun Ogunİsimleri5 = new Ogun()
            { OgunAdi = "Aperatif", Tarih = DateTime.Parse("2021/11/16"), Kullanıcı = db.KullanıcıBilgileri.Find(1) };
            Ogun Ogunİsimleri6 = new Ogun()
            { OgunAdi = "Aperatif", Tarih = DateTime.Parse("2021/11/16"), Kullanıcı = db.KullanıcıBilgileri.Find(1) };
            Ogun Ogunİsimleri7 = new Ogun()
            { OgunAdi = "Aperatif", Tarih = DateTime.Parse("2021/11/16"), Kullanıcı = db.KullanıcıBilgileri.Find(1) };


            //Kullanici kullaniciBilgileri = new Kullanici()
            //{
            //    Adi = "Ali",
            //    Soyadi = "Veli",
            //    KullaniciAdi = "aliveli@gmail.com",
            //    Sifre = "123ali",
            //    SifreDogrulama = "123ali",
            //    Cinsiyet = CinsiyetTürü.erkek,
            //    DogumTarihi = DateTime.Parse("2021-11-01"),
            //    Boy = 185,
            //    Kilo = 75
            //};



            

            //db.YemekBilgileri.Add(YemekIsimleri);
            //db.YemekBilgileri.Add(YemekIsimleri1);
            //db.YemekBilgileri.Add(YemekIsimleri2);
            //db.YoneticiBilgileri.Add(yoneticiIsimleri);
            //db.YoneticiBilgileri.Add(yoneticiIsimleri1);
            //db.YoneticiBilgileri.Add(yoneticiIsimleri2);
            //db.KullanıcıBilgileri.Add(kullaniciBilgileri);
            //db.OgunBilgileri.Add(Ogunİsimleri);
            //db.OgunBilgileri.Add(Ogunİsimleri1);
            //db.OgunBilgileri.Add(Ogunİsimleri2);
            //db.OgunBilgileri.Add(Ogunİsimleri3);

            db.SaveChanges();

        }
    }
}
