using QuickBuy.Domain.Valuables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace QuickBuy.Domain.Entitys
{
    public class Order : Entity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

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

        public Order(DateTime dateOrder, int userId, User user, DateTime dateDelivery, string cEP, string state, 
            string adress, string numberAdress, int formPaymnentId, FormPayment formPayment, ICollection<OrderedItem> orderedItems)
        {
            DateOrder = dateOrder;
            UserId = userId;
            User = user;
            DateDelivery = dateDelivery;
            CEP = cEP;
            State = state;
            Adress = adress;
            NumberAdress = numberAdress;
            FormPaymnentId = formPaymnentId;
            FormPayment = formPayment;
            OrderedItems = orderedItems;
        }

        public override void Validate()
        {
            ClearValidateMessage();

            if (!OrderedItems.Any())
            {
                AddMessageValidate("The Order Cannot stay without products!");
            }
            if (string.IsNullOrEmpty(CEP))
            {
                AddMessageValidate("Cep must be completed");
            }
        }

        private void ClearValidateMessage()
        {
            ClearMessageValidate();
        }
    }
}
