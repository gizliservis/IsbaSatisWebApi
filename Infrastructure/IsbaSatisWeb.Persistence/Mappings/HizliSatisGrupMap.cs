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
    public class HizliSatisGrupMap : IEntityTypeConfiguration<HizliSatisGrup>
    {
        public void Configure(EntityTypeBuilder<HizliSatisGrup> builder)
        {
            builder.Property(p => p.GrupAdi).HasMaxLength(30);

            builder.ToTable("HizliSatislarGruplari");
            builder.Property(p => p.GrupAdi).HasColumnName("GrupAdi");
        }
    }
}
