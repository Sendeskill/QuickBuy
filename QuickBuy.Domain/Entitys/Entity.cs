using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Domain.Entitys
{
    public abstract class Entity
    {
        public List<string> _validateMessage { get; set; }

        private List<string> validateMessage
        {
            get { return _validateMessage ?? (_validateMessage = new List<string>()); }
        }

        protected void AddMessageValidate(string msg)
        {
            validateMessage.Add("*Critical* " + msg);
        }

        protected void ClearMessageValidate()
        {
            validateMessage.Clear();
        }

        public abstract void Validate();

        protected bool IsValid
        {
            get { return validateMessage.Any(); }
        }

    }
}
