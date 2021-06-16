using EmployeeApplication.API.Interfaces;
using EmployeeApplication.API.Models;
using EmployeeApplication.API.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApplication.API.Services
{
    public class EmployeeService : IEmployeeService
    {
        public IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public Employee CheckEmployee(int id)
        {
            Employee employee = new Employee();
            employee = _employeeRepository.GetEmployee(id);

            if (employee is null)
            {
                throw new KeyNotFoundException("Employee not found");
            }

            return _employeeRepository.GetEmployee(id);
        }

        public Employee DeleteEmployee(int id)
        {
            try
            {
                Employee employee = new Employee();
                employee = CheckEmployee(id);
                employee = _employeeRepository.DeleteEmployee(employee);
                return employee;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Employee GetEmployee(int id)
        {
            try
            {
                Employee employee = new Employee();
                employee = CheckEmployee(id);
                return _employeeRepository.GetEmployee(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Employee InsertEmployee(Employee employee)
        {
            try
            {
                employee = _employeeRepository.GetEmployee(employee.Id);
                return _employeeRepository.InsertEmployee(employee);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Employee UpdateEmployee(Employee employee)
        {
            try
            {
                employee = _employeeRepository.GetEmployee(employee.Id);
                return _employeeRepository.UpdateEmployee(employee);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
