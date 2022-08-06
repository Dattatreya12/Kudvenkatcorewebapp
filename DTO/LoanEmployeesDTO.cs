using Kudvenkatcorewebapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kudvenkatcorewebapp.DTO
{
    public class LoanEmployeesDTO
    {
        public int Id { get; set; }
        public string LoanID { get; set; }
        public int TotalEmi { get; set; }
        public double TotalIntrest { get; set; }
        public int Active { get; set; }
        public DateTime LoanDate { get; set; }
        public int EmployeeId { get; set; }
        public string LoanUserName { get; set; }
        public string LoanStatus { get; set; }
        public ICollection<Employee> employeesname { get; set; }
        //Adding 07-07-2022 below 2 columns
        public int TotalPaidEmi { get; set; }
        public int TatlBalanceEmi { get; set; }
    }
}
