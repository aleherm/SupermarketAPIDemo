using SupermarketAPIDemo.Domain.Persistence.Contexts;

namespace SupermarketAPIDemo.Domain.Persistence.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly AppDbContext _context;

        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }
    }
}
