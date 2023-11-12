using Kudvenkatcorewebapp.DBContext;
using Kudvenkatcorewebapp.Models;
using Kudvenkatcorewebapp.Models.Loan;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kudvenkatcorewebapp.Repository.LoanRepository
{
    public class LoanCrudService : IloanCrudService
    {
        private readonly IloanCrud _iloanCrud;
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;
        private readonly AppDbContext _context;
        public LoanCrudService(IloanCrud iloanCrud, IConfiguration configurtion, AppDbContext context)
        {
            _iloanCrud = iloanCrud;
            _configuration = configurtion;
            _context = context;

        }
        public Task<LoanEmployees> Add(LoanEmployees loanEmployees)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Employee>> GetEmployeeName()
        {
            return await _iloanCrud.GetEmployeeName();
        }

        public async Task<IEnumerable<LoanEmployees>> GetLoanEmployees()
        {
            return await _iloanCrud.GetLoanEmployees();
        }

        public async Task<IEnumerable<MonthlyLoanInformation>> GetLoanInformatiomByLoanID(string LoanID)
        {
            return await _iloanCrud.GetLoanInformatiomByLoanID(LoanID);
        }

        public string RandomLoanIDGenerate()
        {
            return _iloanCrud.RandomLoanIDGenerate();
        }

        
    }
}
