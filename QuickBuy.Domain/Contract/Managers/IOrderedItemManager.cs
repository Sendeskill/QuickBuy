using QuickBuy.Domain.Arguments.Request;
using System.Threading.Tasks;

namespace QuickBuy.Domain.Contract.Managers
{
    public interface IOrderedItemManager
    {
        Task Add(OrderedItemRequest param);
    }
}
