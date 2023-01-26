using IsbaSatisWeb.Core.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsbaSatisWeb.Core.Domain.Entities
{
    public class OdemeTuru:BaseEntity
    {
        public string OdemeTuruKodu { get; set; }
        public string OdemeTuruAdi { get; set; }
        public virtual ICollection<KasaHareket> KasaHareketler { get; set; }
    }
}
