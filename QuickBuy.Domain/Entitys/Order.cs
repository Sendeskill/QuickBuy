using QuickBuy.Domain.Valuables;
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

        public DateTime DateDelivery { get; set; }

        public String CEP { get; set; }

        public String State { get; set; }

        public String Adress { get; set; }

        public String NumberAdress { get; set; }

        public int FormPaymnentId { get; set; }

        public FormPayment FormPayment { get; set; }

        public ICollection<OrderedItem> OrderedItems { get; set; }
    }
}
