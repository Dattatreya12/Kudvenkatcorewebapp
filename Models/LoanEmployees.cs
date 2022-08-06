using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kudvenkatcorewebapp.Models
{
    public class LoanEmployees
    {
        public int Id { get; set; }
        [Required]
        public string LoanID { get; set; }
        [Required]
        public int TotalLoanAmount { get; set;}
        public int TotalEmi { get; set; }
        [Required]
        public double TotalIntrest { get; set;}
        public int Active { get; set; }
        public DateTime LoanDate { get; set;}
        public int EmployeeId { get; set; }
        public string LoanUserName { get; set; }
        public string LoanStatus { get; set; }
        public ICollection<Employee> employeesname { get; set; }
        //Adding 07-07-2022 below 2 columns
        public int TotalPaidEmi { get; set; }
        public int TatlBalanceEmi { get; set; }
       

    }
}
