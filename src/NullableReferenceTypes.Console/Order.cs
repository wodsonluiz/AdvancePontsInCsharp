using System.Collections.Generic;
using System.Net.Http.Headers;

namespace NullableReferenceTypes.Console
{
    public class Order
    {
        public int Id { get; init; }
        public string? Description { get; init; }
        public List<Item> Items { get; init; }

        public Order(int id, string description, List<Item> itens)
        {
            Id = id;
            Description = description;
            Items = itens;
        }
    }

    public class Item
    {
        public string? Description { get; set; }
    }
}