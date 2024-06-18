using System;

namespace Event.Console
{
    public class OrderCompletedEventArgs: EventArgs
    {
        public Order? Order { get; set; }
    }
}