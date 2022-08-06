using Kudvenkatcorewebapp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kudvenkatcorewebapp.Models.Loan
{
    public interface ILoanmonthlyintrestcalculate
    {
       
        Task<IEnumerable<LoanEmployees>> MonthlyIntrestCalculate();
        Task<IEnumerable<LoanEmployees>> MonthlyIntrestCalculatebyEntityframework();
        //Task<List<LoanEmployeesDTO>> MonthlyIntrestCalculatebyEntityframework();
        
    }
}
