using DAL.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
   public class CRMContext :DbContext
    {
        public CRMContext() : base ("CRMContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<CRMContext, Configuration>("CRMContext"));
            this.Configuration.LazyLoadingEnabled = false;
        }
        public virtual DbSet<Kategori> Kategoris { get; set; }
        public virtual DbSet<Musteri> Musteris { get; set; }
        public virtual DbSet<Personel> Personels { get; set; }
        public virtual DbSet<Promosyon> Promosyons { get; set; }
        public virtual DbSet<Satis> satis { get; set; }
        public virtual DbSet<SatisDetay> SatisDetays { get; set; }
        public virtual DbSet<Urun> Uruns { get; set; }
        public virtual DbSet<UrunStokHareket> UrunStokHarekets { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UrunIade> UrunIades { get; set; }
        public virtual DbSet<Gorev> Gorevs { get; set; }
        public virtual DbSet<GorevDetay> GorevDetays { get; set; }
        public virtual DbSet<GorevKayit> GorevKayits{ get; set; }


    }
}
