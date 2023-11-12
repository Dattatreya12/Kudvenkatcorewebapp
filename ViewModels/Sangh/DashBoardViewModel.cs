using Kudvenkatcorewebapp.DTO;
using Kudvenkatcorewebapp.Models;
using Kudvenkatcorewebapp.Models.Loan;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Kudvenkatcorewebapp.ViewModels.Sangh
{
    public class DashBoardViewModel
    {
        public int Id { get; set; }
        public List<LoanEmployees> loanEmployees { get; set; }
        public IEnumerable<LoanEmployees> loanEmployeesmonthlyintrestcalculate { get; set; }
        public IEnumerable<MonthlytotlaLoanCount> loanEmployeesmonthlyLoancount { get; set; }
        public List<MonthlyLoanInformation> monthlyLoanInformation { get; set; }
        public List<HandLoan> handLoans { get; set; }
        public List<MonthlyLoanTrack> monthlyLoanTracks { get; set; }
        public double TotalSumofLoan { get; set; }
        public double TotalSumofAmount { get; set; }
        public double TotalSumofHandloanAmount { get; set; }
        public string GetCurrenctMonth { get; set; }
        public double TotalIntrest { get; set; }
        public DateTime LoanDate { get; set; }
        public double TotalLoanAmount { get; set; }
        public int Month { get; set; }
        public string MonthName
        {
            get
            {
                return CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(this.Month);
            }
        }

        
<<<<<<< HEAD

=======
>>>>>>> dk

    }
}
