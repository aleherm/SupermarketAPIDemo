using SupermarketAPIDemo.Domain.Models;
using SupermarketAPIDemo.Domain.Repositories;
using SupermarketAPIDemo.Domain.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SupermarketAPIDemo.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this._categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _categoryRepository.ListAsync();
        }
    }
}
