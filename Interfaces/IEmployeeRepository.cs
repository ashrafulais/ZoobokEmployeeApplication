using EmployeeApplication.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApplication.API.Interfaces
{
    public interface IEmployeeRepository
    {
        public Employee GetEmployee(int id);
        public Employee InsertEmployee(Employee employee);
        public Employee UpdateEmployee(Employee employee);
        public Employee DeleteEmployee(Employee employee);
    }
}
