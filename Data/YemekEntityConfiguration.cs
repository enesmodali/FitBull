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
    public class YemekEntityConfiguration : EntityTypeConfiguration<Yemek>
    {
        public YemekEntityConfiguration()
        {
            this.ToTable("Yemekler").HasKey<int>(yemek => yemek.YemekID);

        
                this.Property(x => x.YemekID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
                this.Property(x => x.YemekKategorisi).IsRequired().HasColumnType("nvarchar").HasMaxLength(50).IsUnicode(true);
                this.Property(x => x.YemekAdi).IsRequired().HasColumnType("nvarchar").HasMaxLength(50).IsUnicode(true);
                this.Property(x => x.Birim).IsRequired().HasColumnType("nvarchar").HasMaxLength(15).IsUnicode(true);
                this.Property(x => x.Kalori).IsRequired();

                this.HasRequired<Yonetici>(yemek => yemek.Admin).WithMany(yonetici => yonetici.Yemekler).HasForeignKey<int>(yonetici => yonetici.AdminID).WillCascadeOnDelete(false);
                
                
                this.HasMany<Kullanici>(yemek => yemek.Kullanicilar).WithMany(kullanici => kullanici.Yemekler).Map(KullaniciYemek =>
                {
                    KullaniciYemek.ToTable("KulaniciYemekleri");
                    KullaniciYemek.MapLeftKey("KullaniciID");
                    KullaniciYemek.MapRightKey("YemekID");
                });

                this.HasMany<Ogun>(yemek => yemek.Ogunler).WithMany(ogun => ogun.Yemekler).Map(OgunYemek =>
                {
                    OgunYemek.ToTable("OgunYemekleri");
                    OgunYemek.MapLeftKey("OgunID");
                    OgunYemek.MapRightKey("YemekID");
                });

        }
    }
}
