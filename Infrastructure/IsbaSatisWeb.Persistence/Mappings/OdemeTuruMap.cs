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
    public class OdemeTuruMap : IEntityTypeConfiguration<OdemeTuru>
    {
        public void Configure(EntityTypeBuilder<OdemeTuru> builder)
        {
            builder.Property(p => p.OdemeTuruAdi).HasMaxLength(30);
            builder.Property(p => p.OdemeTuruKodu).HasMaxLength(12);

            builder.ToTable("OdemeTurleri");
            builder.Property(p => p.OdemeTuruAdi).HasColumnName("OdemeTuruAdi");
            builder.Property(p => p.OdemeTuruKodu).HasColumnName("OdemeTuruKodu");
        }
    }
}
