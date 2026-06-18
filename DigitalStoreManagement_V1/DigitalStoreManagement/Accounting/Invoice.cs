using System;
using System.Collections.Generic;
using DigitalStoreWarehouse.Entities;

namespace DigitalStoreManagement.Accounting
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public DateTime Date { get; set; }
        public ShoppingCart Cart { get; set; }
        public decimal TotalAmount { get; set; }

        public Invoice()
        {
            Date = DateTime.Now;
        }

        public Invoice(ShoppingCart cart)
        {
            Cart = cart;
            Date = DateTime.Now;
            CalculateTotal();
        }

        public virtual void CalculateTotal()
        {
            if (Cart != null && Cart.Items != null)
            {
                decimal total = 0;
                foreach (var item in Cart.Items)
                {
                    total += item.Price;
                }
                TotalAmount = total;
            }
        }

        public virtual string GetDetails(ShoppingCart cart)
        {
            decimal total = 0;
            foreach (var item in cart.Items)
            {
                total += item.Price;
            }
            return $"Invoice - Date: {Date} - Total: {total:N0} تومان";
        }
    }
}