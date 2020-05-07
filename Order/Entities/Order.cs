using System;
using System.Collections.Generic;
using System.Text;
using Order.Entities.Enum;

namespace Order.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Itens { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status)
        {
            Moment = moment;
            Status = status;
        }

        public void AddItem(OrderItem item, Product product)
        {
            Itens.Add(item);
        }
    }
}
