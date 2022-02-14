using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentApiTabloOluşturma.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Ürünİsmi { get; set; }
        public decimal Price { get; set; }
        public ICollection<SuplierProduct> SuplierProducts { get; set; }
        public ProductDEtails ProductDEtails  { get; set; }

    }
}
