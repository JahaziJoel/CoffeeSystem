using CoffeeSystem.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeSystem.Infrastructure.Interfaces;
using CoffeeSystem.Domain;
using CoffeeSystem.Domain.Entities;

namespace CoffeeSystem.Infrastructure.Interfaces
{
    public interface IOrderProductsRepository
    {
        List<ProductsRepository> GetProductForOrder(OrdersRepository orders);
        void AddProductToOrder(ProductsRepository products, OrdersRepository orders);
        void RemoveProductFromOrder(ProductsRepository products, OrdersRepository orders);
    }


}
