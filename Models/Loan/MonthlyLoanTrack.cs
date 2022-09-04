using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kudvenkatcorewebapp.Models.Loan
{
    public class MonthlyLoanTrack
    {
        public int ID { get; set; }
        public double MonthlyCollectedAmount { get; set; }
        public double TotalLoan { get; set; }
        public double TotalBalanceAmount { get; set; }
        public string Month { get; set; }
        public int Year { get; set; }
        public double TotalIntrest { get; set; }
        public int Active { get; set; }

        public double HandLoan { get; set; }
    }
}
