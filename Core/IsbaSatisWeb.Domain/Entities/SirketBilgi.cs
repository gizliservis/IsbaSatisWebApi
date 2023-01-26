using IsbaSatisWeb.Core.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsbaSatisWeb.Core.Domain.Entities
{
    public class SirketBilgi:BaseEntity
    {
        public string SirketKodu { get; set; }
        public string SirketKisaAdi { get; set; }
        public string SirketUnvani { get; set; }
        public string Ulkesi { get; set; }
        public string Ili { get; set; }
        public string Ilcesi { get; set; }
        public string Semt { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiNo { get; set; }
        public string Adres { get; set; }
        public string SirketTelNo { get; set; }
        public string Fax { get; set; }
        public string EMail { get; set; }
        public string Web { get; set; }
        public string YetkiliKisi { get; set; }
    }
}
