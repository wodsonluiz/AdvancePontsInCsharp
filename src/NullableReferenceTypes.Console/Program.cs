namespace NullableReferenceTypes.Console;
using System;
using System.Collections.Generic;

public static class Program
{
    static void Main(string[] args)
    {
        var listItens = new List<Item>{ new Item{ Description = "PS5" } };
        var order = new Order(1, $"Description teste", listItens);

        var description = order.Description;

        if(OrderValidator.ValidaDescription(description))
        {
            string descriptionAsString = description.ToString();
            Console.WriteLine(descriptionAsString);

        }
    }
}
