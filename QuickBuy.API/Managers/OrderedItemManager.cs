using QuickBuy.Domain.Arguments.Request;
using QuickBuy.Domain.Contract;
using QuickBuy.Domain.Contract.Managers;
using QuickBuy.Domain.Entitys;
using System.Threading.Tasks;

namespace QuickBuy.API.Managers
{
    public class OrderedItemManager : IOrderedItemManager
    {
        private readonly IRepository<OrderedItem> _repoOrderemItem;

        public OrderedItemManager(IRepository<OrderedItem> repoOrderedItem)
        {
            _repoOrderemItem = repoOrderedItem;
        }

        public Task Add(OrderedItemRequest param)
        {
            var orderedItem = new OrderedItem(param.ProductId, param.Amount);

            orderedItem.Validate();

            _repoOrderemItem.Add(orderedItem);

            return Task.CompletedTask;
        }
    }
}
