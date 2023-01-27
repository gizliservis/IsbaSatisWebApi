using IsbaSatisWeb.Core.Domain.Entities;
using IsbaSatisWeb.Core.Domain.Entities.Common;
using IsbaSatisWeb.Infrastructure.Persistence.Mappings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsbaSatisWeb.Infrastructure.Persistence.Contexts
{
    public class IsbaSatisWebDbContext : DbContext
    {
        public IsbaSatisWebDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Stok> Stoklar { get; set; }
        public DbSet<Cari> Cariler { get; set; }
        public DbSet<Fis> fisler { get; set; }
        public DbSet<StokHareket> StokHareketleri { get; set; }
        public DbSet<KasaHareket> KasaHareketleri { get; set; }
        public DbSet<Depo> Depolar { get; set; }
        public DbSet<Kasa> Kasalar { get; set; }
        public DbSet<OdemeTuru> OdemeTurleri { get; set; }
        public DbSet<Tanim> Tanimlar { get; set; }
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<PersonelHareket> PersonelHareketleri { get; set; }
        public DbSet<Indirim> Indirimler { get; set; }
        public DbSet<HizliSatis> HizliSatislar { get; set; }
        public DbSet<HizliSatisGrup> hizliSatisGruplari { get; set; }
        public DbSet<Kod> Kodlar { get; set; }
        public DbSet<Banka> Bankalar { get; set; }
        public DbSet<BankaHareket> BankaHareketleri { get; set; }
        public DbSet<SirketBilgi> SirketBilgileri { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
          var datas=  ChangeTracker.Entries<BaseEntity>();
            foreach (var data in datas)
            {
            _=   data.State switch
                {
                    EntityState.Added => data.Entity.EklenmeTarihi = DateTime.Now,
                    EntityState.Modified=>data.Entity.DuzenlenmeTarihi=DateTime.Now,
                };
            }
            return await base.SaveChangesAsync(cancellationToken);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
            modelBuilder.Entity<BaseEntity>().UseTpcMappingStrategy();


            modelBuilder.ApplyConfiguration(new BaseEntityMap());
            modelBuilder.ApplyConfiguration(new StokMap());
            modelBuilder.ApplyConfiguration(new CariMap());
            modelBuilder.ApplyConfiguration(new FisMap());
            modelBuilder.ApplyConfiguration(new StokHareketMap());
            modelBuilder.ApplyConfiguration(new KasaHareketMap());
            modelBuilder.ApplyConfiguration(new DepoMap());
            modelBuilder.ApplyConfiguration(new KasaMap());
            modelBuilder.ApplyConfiguration(new OdemeTuruMap());
            modelBuilder.ApplyConfiguration(new TanimMap());
            modelBuilder.ApplyConfiguration(new PersonelMap());
            modelBuilder.ApplyConfiguration(new PersonelHareketMap());
            modelBuilder.ApplyConfiguration(new IndirimMap());
            modelBuilder.ApplyConfiguration(new HizliSatisMap());
            modelBuilder.ApplyConfiguration(new HizliSatisGrupMap());
            modelBuilder.ApplyConfiguration(new KodMap());
            modelBuilder.ApplyConfiguration(new BankaMap());
            modelBuilder.ApplyConfiguration(new BankaHareketMap());
            modelBuilder.ApplyConfiguration(new SirketBilgiMap());


        }
    }
}
