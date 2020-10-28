using SupermarketAPIDemo.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SupermarketAPIDemo.Domain.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> ListAsync();
    }
}
