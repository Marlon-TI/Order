using System;
using System.Collections.Generic;
using System.Text;
using OrderP.Entities;
using System.Globalization;

namespace OrderP.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Item { get; set; }


        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product item)
        {
            Quantity = quantity;
            Price = price;
            Item = item;
        }

        public double SubTotal()
        {
            double total;
            return total = Quantity * Price;
        }

        public override string ToString()

        {

            return Item.Name

                + ", $"

                + Price.ToString("F2", CultureInfo.InvariantCulture)

                + ", Quantity: "

                + Quantity

                + ", Subtotal: $"

                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
