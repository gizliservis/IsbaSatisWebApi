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
    public class DepoMap : IEntityTypeConfiguration<Depo>
    {
        public void Configure(EntityTypeBuilder<Depo> builder)
        {
            builder.Property(p => p.DepoKodu).HasMaxLength(12);
            builder.Property(p => p.DepoAdi).HasMaxLength(30);
            builder.Property(p => p.YetkiliKodu).HasMaxLength(12);
            builder.Property(p => p.YetkiliAdi).HasMaxLength(50);
            builder.Property(p => p.Il).HasMaxLength(20);
            builder.Property(p => p.Ilce).HasMaxLength(20);
            builder.Property(p => p.Semt).HasMaxLength(20);
            builder.Property(p => p.Adres).HasMaxLength(100);
            builder.Property(p => p.Telefon).HasMaxLength(20);

            builder.ToTable("Depolar");
            builder.Property(p => p.DepoKodu).HasColumnName("DepoKodu");
            builder.Property(p => p.DepoAdi).HasColumnName("DepoAdi");
            builder.Property(p => p.YetkiliKodu).HasColumnName("YetkiliKodu");
            builder.Property(p => p.YetkiliAdi).HasColumnName("YetkiliAdi");
            builder.Property(p => p.Il).HasColumnName("Il");
            builder.Property(p => p.Ilce).HasColumnName("Ilce");
            builder.Property(p => p.Semt).HasColumnName("Semt");
            builder.Property(p => p.Adres).HasColumnName("Adres"); ;
            builder.Property(p => p.Telefon).HasColumnName("Telefon");
        }
    }
}
