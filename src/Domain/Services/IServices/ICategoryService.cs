using dws_ex_1.src.Domain.Models;
using dws_ex_1.src.Domain.Services.Communication;

namespace dws_ex_1.src.Domain.Services.IServices
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
        Task<SaveCategoryResponse> SaveAsync(Category category);
        Task<SaveCategoryResponse> UpdateAsync(int id, Category category);
    }
}
