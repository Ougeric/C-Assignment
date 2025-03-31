using System;

namespace OrderManagementCore
{
    public class OrderDetail : IEquatable<OrderDetail>
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Amount => UnitPrice * Quantity;

        public override bool Equals(object obj) => Equals(obj as OrderDetail);
        public bool Equals(OrderDetail other) =>
            other != null && ProductName == other.ProductName;
        public override int GetHashCode() => ProductName.GetHashCode();

        public override string ToString() =>
            $"{ProductName} ×{Quantity} @{UnitPrice:C} = {Amount:C}";
    }
}