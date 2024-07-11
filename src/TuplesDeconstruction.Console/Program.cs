namespace TuplesDeconstruction.Console;
using System;
using System.Collections.Generic;
using System.Text.Json;

internal static class Program
{
    static void Main(string[] args)
    {
        var order = new Order
        {
            Id = 1,
            Description = $"Description teste {Guid.NewGuid()}",
            Itens = new List<Item>
            {
                new Item { Price = 100 },
                new Item { Price = 200 },
                new Item { Price = 300 }
            }
        };

        var subSet = new 
        {
            order.Id,
            order.Description,
            order.Itens
        };

        //Tuple assignment
        var subSet2 = (order.Id, order.Description, order.Itens);
        //var (id, description, itens) = (order.Id, order.Description, order.Itens);

        //Tuple deconstruction  
        long id;
        string description;

        (id, description, var itens) = (order.Id, order.Description, order.Itens);

        //var json = JsonSerializer.Serialize(subSet3, options: new JsonSerializerOptions{ IncludeFields = true});

        Console.WriteLine(id);
        Console.WriteLine(description); 
        Console.WriteLine(itens);

        //Deconstruct object types
        (id, description) = order; 

        var dictionary = new Dictionary<string, Order>();

        foreach (var (orderNumber, theOrder) in dictionary)
        {
            
        }

        System.Console.WriteLine($"Id {id} and Description {description}");
    }
}
