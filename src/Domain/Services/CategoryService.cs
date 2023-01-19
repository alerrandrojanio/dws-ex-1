using dws_ex_1.src.Domain.Models;
using dws_ex_1.src.Domain.Services.IServices;
using dws_ex_1.src.Domain.Repositories.IRepsitories;

namespace dws_ex_1.src.Domain.Services {
    public class CategoryService : ICategoryService {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository) {
            _categoryRepository = categoryRepository;
        }
        public async Task<IEnumerable<Category>> ListAsync() {
            return await _categoryRepository.ListAsync();
        }
    }
}