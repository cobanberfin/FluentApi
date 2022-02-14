using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluentApiTabloOluşturma.Models
{
    public class SuplierProduct
    {
        public int SuplierID { get; set; }
        public Suplier Suplier{ get; set; }
        public int ProductID { get; set; }
        public Product Product{ get; set; }
    }
}
