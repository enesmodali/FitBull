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
    public class YoneticiEntityConfiguration : EntityTypeConfiguration<Yonetici>
    {
        public YoneticiEntityConfiguration()
        {

            this.ToTable("Yoneticiler").HasKey<int>(yonetici => yonetici.YoneticiID);
            this.Property(x => x.YoneticiID).IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(x => x.YoneticiAdi).IsRequired().HasColumnType("nvarchar").HasMaxLength(50).IsUnicode(false);
            this.Property(x => x.Sifre).IsRequired().HasColumnType("nvarchar").HasMaxLength(15);

            this.HasMany<Yemek>(yonetici => yonetici.Yemekler).WithRequired(yemek => yemek.Admin).HasForeignKey<int>(yonetici=> yonetici.AdminID).WillCascadeOnDelete(false); 
      
        }
        

    }
}
