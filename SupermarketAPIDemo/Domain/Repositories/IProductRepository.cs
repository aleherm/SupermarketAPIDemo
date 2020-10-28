using SupermarketAPIDemo.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SupermarketAPIDemo.Domain.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> ListAsync();
    }
}
