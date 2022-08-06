using Kudvenkatcorewebapp.DBContext;
using Kudvenkatcorewebapp.Models.Trade;
using Kudvenkatcorewebapp.Repository.Trade.InterfaceRepo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kudvenkatcorewebapp.Repository.Trade.ImplementedRepo
{
    public class ExtrastocksRepp : IextraStocks
    {
        private readonly AppDbContext _appDbContext;

        public ExtrastocksRepp(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }
        public async Task<IEnumerable<ExtraQuantityAddedinStocks>> GetTradeInformationList()
        {
            var ExtraStocks = new List<ExtraQuantityAddedinStocks>();
            var query = await(from t in _appDbContext.ExtraQuantityAddedinStocks where t.Active==1
                              
                              select new
                              {
                                 t.BrokerName,
                                 t.StockName,
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
                        StockName = sharesdata.StockName,
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
    }
}
