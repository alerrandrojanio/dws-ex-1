using dws_ex_1.src.Domain.Models;
using dws_ex_1.src.Domain.Services.Communication;

namespace dws_ex_1.src.Domain.Services.IServices
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
        Task<CategoryResponse> SaveAsync(Category category);
        Task<CategoryResponse> UpdateAsync(int id, Category category);
        Task<CategoryResponse> DeleteAsync(int id);
    }
}
