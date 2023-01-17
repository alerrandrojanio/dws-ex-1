using dws_ex_1.src.Domain.Models;

namespace dws_ex_1.src.Domain.Services.IServices {
    public interface ICategoryService {
        Task<IEnumerable<Category>> ListAsync();
    }
}