using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderManagementCore
{
    public class OrderService
    {
        private List<Order> orders = new List<Order>();

        public void AddOrder(Order order)
        {
            if (orders.Contains(order))
                throw new ArgumentException("Order already exists!");
            orders.Add(order);
        }

        public void RemoveOrder(int orderId)
        {
            var order = GetOrder(orderId) ?? throw new ArgumentException("Order not found!");
            orders.Remove(order);
        }

        public void UpdateOrder(Order newOrder)
        {
            var oldOrder = GetOrder(newOrder.OrderId) ?? throw new ArgumentException("Order not found!");
            orders.Remove(oldOrder);
            orders.Add(newOrder);
        }

        public List<Order> QueryOrders(Func<Order, bool> condition = null)
        {
            var query = orders.AsQueryable();
            if (condition != null) query = query.Where(condition);
            return query.OrderBy(o => o.TotalAmount).ToList();
        }

        public Order GetOrder(int orderId) => orders.FirstOrDefault(o => o.OrderId == orderId);

        public void Sort(Comparison<Order> comparison = null)
        {
            orders.Sort(comparison ?? ((x, y) => x.OrderId.CompareTo(y.OrderId)));
        }
    }
}