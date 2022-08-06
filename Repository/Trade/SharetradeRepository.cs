using Kudvenkatcorewebapp.DBContext;
using Kudvenkatcorewebapp.Models.Trade;
using Kudvenkatcorewebapp.Utilities.ShresLogic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kudvenkatcorewebapp.Repository.Trade
{
    public class SharetradeRepository : ITradeshare
    {
       
        private readonly AppDbContext appDbContext;
        BuyrateMultyplyWithTotalSharesLogic buyratemultyplywithtotalshares = new BuyrateMultyplyWithTotalSharesLogic();
        public SharetradeRepository(AppDbContext appDbContext)
        {
            
            this.appDbContext = appDbContext;
        }

       

        public Tradeinformation AddITradeinformation(Tradeinformation tradeinformation)
        {
            //double im = sr.TotalInvestedAmountinShares(model.tradeinformation.Stockbuykprice, model.tradeinformation.Stocktotalshares);

            tradeinformation.TotalInvestedAmount = buyratemultyplywithtotalshares.TotalInvestedAmountinShares(tradeinformation.Stockbuykprice, tradeinformation.Stocktotalshares);

           
            appDbContext.tradeinformations.Add(tradeinformation);
              appDbContext.SaveChanges();
             return tradeinformation;
        }

        public Task<Tradeinformation> DeleteITradeinformation(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Tradeinformation>> GetTradeInformationList()
        {
            //IEnumerable<Tradeinformation> brokerlist = await appDbContext.tradeinformations
            //                                           .Where(x => x.Active == 1).ToListAsync();

            //return brokerlist;
            var usages = new List<Tradeinformation>();
            var query = await (from t in appDbContext.tradeinformations
                               join b in appDbContext.brokers on t.brokerid equals b.ID
                               where t.Active == 1
                               select new
                               {
                                   t.Id,
                                   t.Stockname,
                                   t.Stockbuykprice,
                                   t.Stockpurchaseddate,
                                   t.Stockselldate,
                                   t.Stocksellprice,
                                   t.Stocktotalshares,
                                   t.TotalInvestedAmount,
                                   b.BrokerName
                               }).ToListAsync();

            if (query?.Any() == true)
            {
                foreach (var sharesdata in query)
                {
                    usages.Add(new Tradeinformation()
                    {
                        Id=sharesdata.Id,
                        Stockname = sharesdata.Stockname,
                        Stockbuykprice = sharesdata.Stockbuykprice,
                        Stockpurchaseddate = sharesdata.Stockpurchaseddate,
                        Stockselldate = sharesdata.Stockselldate,
                        Stocksellprice = sharesdata.Stocksellprice,
                        Stocktotalshares = sharesdata.Stocktotalshares,
                        TotalInvestedAmount =Math.Round(sharesdata.TotalInvestedAmount,2),
                        BrokerName = sharesdata.BrokerName
                    });
                }
            }
            return usages;
           

        }

        public Task<Tradeinformation> UpdateITradeinformation(Tradeinformation tradeinformation, int id)
        {
            throw new NotImplementedException();
        }

        public double TotalinvestedinAllStocks(int brokerid,string brokername,double investedamount)
        {
            double sum = 0;
            if(brokername== "ZERODHA")
            {
                sum += investedamount;
            }
            else if(brokername== "UPSTOX")
            {
                sum += investedamount;
            }
            else
            {
                sum += investedamount;
            }
            return sum;

        }

        
    }
}
