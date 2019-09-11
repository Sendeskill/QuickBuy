using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Domain.Valuables
{
    public class FormPayment
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Description { get; set; }

        public bool IsNotDefined
        {
            get { return Id == (int)FormPaymentEnum.NotDefined; }
        }

        public bool IsBillit
        {
            get { return Id == (int)FormPaymentEnum.Billet; }
        }

        public bool IsCreditCard
        {
            get { return Id == (int)FormPaymentEnum.CreditCard; }
        }

        public bool IsDeposit
        {
            get { return Id == (int)FormPaymentEnum.Deposit; }
        }

    }
}
