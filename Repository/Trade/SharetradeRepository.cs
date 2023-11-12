using Kudvenkatcorewebapp.DBContext;
using Kudvenkatcorewebapp.Extensions;
using Kudvenkatcorewebapp.Models.Trade;
using Kudvenkatcorewebapp.Utilities.ShresLogic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Kudvenkatcorewebapp.Repository.Trade
{
    public class SharetradeRepository : ITradeshare
    {
       
        private readonly AppDbContext appDbContext;
        private readonly IConfiguration _configuration;
        BuyrateMultyplyWithTotalSharesLogic buyratemultyplywithtotalshares = new BuyrateMultyplyWithTotalSharesLogic();
        public SharetradeRepository(AppDbContext appDbContext, IConfiguration configurtion)
        {
            this._configuration = configurtion;
            this.appDbContext = appDbContext;
        }
        public Tradeinformation AddITradeinformation(Tradeinformation tradeinformation)
        {
            //double im = sr.TotalInvestedAmountinShares(model.tradeinformation.Stockbuykprice, model.tradeinformation.Stocktotalshares);

            tradeinformation.TotalInvestedAmount = buyratemultyplywithtotalshares.TotalInvestedAmountinShares(tradeinformation.Stockbuykprice, tradeinformation.Stocktotalshares);
            appDbContext.tradeinformations.Add(tradeinformation);
            appDbContext.SaveChanges();
            string action = "Insert";

            using (SqlConnection con = new SqlConnection(_configuration.GetConnectionString("Default")))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                       // string MN = DateTimeExtensions.ToMonthName;
                        //cmd.CommandType = CommandType.Text
                        cmd.Connection = con;
                        cmd.Parameters.Clear();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "SP_ExtraQuantityAddedinStocks"; // Store procediure name

                        if (action == "Insert")
                        {
                            cmd.Parameters.AddWithValue("@stockid", tradeinformation.Id);
                            cmd.Parameters.AddWithValue("@BuyPrice", tradeinformation.Stockbuykprice);
                            cmd.Parameters.AddWithValue("@TotalShare", tradeinformation.Stocktotalshares);
                            cmd.Parameters.AddWithValue("@TotalInvestment", tradeinformation.TotalInvestedAmount);
                            cmd.Parameters.AddWithValue("@Month", DateTime.Now.ToMonthName());
                            cmd.Parameters.AddWithValue("@Year",DateTime.Now.Year);
                            cmd.Parameters.AddWithValue("@Active", 1);
                            cmd.Parameters.AddWithValue("@action", "Insert");
                        }
                        else if (action == "Update")
                        {
                            //cmd.CommandText = "UPDATE Customers SET NAME = @Name,Country = @Country WHERE CustomerId = @Id";
                            //cmd.Parameters.AddWithValue("@Id", customer.Id);
                            //cmd.Parameters.AddWithValue("@Name", customer.Name);
                            //cmd.Parameters.AddWithValue("@Country", customer.Country);
                        }
                        else if (action == "Delete")
                        {
                            //cmd.CommandText = "DELETE FROM Customers WHERE CustomerId = @Id";
                            //cmd.Parameters.AddWithValue("@Id", customer.Id);
                        }
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }

                   
                }
            }
            return tradeinformation;
        }

        public Task<Tradeinformation> DeleteITradeinformation(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Tradeinformation>> GetTradeInformationList(string stockname)
        {
            //IEnumerable<Tradeinformation> brokerlist = await appDbContext.tradeinformations
            //                                           .Where(x => x.Active == 1).ToListAsync();

            //return brokerlist;
            var usages = new List<Tradeinformation>();
            DateTime dt = DateTime.Now;
            if (stockname != null && stockname != string.Empty)
            {
                var query = await (from t in appDbContext.tradeinformations
                                   join b in appDbContext.brokers on t.brokerid equals b.ID
                                   where t.Active == 1 && t.Stockname.Contains(stockname)
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
                            Id = sharesdata.Id,
                            Stockname = sharesdata.Stockname,
                            Stockbuykprice = Math.Round(sharesdata.Stockbuykprice, 2),
                            Stockpurchaseddate = sharesdata.Stockpurchaseddate,
                            Stockselldate = sharesdata.Stockselldate,
                            Stocksellprice = sharesdata.Stocksellprice,
                            Stocktotalshares = sharesdata.Stocktotalshares,
                            TotalInvestedAmount = Math.Round(sharesdata.TotalInvestedAmount, 2),
                            BrokerName = sharesdata.BrokerName
                        });
                    }
                }
                return usages;
            }
<<<<<<< HEAD
=======

            else
            {

                
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
                            Id = sharesdata.Id,
                            Stockname = sharesdata.Stockname,
                            Stockbuykprice = Math.Round(sharesdata.Stockbuykprice, 2),
                            Stockpurchaseddate = sharesdata.Stockpurchaseddate,
                            Stockselldate = sharesdata.Stockselldate,
                            Stocksellprice = sharesdata.Stocksellprice,
                            Stocktotalshares = sharesdata.Stocktotalshares,
                            TotalInvestedAmount = Math.Round(sharesdata.TotalInvestedAmount, 2),
                            BrokerName = sharesdata.BrokerName
                        });
                    }
                }
                return usages;
            }
            //return usages;
           
>>>>>>> dk

            else
            {

                
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
                            Id = sharesdata.Id,
                            Stockname = sharesdata.Stockname,
                            Stockbuykprice = Math.Round(sharesdata.Stockbuykprice, 2),
                            Stockpurchaseddate = sharesdata.Stockpurchaseddate,
                            Stockselldate = sharesdata.Stockselldate,
                            Stocksellprice = sharesdata.Stocksellprice,
                            Stocktotalshares = sharesdata.Stocktotalshares,
                            TotalInvestedAmount = Math.Round(sharesdata.TotalInvestedAmount, 2),
                            BrokerName = sharesdata.BrokerName
                        });
                    }
                }
                return usages;
            }
            //return usages;
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
