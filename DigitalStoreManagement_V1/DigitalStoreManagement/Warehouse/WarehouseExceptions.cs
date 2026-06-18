using System;
using System.Windows.Forms;
using System.Drawing;
namespace DigitalStoreWarehouse.Exceptions
{
    // custom exception when product not found
    public class ProductNotFoundException : Exception
    {
        public ProductNotFoundException(string message) : base(message) { }
    }

    // custom exception when stock is insufficient
    public class OutOfStockException : Exception
    {
        public OutOfStockException(string message) : base(message) { }
    }
}