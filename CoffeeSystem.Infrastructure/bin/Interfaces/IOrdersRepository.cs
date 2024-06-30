using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using CoffeeSystem.Domain.Entities;
namespace CoffeeSystem.Infrastructure.Interfaces
{
    public interface IOrdersRepository
    {
        Orders GetOrderById(int ordersId);
        List<Orders> GetAllOrders();
        void CreateOrder(Orders orders);
        void UpdateOrder(Orders orders);
        void DeleteOrder(int ordersId);
        object GetAll();
        void Update(Orders orders);
        object GetById(int id);
    }

}
