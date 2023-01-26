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
    public class TanimMap : IEntityTypeConfiguration<Tanim>
    {
        public void Configure(EntityTypeBuilder<Tanim> builder)
        {
            builder.Property(p => p.Turu).HasMaxLength(15);
            builder.Property(p => p.Tanimi).HasMaxLength(30);

            builder.ToTable("Tanimlar");
            builder.Property(p => p.Turu).HasColumnName("Turu");
            builder.Property(p => p.Tanimi).HasColumnName("Tanimi");

        }
    }
}
