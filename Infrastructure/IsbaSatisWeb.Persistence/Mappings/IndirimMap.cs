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
    public class IndirimMap : IEntityTypeConfiguration<Indirim>
    {
        public void Configure(EntityTypeBuilder<Indirim> builder)
        {
            builder.Property(p => p.StokKodu).HasMaxLength(12);
            builder.Property(p => p.StokAdi).HasMaxLength(50);
            builder.Property(p => p.Barkod).HasMaxLength(20);
            builder.Property(p => p.IndirimTuru).HasMaxLength(15);
            builder.Property(p => p.IndirimOrani).HasPrecision(5, 2);

            builder.ToTable("Indirimler");
            builder.Property(p => p.Durumu).HasColumnName("Durumu");
            builder.Property(p => p.StokKodu).HasColumnName("StokKodu");
            builder.Property(p => p.StokAdi).HasColumnName("StokAdi");
            builder.Property(p => p.Barkod).HasColumnName("Barkod");
            builder.Property(p => p.IndirimTuru).HasColumnName("IndirimTuru");
            builder.Property(p => p.BaslangicTarihi).HasColumnName("BaslangicTarihi");
            builder.Property(p => p.BitisTarihi).HasColumnName("BitisTarihi");
            builder.Property(p => p.IndirimOrani).HasColumnName("IndirimOrani");
        }
    }
}
