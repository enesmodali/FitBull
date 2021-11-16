namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kullanıcılar",
                c => new
                    {
                        KullaniciID = c.Int(nullable: false, identity: true),
                        Adi = c.String(nullable: false, maxLength: 20),
                        Soyadi = c.String(nullable: false, maxLength: 30),
                        KullaniciAdi = c.String(nullable: false, maxLength: 50),
                        Sifre = c.String(nullable: false, maxLength: 15),
                        SifreDogrulama = c.String(nullable: false, maxLength: 15),
                        Cinsiyet = c.Int(nullable: false),
                        DogumTarihi = c.DateTime(nullable: false, storeType: "date"),
                        Boy = c.Double(nullable: false),
                        Kilo = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.KullaniciID);
            
            CreateTable(
                "dbo.Ogunler",
                c => new
                    {
                        OgunID = c.Int(nullable: false, identity: true),
                        Tarih = c.DateTime(nullable: false, storeType: "date"),
                        OgunAdi = c.String(nullable: false, maxLength: 50),
                        KullaniciID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OgunID)
                .ForeignKey("dbo.Kullanıcılar", t => t.KullaniciID)
                .Index(t => t.KullaniciID);
            
            CreateTable(
                "dbo.Yemekler",
                c => new
                    {
                        YemekID = c.Int(nullable: false, identity: true),
                        YemekKategorisi = c.String(nullable: false, maxLength: 50),
                        YemekAdi = c.String(nullable: false, maxLength: 50),
                        Birim = c.String(nullable: false, maxLength: 15),
                        Kalori = c.Int(nullable: false),
                        AdminID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.YemekID)
                .ForeignKey("dbo.Yoneticiler", t => t.AdminID)
                .Index(t => t.AdminID);
            
            CreateTable(
                "dbo.Yoneticiler",
                c => new
                    {
                        YoneticiID = c.Int(nullable: false, identity: true),
                        YoneticiAdi = c.String(nullable: false, maxLength: 50),
                        Sifre = c.String(nullable: false, maxLength: 15),
                    })
                .PrimaryKey(t => t.YoneticiID);
            
            CreateTable(
                "dbo.OgunYemekleri",
                c => new
                    {
                        YemekID = c.Int(nullable: false),
                        OgunID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.YemekID, t.OgunID })
                .ForeignKey("dbo.Ogunler", t => t.YemekID, cascadeDelete: true)
                .ForeignKey("dbo.Yemekler", t => t.OgunID, cascadeDelete: true)
                .Index(t => t.YemekID)
                .Index(t => t.OgunID);
            
            CreateTable(
                "dbo.KulaniciYemekleri",
                c => new
                    {
                        YemekID = c.Int(nullable: false),
                        KullaniciID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.YemekID, t.KullaniciID })
                .ForeignKey("dbo.Kullanıcılar", t => t.YemekID, cascadeDelete: true)
                .ForeignKey("dbo.Yemekler", t => t.KullaniciID, cascadeDelete: true)
                .Index(t => t.YemekID)
                .Index(t => t.KullaniciID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.KulaniciYemekleri", "KullaniciID", "dbo.Yemekler");
            DropForeignKey("dbo.KulaniciYemekleri", "YemekID", "dbo.Kullanıcılar");
            DropForeignKey("dbo.Ogunler", "KullaniciID", "dbo.Kullanıcılar");
            DropForeignKey("dbo.OgunYemekleri", "OgunID", "dbo.Yemekler");
            DropForeignKey("dbo.OgunYemekleri", "YemekID", "dbo.Ogunler");
            DropForeignKey("dbo.Yemekler", "AdminID", "dbo.Yoneticiler");
            DropIndex("dbo.KulaniciYemekleri", new[] { "KullaniciID" });
            DropIndex("dbo.KulaniciYemekleri", new[] { "YemekID" });
            DropIndex("dbo.OgunYemekleri", new[] { "OgunID" });
            DropIndex("dbo.OgunYemekleri", new[] { "YemekID" });
            DropIndex("dbo.Yemekler", new[] { "AdminID" });
            DropIndex("dbo.Ogunler", new[] { "KullaniciID" });
            DropTable("dbo.KulaniciYemekleri");
            DropTable("dbo.OgunYemekleri");
            DropTable("dbo.Yoneticiler");
            DropTable("dbo.Yemekler");
            DropTable("dbo.Ogunler");
            DropTable("dbo.Kullanıcılar");
        }
    }
}
