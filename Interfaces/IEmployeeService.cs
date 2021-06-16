using EmployeeApplication.API.Models;

namespace EmployeeApplication.API.Interfaces
{
    public interface IEmployeeService
    {
        public Employee GetEmployee(int id);
        public Employee InsertEmployee(Employee employee);
        public Employee UpdateEmployee(Employee employee);
        public Employee DeleteEmployee(int id);
        public Employee CheckEmployee(int id);
    }
}
