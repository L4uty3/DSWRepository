using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spoilerejer14.Domain
{
    internal class Product
    {
        public string? Sku { get; set; }
        public string? Name { get; set; }
        public decimal CurrentUnitPrice { get; set; }
        public bool IsActive { get; set; }
    }
}
