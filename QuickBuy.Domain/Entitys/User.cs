using System.Collections.Generic;

namespace QuickBuy.Domain.Entitys
{
    class User
    {
        public int Id { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public User(int id, string password, string email, string firstName, string lastName)
        {
            Id = id;
            Password = password;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
        }

        public ICollection<Order> Orders { get; set; }

    }
}
