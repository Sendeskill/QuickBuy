using QuickBuy.Domain.Contract.Managers;
using QuickBuy.Domain.Entitys;
using System.Threading.Tasks;

namespace QuickBuy.Domain.Contract
{
    public interface IOrderedItemRepository : IRepository<OrderedItem>
    {
        Task Add(IOrderedItemManager param);
    }
}
