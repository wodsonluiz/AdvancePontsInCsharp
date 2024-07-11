using System.Collections.Generic;

namespace TuplesDeconstruction.Console
{
    public class Order
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public List<Item> Itens { get; set; }

        public void Deconstruct(out long id, out string description)
        {
            id = Id;
            description = Description;
        }
    }

    public class Item
    {
        public long Price { get; set; }
    }
}