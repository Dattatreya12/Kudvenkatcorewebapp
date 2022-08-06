using Kudvenkatcorewebapp.Models;
using Kudvenkatcorewebapp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kudvenkatcorewebapp.Repository
{
    public interface IEmployeeRepository
    {
        Task<Employee> GetEmployee(int id);
        IEnumerable<Employee> GetAllEmployees();
        Employee Add(Employee employee);
        IEnumerable<Employee> GetEmployeesList();
        Employee Update(Employee employeeupdate);
        Employee Delete(int id);
    }
}
