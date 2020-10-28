using SupermarketAPIDemo.Domain.Models;
using SupermarketAPIDemo.Domain.Services.Communication;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SupermarketAPIDemo.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
        Task<CategoryResponse> SaveAsync(Category category);
        Task<CategoryResponse> UpdateAsync(int id, Category category);
        Task<CategoryResponse> DeleteAsync(int id);
    }
}
