
using MixApp.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixApp.Model
{
    public class MixDbContext : DbContext //Db Context sınıfından kalıtım alamalı kurucu metot oluşturulmalı
    {
        public MixDbContext() : base("Defcon")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MixDbContext, Configuration>("Defcon"));
            //database e update yaptığımızda veya sildiğimizde sadece o değikliği yapacak
        }
        // oluşturduğumuz bu clasları database in anlayacağı dile dönüştürüyorum.
        public DbSet<Cariler> Carilers { get; set; }
        public DbSet<UrunGrup> UrunGrups { get; set; }
        public DbSet<Renkler> Renklers { get; set; }
        public DbSet<Bedenler> Bedenlers { get; set; }
        public DbSet<Sezonlar> Sezonlars { get; set; }
        public DbSet<Markalar> Markalars { get; set; }
        public DbSet<Urunler> Urunlers { get; set; }
        public DbSet<UrunAl> UrunAls { get; set; }
        public DbSet<StokDurum> StokDurums { get; set; }
        public DbSet<UrunSat>  UrunSats { get; set; }
    }
}
