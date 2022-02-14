using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentApiTabloOluşturma.Models
{
    public class Suplier
    {
        public int SuplierID { get; set; }
        public string İsim { get; set; }
        public string Şehir { get; set; }
        public ICollection<SuplierProduct> SuplierProducts{ get; set; }

    }
}
