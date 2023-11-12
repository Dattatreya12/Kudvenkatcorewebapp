﻿using AutoMapper;
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
        public async Task<IEnumerable<MonthlytotlaLoanCount>> MonthlyIntrestCalculate()
        {
            var monthlyintrestcalculate = new List<MonthlytotlaLoanCount>();
            var data = _appDbContext.loanEmployees.Select(k => new { k.LoanDate.Year, k.LoanDate.Month, k.Id }).GroupBy(x => new { x.Year, x.Month }, (key, group) => new
            {
                year =  key.Year,
                mnth = key.Month,
                tCharge = group.Count()


            }).ToList().OrderByDescending(x => x.year).ThenByDescending(x => x.mnth).Take(5);
            if (data?.Any() == true)
            {
                foreach (var sharesdata in data)
                {
                    monthlyintrestcalculate.Add(new MonthlytotlaLoanCount()
                    {

                        year = sharesdata.year,
                        month = sharesdata.mnth,
                        toatlloancountmonthly = sharesdata.tCharge,

                    });
                }
            }
            return monthlyintrestcalculate;
        }
        public async Task<IEnumerable<LoanEmployees>> MonthlyIntrestCalculatebyEntityframework()
        {
            var monthlyintrestcalculate = new List<LoanEmployees>();
            try
            {
                //var result = await _appDbContext.loanEmployees.GroupBy(x => x.LoanDate)
                var dt = "10/11/2023";
                     var result = await _appDbContext.loanEmployees.Where(x=>x.LoanDate>=Convert.ToDateTime(dt)).GroupBy(x => x.LoanDate)
                    .Select(g => new
                    {
                        loandate = g.Key,
                        TotalIntrest = g.Sum(x => x.TotalIntrest),
                    }).OrderByDescending(x=>x.loandate.Year).ToListAsync();

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
  