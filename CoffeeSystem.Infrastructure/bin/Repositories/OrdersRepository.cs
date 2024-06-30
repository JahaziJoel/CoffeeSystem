using System;
using System.Collections.Generic;
using System.Linq;
using CoffeeSystem.Infrastructure.Interfaces;
using CoffeeSystem.Domain;
using CoffeeSystem.Domain.Entities;

namespace CoffeeSystem.Infrastructure.Repositories
{
    public class OrdersRepository : IOrdersRepository
    {
        private readonly List<Orders> _orders;

        public OrdersRepository()
        {
            _orders = new List<Orders>();
        }

        public Orders GetOrderById(int ordersId)
        {
            return _orders.FirstOrDefault(o => o.CustomersId == ordersId);
        }

        public List<Orders> GetAllOrders()
        {
            return _orders.ToList();
        }

        public void CreateOrder(Orders orders)
        {
            if (orders == null)
                throw new ArgumentNullException(nameof(orders));

            orders.CustomersId = GenerateOrderId();
            _orders.Add(orders);
        }

        public void UpdateOrder(Orders orders)
        {
            if (orders == null)
                throw new ArgumentNullException(nameof(orders));

            var existingOrder = _orders.FirstOrDefault(o => o.CustomersId == orders.CustomersId);
            if (existingOrder != null)
            {
                existingOrder.CustomersId = orders.CustomersId;
                existingOrder.OrderDate = orders.OrderDate;
                existingOrder.Status = orders.Status;
                // Actualizar otros campos según sea necesario
            }
            else
            {
                throw new InvalidOperationException($"Order with ID {orders.CustomersId} not found.");
            }
        }

        public void DeleteOrder(int ordersId)
        {
            var orderToRemove = _orders.FirstOrDefault(o => o.CustomersId == ordersId);
            if (orderToRemove != null)
            {
                _orders.Remove(orderToRemove);
            }
            else
            {
                throw new InvalidOperationException($"Order with ID {ordersId} not found.");
            }
        }

        private int GenerateOrderId()
        {
            return _orders.Count + 1;
        }
    }
}