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
    public class KasaHareketMap : IEntityTypeConfiguration<KasaHareket>
    {
        public void Configure(EntityTypeBuilder<KasaHareket> builder)
        {

            builder.Property(p => p.FisKodu).HasMaxLength(12);
            builder.Property(p => p.Hareket).HasMaxLength(10);
            builder.Property(p => p.Tutar).HasPrecision(12, 2);


            builder.ToTable("KasaHareketleri");
            builder.Property(p => p.FisKodu).HasColumnName("FisKodu");
            builder.Property(p => p.Hareket).HasColumnName("Hareket");
            builder.Property(p => p.KasaId).HasColumnName("KasaId");
            builder.Property(p => p.OdemeTuruId).HasColumnName("OdemeTuruId");
            builder.Property(p => p.CariId).HasColumnName("CariId");
            builder.Property(p => p.Tarih).HasColumnName("Tarih");
            builder.Property(p => p.Tutar).HasColumnName("Tutar");

            builder.HasOne(c => c.Kasa).WithMany(c => c.KasaHareketler).HasForeignKey(c => c.KasaId);
            builder.HasOne(c => c.OdemeTuru).WithMany(c => c.KasaHareketler).HasForeignKey(c => c.OdemeTuruId);
            builder.HasOne(c => c.Cari).WithMany(c => c.KasaHareketler).HasForeignKey(c => c.CariId);
        }
    }
}
