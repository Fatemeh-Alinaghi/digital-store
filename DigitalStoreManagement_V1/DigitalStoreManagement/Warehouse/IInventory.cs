namespace DigitalStoreWarehouse.Interfaces
{
    // contract for inventory management
    public interface IInventory
    {
        bool CheckAvailability(int requestedQuantity);
        void UpdateStock(int newStock);
    }
}