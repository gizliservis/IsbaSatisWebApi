using IsbaSatisWeb.Core.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsbaSatisWeb.Infrastructure.Persistence.Mappings
{
    public class BaseEntityMap : IEntityTypeConfiguration<BaseEntity>
    {
        public void Configure(EntityTypeBuilder<BaseEntity> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Ekleyen).HasMaxLength(70);
            builder.Property(e => e.Duzenleyen).HasMaxLength(70);
            builder.Property(e => e.Aciklama).HasMaxLength(250);

            builder.Property(e => e.Id).HasColumnName("Id");
            builder.Property(e => e.Duzenleyen).HasColumnName("Duzenleyen");
            builder.Property(e => e.Ekleyen).HasColumnName("Ekleyen");
            builder.Property(e => e.Aciklama).HasColumnName("Aciklama");
            builder.Property(e => e.DuzenlenmeTarihi).HasColumnName("DuzenlenmeTarihi");
            builder.Property(e => e.EklenmeTarihi).HasColumnName("EklenmeTarihi");
        }
    }
}
