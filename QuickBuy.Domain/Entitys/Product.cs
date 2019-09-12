using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domain.Entitys
{
    public class Product : Entity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Name))
            {
                AddMessageValidate("Name not defined");
            }
            if (string.IsNullOrEmpty(Description))
            {
                AddMessageValidate("Description not defined");
            }
            if (Price < 0)
            {
                AddMessageValidate("Price cannot be negative");
            }
        }

        private void ClearValidateMessage()
        {
            ClearMessageValidate();
        }
    }
}
