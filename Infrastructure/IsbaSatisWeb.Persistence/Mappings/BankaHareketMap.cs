using IsbaSatisWeb.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsbaSatisWeb.Infrastructure.Persistence.Mappings
{
    public class BankaHareketMap : IEntityTypeConfiguration<BankaHareket>
    {
        public void Configure(EntityTypeBuilder<BankaHareket> builder)
        {
            builder.Property(p => p.FisKodu).HasMaxLength(12);
            builder.Property(p => p.Hareket).HasMaxLength(30);
            builder.Property(p => p.Tutar).HasPrecision(12, 2);

            builder.ToTable("BankaHareketleri");
            builder.Property(p => p.FisKodu).HasColumnName("FisKodu");
            builder.Property(p => p.Hareket).HasColumnName("Hareket");
            builder.Property(p => p.BankaId).HasColumnName("BankaId");
            builder.Property(p => p.CariId).HasColumnName("CariId");
            builder.Property(p => p.Tarih).HasColumnName("Tarih");
            builder.Property(p => p.Tutar).HasColumnName("Tutar");

            builder.HasOne(c => c.Banka).WithMany(c => c.BankaHareketler).HasForeignKey(c => c.BankaId);
            builder.HasOne(c => c.Cari).WithMany(c => c.BankaHareketler).HasForeignKey(c => c.CariId);
        }
    }
}
