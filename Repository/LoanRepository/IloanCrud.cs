using Kudvenkatcorewebapp.DBContext;
using Kudvenkatcorewebapp.Models;
using Kudvenkatcorewebapp.Models.Loan;
using Kudvenkatcorewebapp.ViewModels.Sangh;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kudvenkatcorewebapp.Repository.LoanRepository
{
    public interface IloanCrud
    {
        Task<LoanEmployees> Add(LoanEmployees loanEmployees);
        Task<IEnumerable<LoanEmployees>> GetLoanEmployees();
        Task<List<Employee>> GetEmployeeName();
        string RandomLoanIDGenerate();
        Task<IEnumerable<MonthlyLoanInformation>> GetLoanInformatiomByLoanID(string LoanID);
    }
   
}
