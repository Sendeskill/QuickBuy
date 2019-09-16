using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickBuy.Domain.Entitys
{
    public class User : Entity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public User(string password, string email, string firstName, string lastName)
        {
            Password = password;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
        }

        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Password))
            {
                AddMessageValidate("Password not defined");
            }
            if (string.IsNullOrEmpty(Email))
            {
                AddMessageValidate("Email not defined");
            }
            if (string.IsNullOrEmpty(FirstName))
            {
                AddMessageValidate("First Name not defined");
            }
        }

        private void ClearValidateMessage()
        {
            ClearMessageValidate();
        }
    }
}