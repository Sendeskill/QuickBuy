using QuickBuy.Domain.Entitys;
using QuickBuy.Domain.Valuables;
using System;
using System.Collections.Generic;

namespace QuickBuy.Domain.Arguments.Request
{
    public class OrderRequest
    {
        public DateTime DateOrder { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public DateTime DateDelivery { get; set; }
        public string CEP { get; set; }
        public string State { get; set; }
        public string Adress { get; set; }
        public string NumberAdress { get; set; }
        public int FormPaymnentId { get; set; }
        public FormPayment FormPayment { get; set; }
        public ICollection<OrderedItem> OrderedItems { get; set; }
    }
}
