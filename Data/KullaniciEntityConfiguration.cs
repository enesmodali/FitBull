using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class KullaniciEntityConfiguration : EntityTypeConfiguration<Kullanici>
    {
        public KullaniciEntityConfiguration()
        {
            this.ToTable("Kullanicilar").HasKey<int>(kullanici => kullanici.KullaniciID);
            this.Property(x => x.KullaniciID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(kullanici => kullanici.Adi).IsRequired().HasColumnType("nvarchar").HasMaxLength(20).IsUnicode(true);
            this.Property(x => x.Soyadi).IsRequired().HasColumnType("nvarchar").HasMaxLength(30).IsUnicode(true);
            this.Ignore(x => x.AdSoyad);
            this.Property(x => x.KullaniciAdi).IsRequired().HasColumnType("nvarchar").HasMaxLength(50).IsUnicode(false);
            this.Property(x => x.Sifre).IsRequired().HasColumnType("nvarchar").HasMaxLength(15).IsUnicode(true);
            this.Property(x => x.SifreDogrulama).IsRequired().HasColumnType("nvarchar").HasMaxLength(15).IsUnicode(true);
            this.Property(x => x.Cinsiyet).HasColumnType("int").IsRequired();    
            this.Property(x => x.DogumTarihi).IsRequired().HasColumnType("date");
            this.Property(x => x.Boy).IsRequired(); 
            this.Property(x => x.Kilo).IsRequired();


            this.HasMany<Ogun>(kullanici => kullanici.Ogunler).WithRequired(ogun => ogun.Kullanıcı);


            this.HasMany<Yemek>(kullanici => kullanici.Yemekler).WithMany(yemek => yemek.Kullanicilar).Map(KullaniciYemek =>
            {
                KullaniciYemek.ToTable("KulaniciYemekleri");
                KullaniciYemek.MapLeftKey("YemekID");
                KullaniciYemek.MapRightKey("KullaniciID");
            });
        }
    }
}
