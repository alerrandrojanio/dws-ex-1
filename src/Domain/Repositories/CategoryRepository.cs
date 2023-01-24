using Microsoft.EntityFrameworkCore;
using dws_ex_1.src.Domain.Models;
using dws_ex_1.src.Domain.Repositories.IRepositories;
using dws_ex_1.src.Persistence.Context;

namespace dws_ex_1.src.Domain.Repositories
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context)
            : base(context) { }

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
