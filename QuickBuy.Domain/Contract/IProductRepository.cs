using QuickBuy.Domain.Contract.Managers;
using QuickBuy.Domain.Entitys;
using System.Threading.Tasks;

namespace QuickBuy.Domain.Contract
{
    public interface IProductRepository : IRepository<Product>
    {
        Task Add(IProductManager param);
    }
}
