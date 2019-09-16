using QuickBuy.Domain.Arguments.Request;
using System.Threading.Tasks;

namespace QuickBuy.Domain.Contract.Managers
{
    public interface IOrderManager
    {
        Task Add(OrderRequest param);
    }
}
