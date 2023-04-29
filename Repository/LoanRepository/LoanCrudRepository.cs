using Kudvenkatcorewebapp.DBContext;
using Kudvenkatcorewebapp.Models;
using Kudvenkatcorewebapp.Models.Loan;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kudvenkatcorewebapp.Repository.LoanRepository
{
    public class LoanCrudRepository : IloanCrud
    {
        private readonly IConfiguration _configurtion;
        private readonly AppDbContext _context;

        public LoanCrudRepository(IConfiguration configurtion, AppDbContext context)
        {
            this._configurtion = configurtion;
            this._context = context;
        }
        public Task<LoanEmployees> Add(LoanEmployees loanEmployees)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Employee>> GetEmployeeName()
        {
            return await _context.employees.Select(x => new Employee()
            {
                Id = x.Id,
                Name = x.Name
            }).ToListAsync();


        }

        public async Task<IEnumerable<LoanEmployees>> GetLoanEmployees()
        {
            var usages = new List<LoanEmployees>();
            var result = await (from loanuser in _context.loanEmployees
                          join employee in _context.employees on loanuser.EmployeeId equals employee.Id
                          where loanuser.Active == 1
                          select new
                          {
                              loanId = loanuser.LoanID,
                              name = employee.Name,
                              TotalloanAmount = loanuser.TotalLoanAmount,
                              totalemi = loanuser.TotalEmi,
                              totalintrest = loanuser.TotalIntrest,
                              loandate = loanuser.LoanDate,
                              Status=loanuser.LoanStatus,
                            
                              //TotalLoanAmount = Totalmonthlyamount,
                              TotalPaidEmi = loanuser.TotalPaidEmi,
                              TatlBalanceEmi = loanuser.TatlBalanceEmi,
                              //LoanDate = loanuser.LoanDate,
                          }).ToListAsync();

            if (result?.Any() == true)
            {
                foreach (var sharesdata in result)
                {
                    usages.Add(new LoanEmployees()
                    {
                        LoanID=sharesdata.loanId,
                        LoanUserName = sharesdata.name,
                        TotalLoanAmount=sharesdata.TotalloanAmount,
                        TotalEmi=sharesdata.totalemi,
                        TotalIntrest=sharesdata.totalintrest,
                        LoanDate=sharesdata.loandate,
                        LoanStatus=sharesdata.Status,
                        TotalPaidEmi = sharesdata.TotalPaidEmi,
                        TatlBalanceEmi = sharesdata.TatlBalanceEmi,

                    });
                }
            }
            return usages;


        }

        public async Task<IEnumerable<MonthlyLoanInformation>> GetLoanInformatiomByLoanID(string LoanID)
        {
            var usages = new List<MonthlyLoanInformation>();
            var result = await(from loanuser in _context.loanEmployees
                               join MonthlyLoanInformation in _context.MonthlyloanInformation on loanuser.LoanID equals MonthlyLoanInformation.LoanID
                               where loanuser.LoanID == LoanID
                               select new
                               {
                                   loanId = loanuser.LoanID,
                                   EmiAmount = MonthlyLoanInformation.MonthEmiAmount,
                                   TotalEmi = MonthlyLoanInformation.TotalPaidEmi,
                                   LoanDate = MonthlyLoanInformation.LoanEndDate,
                                   month = MonthlyLoanInformation.Month,
                                   year = MonthlyLoanInformation.Year
                                  
                               }).ToListAsync();

            if (result?.Any() == true)
            {
                foreach (var sharesdata in result)
                {
                    usages.Add(new MonthlyLoanInformation()
                    {
                        LoanID = sharesdata.loanId,
                        MonthEmiAmount = sharesdata.EmiAmount,
                        TotalPaidEmi = sharesdata.TotalEmi,
                        LoanEndDate = sharesdata.LoanDate,
                        Month = sharesdata.month,
                        Year = sharesdata.year
                    });
                }
            }
            return usages;
        }

        public string RandomLoanIDGenerate()
        {
            Random r = new Random();
            string genRand = r.Next(100, 1000).ToString();
            //Console.WriteLine("Random Number = " + genRand);
            return genRand;
        }
    }
}
