namespace Delegate.Console
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal static class Program
    {
        static void Main(string[] args)
        {
            var orders = new List<Order>
            {
                new() { Id = 1, Description = $"Description test {Guid.NewGuid()}", IsReadyShipment = true },
                new() { Id = 1, Description = $"Description test {Guid.NewGuid()}", IsReadyShipment = true }
            };

            var process = new ProcessOrder
            {
                OnOrderSendEmail = (orders) => orders.FirstOrDefault().IsReadyShipment
            };

            //ProcessOrder.OrderCompleted chain = ConfirmOrder;
            //chain += One;
            //chain += Two;
            //chain += Three;
            

            Action<List<Order>> chain = (orders) => ConfirmOrder(orders);

            chain += (orders) => System.Console.WriteLine("One with lambda");

            chain += (orders) => 
            {
                System.Console.WriteLine("Two with lambda");
            };

            process.Handler(orders, chain);

        }

        static void One(List<Order> orders) => System.Console.WriteLine("One");
        static void Two(List<Order> orders) => System.Console.WriteLine("Two");
        static void Three(List<Order> orders) => System.Console.WriteLine("Tree"); 

        static bool SendEmailOrder(List<Order> orders)
        {
            Console.WriteLine($"Email send to order {orders.FirstOrDefault()?.Description} ...");
            return true;
        }

        static void ConfirmOrder(List<Order> orders)
        {
            System.Console.WriteLine($"Order {orders.FirstOrDefault()?.Description} completed");
        }
    }
}


