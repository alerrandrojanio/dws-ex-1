using dws_ex_1.src.Domain.Models;

namespace dws_ex_1.src.Domain.Repositories.IRepositories
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
