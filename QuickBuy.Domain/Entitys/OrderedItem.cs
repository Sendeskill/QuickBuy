using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domain.Entitys
{
    public class OrderedItem : Entity
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public int Amount { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
