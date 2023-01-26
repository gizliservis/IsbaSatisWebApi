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
    public class KasaMap : IEntityTypeConfiguration<Kasa>
    {
        public void Configure(EntityTypeBuilder<Kasa> builder)
        {
            builder.Property(p => p.KasaKodu).HasMaxLength(12);
            builder.Property(p => p.KasaAdi).HasMaxLength(30);
            builder.Property(p => p.YetkiliKodu).HasMaxLength(12);
            builder.Property(p => p.YetkiliAdi).HasMaxLength(50);

            builder.ToTable("Kasalar");
            builder.Property(p => p.KasaKodu).HasColumnName("KasaKodu");
            builder.Property(p => p.KasaAdi).HasColumnName("KasaAdi");
            builder.Property(p => p.YetkiliKodu).HasColumnName("YetkiliKodu");
            builder.Property(p => p.YetkiliAdi).HasColumnName("YetkiliAdi");
        }
    }
}
