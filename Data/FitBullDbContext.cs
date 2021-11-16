using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Data
{
    public class FitBullDbContext: DbContext
    {
        public FitBullDbContext() : base("ConFitBullDb")
        {
            Database.SetInitializer<FitBullDbContext>(new DropCreateDatabaseAlways<FitBullDbContext>());
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new YoneticiEntityConfiguration()).Add(new YemekEntityConfiguration()).Add(new KullaniciEntityConfiguration()).Add(new OgunEntityConfiguration());

            base.OnModelCreating(modelBuilder);

        }
        public DbSet<Yonetici> YoneticiBilgileri { get; set; }
        public DbSet<Yemek> YemekBilgileri { get; set; }
        public DbSet<Ogun> OgunBilgileri { get; set; }
        public DbSet<Kullanici> KullanıcıBilgileri { get; set; }
    }
}
