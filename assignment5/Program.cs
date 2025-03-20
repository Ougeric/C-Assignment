using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderManagementSystem
{
    public class OrderDetails
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public override bool Equals(object obj)
        {
            return obj is OrderDetails details &&
                   ProductName == details.ProductName &&
                   UnitPrice == details.UnitPrice;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ProductName, UnitPrice);
        }

        public override string ToString()
        {
            return $"{ProductName} x{Quantity} @{UnitPrice:C} (Total: {Quantity * UnitPrice:C})";
        }
    }

    public class Order
    {
        public string OrderId { get; set; }
        public string Customer { get; set; }
        private List<OrderDetails> details = new List<OrderDetails>();

        public decimal TotalAmount => details.Sum(d => d.Quantity * d.UnitPrice);

        public void AddDetail(OrderDetails detail)
        {
            if (details.Contains(detail))
                throw new ArgumentException("Duplicate order detail detected");
            details.Add(detail);
        }

        public void RemoveDetail(OrderDetails detail)
        {
            if (!details.Remove(detail))
                throw new ArgumentException("Order detail not found");
        }

        public IEnumerable<OrderDetails> GetDetails() => details.AsReadOnly();

        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   OrderId == order.OrderId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(OrderId);
        }

        public override string ToString()
        {
            return $"Order {OrderId} - Customer: {Customer}\n" +
                   $"Total: {TotalAmount:C}\n" +
                   "Details:\n" +
                   string.Join("\n", details.Select(d => $"  {d}"));
        }
    }

    public class OrderService
    {
        private List<Order> orders = new List<Order>();

        public void AddOrder(Order order)
        {
            if (orders.Contains(order))
                throw new ArgumentException("Order already exists");
            orders.Add(order);
        }

        public void RemoveOrder(string orderId)
        {
            var order = orders.FirstOrDefault(o => o.OrderId == orderId);
            if (order == null)
                throw new ArgumentException("Order not found");
            orders.Remove(order);
        }

        public void UpdateOrder(Order updatedOrder)
        {
            var index = orders.FindIndex(o => o.OrderId == updatedOrder.OrderId);
            if (index == -1)
                throw new ArgumentException("Order not found");
            orders[index] = updatedOrder;
        }

        public IEnumerable<Order> QueryOrders(
            Func<Order, bool> predicate,
            Func<Order, object> sortKey = null)
        {
            var query = orders.Where(predicate);
            return sortKey != null ?
                query.OrderBy(sortKey) :
                query.OrderBy(o => o.OrderId);
        }

        public void SortOrders(Comparison<Order> comparison = null)
        {
            orders.Sort(comparison ?? ((x, y) => x.OrderId.CompareTo(y.OrderId)));
        }
    }

    class Program
    {
        static OrderService service = new OrderService();

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\nOrder Management System");
                Console.WriteLine("1. Add Order");
                Console.WriteLine("2. Remove Order");
                Console.WriteLine("3. Update Order");
                Console.WriteLine("4. Query Orders");
                Console.WriteLine("5. Exit");
                Console.Write("Select option: ");

                switch (Console.ReadLine())
                {
                    case "1": AddOrder(); break;
                    case "2": RemoveOrder(); break;
                    case "3": UpdateOrder(); break;
                    case "4": QueryOrders(); break;
                    case "5": return;
                    default: Console.WriteLine("Invalid option"); break;
                }
            }
        }

        static void AddOrder()
        {
            try
            {
                var order = new Order();
                Console.Write("Enter Order ID: ");
                order.OrderId = Console.ReadLine();
                Console.Write("Enter Customer Name: ");
                order.Customer = Console.ReadLine();

                while (true)
                {
                    var detail = new OrderDetails();
                    Console.Write("Product Name: ");
                    detail.ProductName = Console.ReadLine();
                    Console.Write("Quantity: ");
                    detail.Quantity = int.Parse(Console.ReadLine());
                    Console.Write("Unit Price: ");
                    detail.UnitPrice = decimal.Parse(Console.ReadLine());

                    try { order.AddDetail(detail); }
                    catch (ArgumentException e) { Console.WriteLine(e.Message); }

                    Console.Write("Add another product? (y/n): ");
                    if (Console.ReadLine().ToLower() != "y") break;
                }

                service.AddOrder(order);
                Console.WriteLine("Order added successfully");
            }
            catch (Exception e) { Console.WriteLine($"Error: {e.Message}"); }
        }

        static void RemoveOrder()
        {
            try
            {
                Console.Write("Enter Order ID to remove: ");
                service.RemoveOrder(Console.ReadLine());
                Console.WriteLine("Order removed successfully");
            }
            catch (Exception e) { Console.WriteLine($"Error: {e.Message}"); }
        }

        static void UpdateOrder()
        {
            try
            {
                Console.Write("Enter Order ID to update: ");
                var orderId = Console.ReadLine();
                var existing = service.QueryOrders(o => o.OrderId == orderId).FirstOrDefault();
                if (existing == null) throw new ArgumentException("Order not found");

                var newOrder = new Order { OrderId = orderId };
                Console.Write($"New Customer Name ({existing.Customer}): ");
                newOrder.Customer = Console.ReadLine() ?? existing.Customer;

                foreach (var detail in existing.GetDetails())
                {
                    var newDetail = new OrderDetails
                    {
                        ProductName = detail.ProductName,
                        Quantity = detail.Quantity,
                        UnitPrice = detail.UnitPrice
                    };

                    Console.Write($"New Quantity for {detail.ProductName} ({detail.Quantity}): ");
                    if (int.TryParse(Console.ReadLine(), out int qty)) newDetail.Quantity = qty;

                    Console.Write($"New Price for {detail.ProductName} ({detail.UnitPrice:C}): ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal price)) newDetail.UnitPrice = price;

                    newOrder.AddDetail(newDetail);
                }

                service.UpdateOrder(newOrder);
                Console.WriteLine("Order updated successfully");
            }
            catch (Exception e) { Console.WriteLine($"Error: {e.Message}"); }
        }

        static void QueryOrders()
        {
            Console.WriteLine("Search by: 1) Order ID 2) Product 3) Customer 4) Amount Range");
            var choice = Console.ReadLine();

            IEnumerable<Order> results = null;
            switch (choice)
            {
                case "1":
                    Console.Write("Enter Order ID: ");
                    results = service.QueryOrders(o => o.OrderId == Console.ReadLine(), o => o.TotalAmount);
                    break;
                case "2":
                    Console.Write("Enter Product Name: ");
                    results = service.QueryOrders(o => o.GetDetails().Any(d => d.ProductName == Console.ReadLine()), o => o.TotalAmount);
                    break;
                case "3":
                    Console.Write("Enter Customer Name: ");
                    results = service.QueryOrders(o => o.Customer.Contains(Console.ReadLine()), o => o.TotalAmount);
                    break;
                case "4":
                    Console.Write("Min Amount: ");
                    decimal min = decimal.Parse(Console.ReadLine());
                    Console.Write("Max Amount: ");
                    results = service.QueryOrders(o => o.TotalAmount >= min && o.TotalAmount <= decimal.Parse(Console.ReadLine()), o => o.TotalAmount);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    return;
            }

            foreach (var order in results)
                Console.WriteLine($"\n{order}");
        }
    }
}
