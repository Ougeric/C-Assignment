using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderManagementCore
{
    public class Order : IEquatable<Order>
    {
        public int OrderId { get; set; }
        public string Customer { get; set; }
        public List<OrderDetail> Details { get; } = new List<OrderDetail>();
        public DateTime OrderTime { get; set; } = DateTime.Now;

        public decimal TotalAmount => Details.Sum(d => d.Amount);

        public override bool Equals(object obj) => Equals(obj as Order);
        public bool Equals(Order other) => other != null && OrderId == other.OrderId;
        public override int GetHashCode() => OrderId.GetHashCode();

        public override string ToString() =>
            $"OrderID: {OrderId}, Customer: {Customer}, Total: {TotalAmount:C}, Time: {OrderTime:yyyy-MM-dd HH:mm}";
    }
}