using QuickBuy.Domain.Contract;
using QuickBuy.Domain.Entitys;

namespace QuickBuy.Repository.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository()
        {

        }
    }
}
