using System;
using System.Collections.Generic;
using DigitalStoreWarehouse.Entities;
using DigitalStoreWarehouse.Exceptions;
using DigitalStoreWarehouse.Events;
using DigitalStoreWarehouse.DataStructures;

namespace DigitalStoreWarehouse.Warehouse
{
    // main warehouse class - manages products, search, update, and inventory value
    public class Warehouse
    {
        // simple list to store all products
        private readonly List<Product> products = new List<Product>();
        // custom sorted set to keep products sorted by price (cheap to expensive)
        private readonly SortedSetManual<Product> productsSortedByPrice = new SortedSetManual<Product>();

        // indexer to access product by name
        public Product this[string name]
        {
            get { return products.Find(p => p.Name == name); }
        }

        // indexer to access product by id
        public Product this[int id]
        {
            get { return products.Find(p => p.Id == id); }
        }

        // add new product to warehouse
        public void AddProduct(Product product)
        {
            products.Add(product);
            productsSortedByPrice.Add(product);
        }

        // update product price and stock
        // raises low stock event if new stock < 5
        public void UpdateProduct(string name, decimal newPrice, int newStock)  // تغییر: double -> decimal
        {
            Product product = FindProduct(name);
            if (product == null)
                throw new ProductNotFoundException(string.Format("Product {0} not found", name));

            productsSortedByPrice.Remove(product);
            product.Price = newPrice;
            product.UpdateStock(newStock);
            productsSortedByPrice.Add(product);

            if (newStock < 5 && newStock > 0)
            {
                WarehouseEventManager.RaiseStockLow(name, newStock);
            }
        }

        // find product by name (throws if not found)
        public Product FindProduct(string name)
        {
            Product product = products.Find(p => p.Name == name);
            if (product == null)
                throw new ProductNotFoundException(string.Format("Product {0} not found", name));
            return product;
        }

        // get list of products with stock below threshold
        public List<Product> GetLowStockProducts(int threshold)
        {
            List<Product> result = new List<Product>();
            foreach (Product p in products)
                if (p.Stock < threshold)
                    result.Add(p);
            return result;
        }

        // calculate total inventory value (price * stock for all products)
        public decimal GetTotalInventoryValue()  // تغییر: double -> decimal
        {
            decimal total = 0;  // تغییر: double -> decimal
            foreach (Product p in products)
                total += p.Price * p.Stock;
            return total;
        }

        // get products sorted by price (cheapest first)
        public List<Product> GetProductsSortedByPrice() => productsSortedByPrice.GetAll();

        // get all products (no specific order)
        public List<Product> GetAllProducts() => products;
    }
}