using dws_ex_1.src.Domain.Repositories.IRepositories;
using dws_ex_1.src.Persistence.Context;

namespace dws_ex_1.src.Domain.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
