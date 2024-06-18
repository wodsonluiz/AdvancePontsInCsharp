namespace Event.Console
{
    using System;
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test using event");

            var processor = new OrderProcessor();
            
            processor.OrderCreated += BeginEvent;

            //teste usando lambda
            processor.OrderCreated += (sender, args) => 
            {
                Console.WriteLine("Recive segund event");
            };

            processor.OrderCreated2 += (sender, args) =>
            {
                Console.WriteLine($"Order description {args?.Order?.Description}");
            };

            processor.OrderCompletedEventArgs += (sender, args) =>
            {
                Console.WriteLine($"Order description: {args?.Order?.Description} processed");
            };

            processor.OrderCompletedEventArgs += FinishOrderAndSendEmail;

            processor.HandlerEvent();

        }

        private static void BeginEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Event recive");
        }

        private static void FinishOrderAndSendEmail(object sender, OrderCompletedEventArgs args)
        {
            Console.WriteLine($"Order description: {args?.Order?.Description} processed and send email");
        }
    }
}


