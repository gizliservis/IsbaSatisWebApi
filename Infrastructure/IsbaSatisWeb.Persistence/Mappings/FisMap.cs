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
    public class FisMap : IEntityTypeConfiguration<Fis>
    {
        public void Configure(EntityTypeBuilder<Fis> builder)
        {
            builder.Property(p => p.FisKodu).HasMaxLength(12);
            builder.Property(p => p.FisBaglantiKodu).HasMaxLength(14);
            builder.Property(p => p.FisTuru).HasMaxLength(30);
            builder.Property(p => p.DepoAdi).HasMaxLength(30);

            builder.Property(p => p.FaturaUnvani).HasMaxLength(50);
            builder.Property(p => p.CepTelefonu).HasMaxLength(20);
            builder.Property(p => p.Il).HasMaxLength(20);
            builder.Property(p => p.Ilce).HasMaxLength(20);
            builder.Property(p => p.Semt).HasMaxLength(20);
            builder.Property(p => p.Adres).HasMaxLength(100);
            builder.Property(p => p.VergiDairesi).HasMaxLength(30);
            builder.Property(p => p.VergiNo).HasMaxLength(15);
            builder.Property(p => p.BelgeNo).HasMaxLength(20);
            builder.Property(p => p.IskontoOrani).HasPrecision(5, 2);
            builder.Property(p => p.IskontoTutar).HasPrecision(12, 2);
            builder.Property(p => p.Alacak).HasPrecision(12, 2);
            builder.Property(p => p.Borc).HasPrecision(12, 2);
            builder.Property(p => p.ToplamTutar).HasPrecision(12, 2);

            builder.ToTable("Fisler");
            builder.Property(p => p.FisKodu).HasColumnName("FisKodu");
            builder.Property(p => p.FisBaglantiKodu).HasColumnName("FisBaglantiKodu");
            builder.Property(p => p.FisTuru).HasColumnName("FisTuru");
            builder.Property(p => p.CariId).HasColumnName("CariId");
            builder.Property(p => p.FaturaUnvani).HasColumnName("FaturaUnvani");
            builder.Property(p => p.CepTelefonu).HasColumnName("CepTelefonu");
            builder.Property(p => p.Il).HasColumnName("Il");
            builder.Property(p => p.Ilce).HasColumnName("Ilce");
            builder.Property(p => p.Semt).HasColumnName("Semt");
            builder.Property(p => p.Adres).HasColumnName("Adres");
            builder.Property(p => p.VergiDairesi).HasColumnName("VergiDairesi");
            builder.Property(p => p.VergiNo).HasColumnName("VergiNo");
            builder.Property(p => p.BelgeNo).HasColumnName("BelgeNo");
            builder.Property(p => p.Tarih).HasColumnName("Tarih");
            builder.Property(p => p.PlasiyerId).HasColumnName("PlasiyerId");
            builder.Property(p => p.IskontoOrani).HasColumnName("IskontoOrani");
            builder.Property(p => p.IskontoTutar).HasColumnName("IskontoTutar");
            builder.Property(p => p.DepoAdi).HasColumnName("DepoAdi");
            builder.Property(p => p.Alacak).HasColumnName("Alacak");
            builder.Property(p => p.Borc).HasColumnName("Borc");
            builder.Property(p => p.ToplamTutar).HasColumnName("ToplamTutar");
            builder.Property(p => p.BankaId).HasColumnName("BankaId");


            builder.HasOne(c => c.Cari).WithMany(c => c.Fisler).HasForeignKey(c => c.CariId);
            builder.HasOne(c => c.banka).WithMany(c => c.Fisler).HasForeignKey(c => c.BankaId);
            builder.HasOne(c => c.Personel).WithMany(c => c.Fisler).HasForeignKey(c => c.PlasiyerId);
        }
    }
}
