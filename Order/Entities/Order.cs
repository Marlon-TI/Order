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
    }
}
