using QuickBuy.Domain.Arguments.Request;
using System.Threading.Tasks;

namespace QuickBuy.Domain.Contract.Managers
{
    public interface IUserManager
    {
        Task Register(UserRequest param);
    }
}
