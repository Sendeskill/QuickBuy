using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domain.Entitys
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime DateOrder { get; set; }

        public int UserId { get; set; }

        public ICollection<OrderedItem> OrderedItems { get; set; }
    }
}
