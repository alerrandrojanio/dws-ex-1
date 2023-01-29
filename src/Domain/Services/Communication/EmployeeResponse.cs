using dws_ex_1.src.Domain.Models;

namespace dws_ex_1.src.Domain.Services.Communication
{
    public class EmployeeResponse : BaseResponse
    {
        public Employee Employee { get; private set; }

        private EmployeeResponse(bool success, string message, Employee employee)
            : base(success, message)
        {
            Employee = employee;
        }

        /// <summary>
        /// Creates a sucess response.
        /// </summary>
        /// <param name="employee">Saved category.</param>
        public EmployeeResponse(Employee employee)
            : this(true, string.Empty, employee) { }

        /// <summary>
        /// Creates an error response.
        /// </summary>
        /// <param name="message">Error message.</param>
        public EmployeeResponse(string message)
            : this(false, message, null) { }
    }
}
