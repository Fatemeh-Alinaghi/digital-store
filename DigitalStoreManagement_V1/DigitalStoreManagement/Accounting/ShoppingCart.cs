
using System.Collections.Generic;
using DigitalStoreWarehouse.Entities;

namespace DigitalStoreWarehouse.Entities
{
    public class ShoppingCart
    {
        public List<Product> Items { get; set; } = new List<Product>();

        public void AddToCart(Product p)
        {
            Items.Add(p);
        }

        public void AddToCart(Product p, int qty)
        {
            for (int i = 0; i < qty; i++)
            {
                Items.Add(p);
            }
        }
    }
}