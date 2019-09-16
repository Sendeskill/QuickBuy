using QuickBuy.Domain.Contract.Managers;
using QuickBuy.Domain.Entitys;
using System.Threading.Tasks;

namespace QuickBuy.Domain.Contract
{
    public interface IOrderRepository : IRepository<Order>
    {
        Task Add(IOrderManager param);
    }
}
