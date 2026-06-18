using DigitalStoreWarehouse.Entities;

namespace DigitalStoreWarehouse.Warehouse
{
    // middle layer between UI and warehouse - applies business rules
    public class InventoryManager
    {
        private Warehouse warehouse;

        public InventoryManager(Warehouse warehouse)
        {
            this.warehouse = warehouse;
        }

        // check if product can be sold (enough stock)
        public bool CanSellProduct(string productName, int requestedQuantity)
        {
            Product product = warehouse.FindProduct(productName);
            return product.CheckAvailability(requestedQuantity);
        }

        // reduce product stock after successful sale
        public void ReduceStock(string productName, int quantity)
        {
            Product product = warehouse.FindProduct(productName);
            int newStock = product.Stock - quantity;
            warehouse.UpdateProduct(productName, product.Price, newStock);
        }
    }
}