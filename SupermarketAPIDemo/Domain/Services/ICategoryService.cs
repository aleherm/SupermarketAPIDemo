using SupermarketAPIDemo.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SupermarketAPIDemo.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}
