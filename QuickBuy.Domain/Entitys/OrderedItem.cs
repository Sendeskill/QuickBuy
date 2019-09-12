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
            if (ProductId == 0)
            {
                AddMessageValidate("Reference ID not found");
            }
            if(Amount == 0)
            {
                AddMessageValidate("Amount not defined");
            }
        }

        private void ClearValidateMessage()
        {
            ClearMessageValidate();
        }
    }
}
