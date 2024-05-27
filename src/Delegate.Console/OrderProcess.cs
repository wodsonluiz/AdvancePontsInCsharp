using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegate.Console
{
    public class ProcessOrder
    {
        //public delegate bool OrderSendEmail(List<Order> orders);
        //public delegate void OrderCompleted(List<Order> orders);

        
        public Func<List<Order>, bool> OnOrderSendEmail { get; set; }

        public void Handler(List<Order> orders, Action<List<Order>> orderCompleted = default)
        {
            ArgumentNullException.ThrowIfNull(orders);

            Initialize(orders);
            orderCompleted?.Invoke(orders);
        }

        private void Initialize(List<Order> orders)
        {
            if(OnOrderSendEmail?.Invoke(orders) == false)
            {
                System.Console.WriteLine($"Unable completed order {orders.FirstOrDefault()?.Description}");
            }
        }
    }
}