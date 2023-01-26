using IsbaSatisWeb.Core.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsbaSatisWeb.Core.Domain.Entities
{
    public class Tanim:BaseEntity
    {
        public string Turu { get; set; }
        public string Tanimi { get; set; }
    }
}
