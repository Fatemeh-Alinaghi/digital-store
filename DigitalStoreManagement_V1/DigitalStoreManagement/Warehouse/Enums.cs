namespace DigitalStoreWarehouse.Enums
{
    // product categories for digital store
    public enum ProductCategory
    {
        Laptop,        
        Tablet,       
        Mobile,      
        Headphone,     
        SmartWatch,  
        Accessory      // accessory (charger, cable, etc)
    }

    // stock status for reporting (future use)
    public enum StockStatus
    {
        InStock,       // stock >= 5
        LowStock,      // stock between 1 and 4
        OutOfStock,    // stock == 0
        Discontinued   // product no longer sold
    }
}