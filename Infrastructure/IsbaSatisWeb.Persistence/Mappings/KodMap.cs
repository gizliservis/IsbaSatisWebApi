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
    public class KodMap : IEntityTypeConfiguration<Kod>
    {
        public void Configure(EntityTypeBuilder<Kod> builder)
        {
            builder.Property(p => p.OnEki).HasMaxLength(6);
            builder.Property(p => p.Tablo).HasMaxLength(15);


            builder.ToTable("Kodlar");
            builder.Property(p => p.OnEki).HasColumnName("OnEki");
            builder.Property(p => p.Tablo).HasColumnName("Tablo");
            builder.Property(p => p.SonDeger).HasColumnName("SonDeger");
        }
    }
}
