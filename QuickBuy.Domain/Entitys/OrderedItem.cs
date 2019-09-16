using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickBuy.Domain.Entitys
{
    public class OrderedItem : Entity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int ProductId { get; set; }

        public int Amount { get; set; }

        public OrderedItem( int productId, int amount)
        {
            ProductId = productId;
            Amount = amount;
        }

        public override void Validate()
        {
            if (ProductId == 0)
            {
                AddMessageValidate("Reference ID not found");
            }
            if (Amount == 0)
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
