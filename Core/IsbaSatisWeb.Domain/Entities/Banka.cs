using IsbaSatisWeb.Core.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsbaSatisWeb.Core.Domain.Entities
{
    public class Banka:BaseEntity
    {
        public string HesapKodu { get; set; }
        public string HesapIsmi { get; set; }
        public string Bankasi { get; set; }
        public string Sube { get; set; }
        public string IbanNo { get; set; }
        public string HesapNo { get; set; }
        public string YetkiliAdi { get; set; }
        public string YetkiliTelefonu { get; set; }
        public virtual ICollection<BankaHareket> BankaHareketler { get; set; }
        public virtual ICollection<Fis> Fisler { get; set; }
    }
}
