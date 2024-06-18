using System;

namespace Event.Console
{
    public class OrderCreatedEventArgs: EventArgs
    {
        public Order? Order { get; set; }
        public decimal OldTotal { get; set; }
        public decimal NewTotal { get; set; }
    }
}