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
    public class HizliSatisMap : IEntityTypeConfiguration<HizliSatis>
    {
        public void Configure(EntityTypeBuilder<HizliSatis> builder)
        {
            builder.Property(p => p.Barkod).HasMaxLength(150);
            builder.Property(p => p.UrunAdi).HasMaxLength(150);


            builder.ToTable("HizliSatislar");
            builder.Property(p => p.Barkod).HasColumnName("Barkod");
            builder.Property(p => p.UrunAdi).HasColumnName("UrunAdi");
        }
    }
}
