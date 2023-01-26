using IsbaSatisWeb.Core.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsbaSatisWeb.Core.Domain.Entities
{
    public class Kod:BaseEntity
    {
        public string Tablo { get; set; }
        public string OnEki { get; set; }
        public int SonDeger { get; set; }
    }
}
