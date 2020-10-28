using Microsoft.EntityFrameworkCore;
using SupermarketAPIDemo.Domain.Models;
using SupermarketAPIDemo.Domain.Persistence.Contexts;
using SupermarketAPIDemo.Domain.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SupermarketAPIDemo.Domain.Persistence.Repositories
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task AddAsync(Category category)
        {
            await _context.Categories.AddAsync(category);
        }
    }
}
