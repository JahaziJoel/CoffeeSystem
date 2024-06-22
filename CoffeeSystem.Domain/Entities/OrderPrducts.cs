using CoffeeSystem.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSystem.Domain.Entities
{
    public class OrderPrducts: BaseEntity
    {
        public int OrderId { get; set; }
        public Orders Orders { get; set; }
        public int ProductId { get; set; }
        public Products Products { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
