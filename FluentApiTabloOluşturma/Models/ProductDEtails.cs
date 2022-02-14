using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentApiTabloOluşturma.Models
{
    public class ProductDEtails
    {
        public int ID { get; set; }
        public string Renk { get; set; }
        public Product Product { get; set; }
        public int prtID{ get; set; }
    }
}
