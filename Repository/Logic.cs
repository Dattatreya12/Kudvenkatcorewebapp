using Kudvenkatcorewebapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kudvenkatcorewebapp.Repository
{
    public class Logic : Ilogic
    {
        private readonly Ilogic _ilogic;
        public Logic(Ilogic ilogic)
        {
            _ilogic = ilogic;
        }

        public IEnumerable<Employee> GetEmployeesList()
        {
            throw new NotImplementedException();
        }
        //public IEnumerable<Employee> GetEmployeesList()
        //{
        //    IEnumerable<Employee> emplist = _ilogic.GetEmployeesList().Where(Employee => Employee.Name == "Datta");
        //}
    }
}
