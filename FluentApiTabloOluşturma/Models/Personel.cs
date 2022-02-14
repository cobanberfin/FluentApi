using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentApiTabloOluşturma.Models
{
    public class Personel
    {
        public int Anahtar { get; set; }
        public string İsim { get; set; }
        public string Soyisim{ get; set; }
        public string EmailAdres{ get; set; }
        public string Telefon{ get; set; }
        public int firID { get; set; }
        public Firma  Firma { get; set; }
    }
}
