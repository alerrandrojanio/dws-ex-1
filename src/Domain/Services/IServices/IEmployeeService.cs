using dws_ex_1.src.Domain.Models;
using dws_ex_1.src.Domain.Services.Communication;

namespace dws_ex_1.src.Domain.Services.IServices
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> ListAsync();
        Task<EmployeeResponse> SaveAsync(Employee employee);
        Task<EmployeeResponse> UpdateAsync(int id, Employee employee);
        Task<EmployeeResponse> DeleteAsync(int id);
    }
}
