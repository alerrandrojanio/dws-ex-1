using dws_ex_1.src.Domain.Models;

namespace dws_ex_1.src.Domain.Repositories.IRepositories
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> ListAsync();
        Task AddAsync(Employee employee);
        Task<Employee> FindByIdAsync(int id);
        void Update(Employee employee);
        void Remove(Employee employee);
    }
}
