using Kudvenkatcorewebapp.Models;
using Kudvenkatcorewebapp.Models.Loan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kudvenkatcorewebapp.Repository.LoanRepository
{
    public interface IloanCrudService
    {
        Task<LoanEmployees> Add(LoanEmployees loanEmployees);
        Task<IEnumerable<LoanEmployees>> GetLoanEmployees();
        Task<List<Employee>> GetEmployeeName();
        string RandomLoanIDGenerate();
        Task<IEnumerable<MonthlyLoanInformation>> GetLoanInformatiomByLoanID(string LoanID);

    }
}
