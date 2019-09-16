using QuickBuy.Domain.Arguments.Request;
using QuickBuy.Domain.Contract;
using QuickBuy.Domain.Contract.Managers;
using QuickBuy.Domain.Entitys;
using System.Threading.Tasks;

namespace QuickBuy.API.Managers
{
    public class ProductManager : IProductManager
    {
        private readonly IRepository<Product> _repoProduct;

        public ProductManager(IRepository<Product> repoProduct)
        {
            _repoProduct = repoProduct;
        }

        public Task Add(ProductRequest param)
        {
            var product = new Product(param.Name, param.Description, param.Price);

            product.Validate();

            _repoProduct.Add(product);

            return Task.CompletedTask;
        }
    }
}
