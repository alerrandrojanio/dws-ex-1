using dws_ex_1.src.Persistence.Context;

namespace dws_ex_1.src.Domain.Repositories
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
