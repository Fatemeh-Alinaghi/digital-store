using System;

namespace DigitalStoreWarehouse.Events
{
    // delegate for low stock event
    public delegate void StockLowHandler(string productName, int remainingStock);

    // static event manager for warehouse
    public static class WarehouseEventManager
    {
        // event fired when stock becomes low (<5)
        public static event StockLowHandler OnStockLow;

        // helper method to raise the event
        public static void RaiseStockLow(string productName, int remainingStock)
        {
            OnStockLow?.Invoke(productName, remainingStock);
        }
    }
}