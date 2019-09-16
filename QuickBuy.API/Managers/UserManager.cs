using QuickBuy.Domain.Arguments.Request;
using QuickBuy.Domain.Contract;
using QuickBuy.Domain.Contract.Managers;
using QuickBuy.Domain.Entitys;
using System.Threading.Tasks;

namespace QuickBuy.API.Managers
{
    public class UserManager : IUserManager
    {
        private readonly IRepository<User> _repoUser;

        public UserManager(IRepository<User> repoUser)
        {
            _repoUser = repoUser;
        }

        public Task Register(UserRequest param)
        {
            var user = new User(param.Password, param.Email, param.FirstName, param.LastName);

            user.Validate();

            _repoUser.Add(user);

            return Task.CompletedTask;
        }
    }
}
