namespace Delegate.Console
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        static void Main(string[] args)
        {
            var orders = new List<Order>
            {
                new() { Id = 1, Description = $"Description test {Guid.NewGuid()}"},
                new() { Id = 1, Description = $"Description test {Guid.NewGuid()}"}
            };

            var process = new ProcessOrder
            {
                OnOrderSendEmail = SendEmailOrder
            };

            process.Handler(orders, ConfirmOrder);

        }

        static void SendEmailOrder()
        {
            System.Console.WriteLine("Email send...");
        }

        static void ConfirmOrder()
        {
            System.Console.WriteLine($"Order completed");
        }
    }
}


