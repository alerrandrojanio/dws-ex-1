using dws_ex_1.src.Domain.Models;

namespace dws_ex_1.src.Domain.Repositories.IRepsitories {
    public interface ICategoryRepository {
    Task<IEnumerable<Category>> ListAsync();
  }
}