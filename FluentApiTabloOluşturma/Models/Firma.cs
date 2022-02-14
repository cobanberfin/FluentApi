using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentApiTabloOluşturma.Models
{
    public class Firma
    {
        public int Anahtar { get; set; }
        public string  Unvan { get; set; }
        public string  TelefonNumarası { get; set; }
        public string  Adres { get; set; }
        public string EmailAdres{ get; set; }
        public string FirmaLisansKey { get; set; } //kolonadı tabloda olusmasın
        public ICollection<Personel> personeller { get; set; }

    }
}
