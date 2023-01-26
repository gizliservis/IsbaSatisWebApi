using IsbaSatisWeb.Core.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsbaSatisWeb.Core.Domain.Entities
{
    public class KasaHareket:BaseEntity
    {
        public string FisKodu { get; set; }
        public string Hareket { get; set; }
        public Guid KasaId { get; set; }
        public Guid OdemeTuruId { get; set; }
        public Nullable<Guid> CariId { get; set; }
        public Nullable<DateTime> Tarih { get; set; }
        public Nullable<decimal> Tutar { get; set; }
        public virtual Kasa Kasa { get; set; }
        public virtual OdemeTuru OdemeTuru { get; set; }
        public virtual Cari Cari { get; set; }
    }
}
