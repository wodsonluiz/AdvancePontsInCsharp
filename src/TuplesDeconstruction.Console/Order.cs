using System.Collections.Generic;

namespace TuplesDeconstruction.Console
{
    public class Order
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public List<Item> Itens { get; set; }

        public void Deconstruct(out long id, out string description, out decimal price)
        {
            id = Id;
            description = Description;
            price = Price;
        }

       
    }

    public class Item
    {
        public long Price { get; set; }
    }
}