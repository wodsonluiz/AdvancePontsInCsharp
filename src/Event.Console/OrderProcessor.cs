using System;
using System.Diagnostics.Contracts;

namespace Event.Console
{
    public class OrderProcessor
    {
        public event EventHandler OrderCreated;
        public event EventHandler<OrderCreatedEventArgs> OrderCreated2;
        public event EventHandler<OrderCompletedEventArgs> OrderCompletedEventArgs;

        protected virtual void OnOrderCreated()
        {
            OrderCreated?.Invoke(this, EventArgs.Empty); 
        }

        protected virtual void OnOrderCreated2(OrderCreatedEventArgs args)
        {
            OrderCreated2?.Invoke(this, args);
        }

        protected virtual void CompletedOrder(OrderCompletedEventArgs args)
        {
            OrderCompletedEventArgs.Invoke(this, args);
        }

        public void HandlerEvent()
        {
            OnOrderCreated(); 

            var order = new Order
            {
                Id = 1,
                Description = $"Description teste {Guid.NewGuid()}"
            };

            var args = new OrderCreatedEventArgs
            {
                Order = order,
                NewTotal = 100,
                OldTotal = 80
            };

            OnOrderCreated2(args);
            CompletedOrder(new OrderCompletedEventArgs {Order = order });
        }
    }
}