namespace OverloagingExtension.Console
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point(1, 2);
            var p2 = new Point(3, 4);
            var p3 = p1 + p2;

            System.Console.WriteLine(p3);
            System.Console.WriteLine(p1);
        }
    }
}


