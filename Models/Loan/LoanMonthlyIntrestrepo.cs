using AutoMapper;
using Kudvenkatcorewebapp.DBContext;
using Kudvenkatcorewebapp.DTO;
using Kudvenkatcorewebapp.ViewModels.Sangh;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Kudvenkatcorewebapp.Models.Loan
{
    public class LoanMonthlyIntrestrepo : ILoanmonthlyintrestcalculate
    {
        
        // private readonly ILoanmonthlyintrestcalculate _loanmonthlyintrest;
        private readonly AppDbContext _appDbContext;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;

        public LoanMonthlyIntrestrepo( AppDbContext appDbContext,IConfiguration configuration,IMapper mapper)
        {
          
            this._appDbContext = appDbContext;
            this._configuration = configuration;
            this._mapper = mapper;
        }

       

        public async Task<IEnumerable<LoanEmployees>> MonthlyIntrestCalculate()
        {
            var monthlyintrestcalculate = new List<LoanEmployees>();

            using (SqlConnection con = new SqlConnection(_configuration.GetConnectionString("Default")))
            {
                con.Open();
                string sql = "select LoanDate ,sum(TotalIntrest) As TotalIntrest from [dbo].[loanEmployees] " +
                              "group by LoanDate";
                SqlCommand cmd = new SqlCommand(sql, con);
                using (SqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        LoanEmployees loanemp = new LoanEmployees();
                        loanemp.LoanDate = Convert.ToDateTime(sdr["LoanDate"]);
                        loanemp.TotalIntrest = Convert.ToDouble(sdr["TotalIntrest"]);

                        monthlyintrestcalculate.Add(loanemp);
                    }
                }
                con.Close();
            }
             return  monthlyintrestcalculate;

          


        }

        public async Task<IEnumerable<LoanEmployees>> MonthlyIntrestCalculatebyEntityframework()
        {
            var monthlyintrestcalculate = new List<LoanEmployees>();
            try
            {
                //var result1 = from r in _appDbContext.loanEmployees
                //              group r by r.LoanDate into g
                //              select new
                //              {
                //                  loanddate = g.Key,
                //                  Totalloan = g.Sum(x => x.TotalIntrest)

                //              };

                



                var result = await _appDbContext.loanEmployees.GroupBy(x => x.LoanDate)
                    .Select(g => new
                    {
                        loandate = g.Key,
                        TotalIntrest = g.Sum(x => x.TotalIntrest),
                    }).ToListAsync();

                if (result?.Any() == true)
                {
                    foreach (var sharesdata in result)
                    {
                        monthlyintrestcalculate.Add(new LoanEmployees()
                        {

                            TotalIntrest = sharesdata.TotalIntrest,
                            LoanDate = sharesdata.loandate,
                        });
                    }
                }

                return monthlyintrestcalculate;
            }
            catch (Exception ex)
            {
                //ex.Message;
            }

            return monthlyintrestcalculate;
        }

        
    }
}
  