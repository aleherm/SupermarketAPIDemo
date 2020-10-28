using Microsoft.EntityFrameworkCore;
using SupermarketAPIDemo.Domain.Models;
using SupermarketAPIDemo.Domain.Persistence.Contexts;
using SupermarketAPIDemo.Domain.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SupermarketAPIDemo.Domain.Persistence.Repositories
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Product>> ListAsync()
        {
            return await _context.Products.Include(p => p.Category)
                                          .ToListAsync();
        }
    }
}
