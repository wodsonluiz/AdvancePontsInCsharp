using System.Collections.Generic;

namespace PatternMatching.Console
{
    public class Order
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public List<Item> Itens { get; set; }
        public bool IsReadyShipping { get; set; }
    }

    public class Item
    {
        public string Description { get; set; }
        public long Price { get; set; }
    }
}