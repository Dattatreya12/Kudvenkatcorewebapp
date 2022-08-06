using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kudvenkatcorewebapp.Models.Loan
{
    public class MonthlyLoanInformation
    {
        public int ID { get; set; }
        public string LoanID { get; set; }
        public double MonthEmiAmount { get; set; }
        public int TotalPaidEmi { get; set; }
        public string Month { get; set; }
        public int Year { get; set; }
        public DateTime LoanEndDate { get; set; }
    }
}
