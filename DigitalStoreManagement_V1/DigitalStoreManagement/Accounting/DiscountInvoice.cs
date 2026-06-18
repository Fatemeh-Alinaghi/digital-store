using System;
using DigitalStoreWarehouse.Entities;

namespace DigitalStoreManagement.Accounting
{
    public class DiscountInvoice : Invoice
    {
        public decimal DiscountPercent { get; set; }

        public override string GetDetails(ShoppingCart cart)
        {
            decimal total = 0;
            foreach (var item in cart.Items)
            {
                total += item.Price;
            }

            decimal discountAmount = total * DiscountPercent / 100;
            decimal finalTotal = total - discountAmount;

            string result = "=== فاکتور با تخفیف ===\r\n";
            result += $"تاریخ: {DateTime.Now}\r\n";
            result += $"جمع کل: {total:N0} تومان\r\n";
            result += $"تخفیف ({DiscountPercent}%): {discountAmount:N0} تومان\r\n";
            result += $"مبلغ قابل پرداخت: {finalTotal:N0} تومان";

            return result;
        }
    }
}