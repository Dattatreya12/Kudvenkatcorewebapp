using Kudvenkatcorewebapp.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Kudvenkatcorewebapp.DBContext;
using Kudvenkatcorewebapp.ViewModels;
using Microsoft.EntityFrameworkCore;
using Kudvenkatcorewebapp.DTO;
//using AutoMapper;

namespace Kudvenkatcorewebapp.Repository
{
    public class EmployeeRepository : IEmployeeRepository 
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;
        private readonly AppDbContext context;
        //private readonly IMapper _mapper;

        public EmployeeRepository(IConfiguration configurtion,AppDbContext context)
        {
            this.context = context;
            this._configuration = configurtion;
            this._connectionString = this._configuration.GetConnectionString("Default");
            //_mapper = mapper;
            //_employeelist = new List<Employee>()
            //{
            //    new Employee(){Id=1,Name="Marry",Department=Dept.HR,Email="Dd@gmail.com"},
            //    new Employee(){Id=2,Name="Dk",Department=Dept.IT,Email="ff@gmail.com"}
            // };
        }
        public async Task<Employee> GetEmployee(int id)
        {
            return  context.employees.Find(id);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            IEnumerable<Employee> emp = from c in context.employees
                                        select c;
            return emp;
            
        }

        public IEnumerable<Employee> GetEmployeesList()
        {
            var isdepartment = new List<Employee>();
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("select * from employees", con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    isdepartment.Add(new Employee
                    {
                        Id = rdr.GetInt32("Id"),
                        Name = rdr.GetString("Name"),
                        Email = rdr.GetString("Email"),
                        Active = rdr.GetInt32("Active")
                    });
                }
            }
            return isdepartment;
        }

        public Employee Add(Employee employee)
        {
            if(employee.Gender=="M" || employee.Gender=="m")
            {
                employee.InitialName = "Mr.";
            }
            else
            {
                employee.InitialName = "Miss.";
            }
            context.employees.Add(employee);
            context.SaveChanges();
            return employee;
            //employee.Id = _employeelist.Max(x => x.Id) + 1;
            //_employeelist.Add(employee);
            //return employee;


        }

        public Employee Update(Employee employeeupdate)
        {
            Employee employee =context.employees.FirstOrDefault(e => e.Id == employeeupdate.Id);
            if(employee!=null)
            {
                employee.Name = employeeupdate.Name;
                employee.Email = employeeupdate.Email;
                employee.Department = employeeupdate.Department;
                employee.Active = employeeupdate.Active;
                employee.Gender = employeeupdate.Gender;
                if (employee.Gender == "M" || employee.Gender == "m")
                {
                    employee.InitialName = "Mr.";
                }
                else
                {
                    employee.InitialName = "Miss.";
                }
            }
            else
            {

            }
            context.SaveChanges();
            return employee;
           
        }

        public Employee Delete(int id)
        {
            Employee employee =context.employees.FirstOrDefault(e => e.Id == id);
            if(employee!=null)
            {
                employee.Active = 0;
            }
            return employee;
        }
    }
}
