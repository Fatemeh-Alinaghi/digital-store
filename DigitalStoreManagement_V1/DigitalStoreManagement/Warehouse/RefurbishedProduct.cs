using DigitalStoreWarehouse.Entities;

namespace DigitalStoreWarehouse.Entities
{
    public class RefurbishedProduct : Product
    {
        private double discountRate;

        public double DiscountRate
        {
            get { return discountRate; }
            set { discountRate = value; }
        }

        public override decimal Price
        {
            get
            {
                decimal discountedPrice = base.Price * (decimal)(1 - discountRate / 100);
                return discountedPrice;
            }
            set { base.Price = value; }
        }
    }
}