using IsbaSatisWeb.Core.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsbaSatisWeb.Core.Domain.Entities
{
    public class PersonelHareket:BaseEntity
    {
        public string FisKodu { get; set; }
        public string Unvani { get; set; }
        public string PersonelKodu { get; set; }
        public string PersonelAdi { get; set; }
        public string TcKimlikNo { get; set; }
        public DateTime Donemi { get; set; }
        public decimal PrimOrani { get; set; }
        public decimal ToplamSatis { get; set; }
        public decimal AylikMaasi { get; set; }
    }
}
