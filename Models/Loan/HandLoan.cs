using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kudvenkatcorewebapp.Models.Loan
{
    public class HandLoan
    {
        public int ID { get; set; }
        public int HandLoanId { get; set; }
        public double HandLoanAmount { get; set; }
        public string Month { get; set; }
        public int Year { get; set; }
        public int EmployeeId { get; set; }
        public string LoanUserName { get; set; }

        public ICollection<Employee> employeesname { get; set; }
        //Migration AddedColumnintoHandLoanActive
        public int Active { get; set; }

        public double TotalIntrest { get; set; }
       
    }
}
