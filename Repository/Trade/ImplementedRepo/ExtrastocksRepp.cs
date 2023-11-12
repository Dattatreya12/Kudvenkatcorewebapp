using Kudvenkatcorewebapp.DBContext;
using Kudvenkatcorewebapp.Models.Trade;
using Kudvenkatcorewebapp.Repository.Trade.InterfaceRepo;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Kudvenkatcorewebapp.Repository.Trade.ImplementedRepo
{
    public class ExtrastocksRepp : IextraStocks
    {
        private readonly AppDbContext _appDbContext;
        private readonly IConfiguration _configuration;
        public ExtrastocksRepp(AppDbContext appDbContext, IConfiguration configurtion)
        {
            this._appDbContext = appDbContext;
            this._configuration = configurtion;
        }

        public async Task<IEnumerable<ExtraQuantityAddedinStocks>> Getsearchcountofstocks(int stockcount)
        {
            var ExtraStocks = new List<ExtraQuantityAddedinStocks>();
            var query = await(from t in _appDbContext.ExtraQuantityAddedinStocks
                              join trade in _appDbContext.tradeinformations on t.stockid equals trade.Id
                              join br in _appDbContext.brokers on t.brokerid equals br.ID
                              where t.Active == 1 
                              orderby t.Month descending

                              select new
                              {
                                  br.BrokerName,
                                  trade.Stockname,
                                  t.BuyPrice,
                                  t.TotalShare,
                                  t.TotalInvestment,
                                  t.Month,
                                  t.Year,
                              }).ToListAsync();

            if (query?.Any() == true)
            {
                foreach (var sharesdata in query)
                {
                    ExtraStocks.Add(new ExtraQuantityAddedinStocks()
                    {
                        BrokerName = sharesdata.BrokerName,
                        StockName = sharesdata.Stockname,
                        BuyPrice = sharesdata.BuyPrice,
                        TotalShare = sharesdata.TotalShare,
                        TotalInvestment = sharesdata.TotalInvestment,
                        Month = sharesdata.Month,
                        Year = sharesdata.Year,
                    });
                }
            }
            return ExtraStocks;
        }
        public async Task<IEnumerable<ExtraQuantityAddedinStocks>> GetTradeInformationList(int count)
        {
            if (count == 1)
            {
                try
                {
                    var ExtraStocks = new List<ExtraQuantityAddedinStocks>();
                    var query = await (from t in _appDbContext.ExtraQuantityAddedinStocks
                                       join trade in _appDbContext.tradeinformations on t.stockid equals trade.Id
                                       join br in _appDbContext.brokers on t.brokerid equals br.ID
                                       where t.Active == 1
                                       orderby t.Month descending
                                       select new
                                       {
                                           br.BrokerName,
                                           trade.Stockname,
                                           t.BuyPrice,
                                           t.TotalShare,
                                           t.TotalInvestment,
                                           t.Month,
                                           t.Year,
                                       }).OrderByDescending(x => x.Month).Take(5).ToListAsync();

                    if (query?.Any() == true)
                    {
                        foreach (var sharesdata in query)
                        {
                            ExtraStocks.Add(new ExtraQuantityAddedinStocks()
                            {
                                BrokerName = sharesdata.BrokerName,
                                StockName = sharesdata.Stockname,
                                BuyPrice = sharesdata.BuyPrice,
                                TotalShare = sharesdata.TotalShare,
                                TotalInvestment = sharesdata.TotalInvestment,
                                Month = sharesdata.Month,
                                Year = sharesdata.Year,
                            });
                        }
                    }
                    return ExtraStocks;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
               
            }

           else
            {
                try
                {
                    var ExtraStockscount = new List<ExtraQuantityAddedinStocks>();
                    var query = await (from t in _appDbContext.ExtraQuantityAddedinStocks
                                       join trade in _appDbContext.tradeinformations on t.stockid equals trade.Id
                                       join br in _appDbContext.brokers on t.brokerid equals br.ID
                                       where t.Active == 1
                                       orderby t.Month descending
                                       select new
                                       {
                                           br.BrokerName,
                                           trade.Stockname,
                                           t.BuyPrice,
                                           t.TotalShare,
                                           t.TotalInvestment,
                                           t.Month,
                                           t.Year,
                                       }).OrderByDescending(x => x.Month).ToListAsync();

                    if (query?.Any() == true)
                    {
                        foreach (var sharesdata in query)
                        {
                            ExtraStockscount.Add(new ExtraQuantityAddedinStocks()
                            {
                                BrokerName = sharesdata.BrokerName,
                                StockName = sharesdata.Stockname,
                                BuyPrice = sharesdata.BuyPrice,
                                TotalShare = sharesdata.TotalShare,
                                TotalInvestment = sharesdata.TotalInvestment,
                                Month = sharesdata.Month,
                                Year = sharesdata.Year,
                            });
                        }
                    }
                    return ExtraStockscount;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
           
        }

        public async Task<IEnumerable<ExtraQuantityAddedinStocks>> InvestmentYearWise()
        {
            var TotalInvestedInYear = new List<ExtraQuantityAddedinStocks>();
            //var dt = "10/11/2022";
            var result = await _appDbContext.ExtraQuantityAddedinStocks.Where(x => x.Year >2022).GroupBy(x => x.Year)
           .Select(g => new
           {
               invested = g.Key,
               TotalInvested = g.Sum(x => x.TotalInvestment),
           }).ToListAsync();

            if (result?.Any() == true)
            {
                foreach (var sharesdata in result)
                {
                    TotalInvestedInYear.Add(new ExtraQuantityAddedinStocks()
                    {

                        TotalInvestment = sharesdata.TotalInvested,
                        //LoanDate = sharesdata.loandate,
                    });
                }
            }
            return TotalInvestedInYear;
        }


      


    }
}
