using QuickBuy.Domain.Arguments.Request;
using QuickBuy.Domain.Entitys;
using System.Threading.Tasks;

namespace QuickBuy.Domain.Contract.Managers
{
    public interface IProductManager
    {
        Task Add(ProductRequest param);
    }
}
