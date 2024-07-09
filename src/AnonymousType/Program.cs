using System;

namespace AnonymousType;

class Program
{
    static void Main(string[] args)
    {
        var instance = new { Total = 20, AmountBalance = 100 };
        var secondInstance = new { Total = 20, AmountBalance = 100 };

        var order = new Order
        {
            Id = 1,
            Amount = 10
        };

        var subSet = new 
        {
            order.Id,
            order.Amount
        };

        Console.WriteLine($"Print property to object anonytype {subSet.Amount} and {subSet.Id}");

        Console.WriteLine(instance.Equals(secondInstance));
        Console.WriteLine(instance == secondInstance);
    }
}
