using IsbaSatisWeb.Core.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsbaSatisWeb.Core.Domain.Entities
{
    public class HizliSatis:BaseEntity
    {
        public string Barkod { get; set; }
        public string UrunAdi { get; set; }
        public Guid GrupId { get; set; }
    }
}
