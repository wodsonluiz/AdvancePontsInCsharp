using System;
using System.Collections.Generic;

namespace Delegate.Console
{
    internal class ProcessOrder
    {
        public delegate void OrderSendEmail();
        public delegate void OrderCompleted();
        
        public OrderSendEmail? OnOrderSendEmail { get; set; }

        public void Handler(List<Order> orders, OrderCompleted orderCompleted)
        {
            ArgumentNullException.ThrowIfNull(orders);

            Initialize();
            orderCompleted?.Invoke();
        }

        private void Initialize()
        {
            OnOrderSendEmail?.Invoke();
        }
    }
}