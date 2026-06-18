using System;
using DigitalStoreWarehouse.Enums;
using DigitalStoreWarehouse.Interfaces;

namespace DigitalStoreWarehouse.Entities
{
    public class Product : IInventory, IComparable<Product>
    {
        private int id;
        private string name;
        private decimal price;
        private int stock;
        private ProductCategory category;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public virtual decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public ProductCategory Category
        {
            get { return category; }
            set { category = value; }
        }

        public bool CheckAvailability(int requestedQuantity)
        {
            return stock >= requestedQuantity;
        }

        public void UpdateStock(int newStock)
        {
            stock = newStock;
        }

        public virtual string GetDisplayInfo()
        {
            return string.Format("{0} - Price: {1} - Stock: {2} - Category: {3}",
                Name, Price, Stock, Category);
        }

        public int CompareTo(Product other)
        {
            if (other == null) return 1;
            return this.Price.CompareTo(other.Price);
        }
    }
}