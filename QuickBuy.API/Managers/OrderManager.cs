using QuickBuy.Domain.Arguments.Request;
using QuickBuy.Domain.Contract;
using QuickBuy.Domain.Contract.Managers;
using QuickBuy.Domain.Entitys;
using System.Threading.Tasks;

namespace QuickBuy.API.Managers
{
    public class OrderManager : IOrderManager
    {
        private readonly IRepository<Order> _repoOrder;

        public OrderManager(IRepository<Order> repoOrder)
        {
            _repoOrder = repoOrder;
        }

        public Task Add(OrderRequest param)
        {
            var order = new Order(param.DateOrder, param.UserId, param.User, param.DateDelivery, param.CEP, param.State,
                param.Adress, param.NumberAdress, param.FormPaymnentId, param.FormPayment, param.OrderedItems);

            order.Validate();

            _repoOrder.Add(order);

            return Task.CompletedTask;
        }
    }
}
