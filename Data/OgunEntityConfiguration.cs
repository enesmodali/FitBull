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
    public class OgunEntityConfiguration : EntityTypeConfiguration<Ogun>
    {
        public OgunEntityConfiguration()
        {
            this.ToTable("Ogunler").HasKey<int>(ogun => ogun.OgunID);
            
            this.Property(x => x.OgunID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);     //IDENTITY
            this.Property(x => x.OgunAdi).IsRequired().HasColumnType("nvarchar").HasMaxLength(50).IsUnicode(true);
            this.Property(x => x.Tarih).IsRequired().HasColumnType("date");
            this.Ignore(x => x.OgunKalorisi);                   // Bu Property Ignore Olucak mı?

            this.HasMany<Yemek>(ogun => ogun.Yemekler).WithMany(yemek => yemek.Ogunler); 

            this.HasRequired<Kullanici>(ogun => ogun.Kullanıcı).WithMany(kullanici => kullanici.Ogunler).HasForeignKey<int>(ogun => ogun.KullaniciID).WillCascadeOnDelete(false);

            this.HasMany<Yemek>(ogun => ogun.Yemekler).WithMany(yemek => yemek.Ogunler).Map(OgunYemek =>
            {
                OgunYemek.ToTable("OgunYemekleri");
                OgunYemek.MapLeftKey("YemekID"); 
                OgunYemek.MapRightKey("OgunID");
            });
        }
    }
}
