using EmployeeApplication.API.Interfaces;
using EmployeeApplication.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApplication.API.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public AppDbContext _context;
        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
        }
        public Employee DeleteEmployee(Employee employee)
        {
            _context.Employees.Remove(employee);
            _context.SaveChanges();
            return employee;
        }

        public Employee GetEmployee(int id)
        {
            return _context.Employees.FirstOrDefault(x => x.Id == id);
        }

        public Employee InsertEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return employee;
        }

        public Employee UpdateEmployee(Employee employee)
        {
            _context.Employees.Update(employee);
            _context.SaveChanges();
            return employee;
        }
    }
}
