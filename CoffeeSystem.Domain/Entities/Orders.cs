using CoffeeSystem.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeSystem.Domain.Entities
{
    public class Orders : BaseEntity
    {
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
        public decimal TotalAmount { get; set; }
        public int CustomersId { get; set; }
        public Customers Customers { get; set; }
        public List<OrderProducts> OrderProducts { get; set; }
    }
}
