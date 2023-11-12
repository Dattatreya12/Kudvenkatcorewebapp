using Kudvenkatcorewebapp.DBContext;
using Kudvenkatcorewebapp.Models.Loan;
using Kudvenkatcorewebapp.Models.Trade;
using Kudvenkatcorewebapp.ViewModels.Trade;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Kudvenkatcorewebapp.Repository.Trade
{
    public class BrokerRepository : IBrokerRepository
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;
        private readonly AppDbContext context;
        

        public BrokerRepository(IConfiguration configurtion, AppDbContext context)
        {
            this.context = context;
            this._configuration = configurtion;
           
        }
        public async Task<Broker> Add(Broker broker)
        {
            await context.brokers.AddAsync(broker);
            context.SaveChanges();
            return broker;
        }

        

        public async Task<List<Broker>> GetAllBrokerList()
        {
            return await context.brokers.Select(x => new Broker()
            {
                ID = x.ID,
                BrokerName = x.BrokerName
            }).ToListAsync();
         }
        public async Task<IEnumerable<Broker>> GetAllBrokerListusingIenumerable()
        {
            //IEnumerable<Broker> brokerlist = await context.brokers.ToListAsync();
            IEnumerable<Broker> brokerlist = await context.brokers.Where(x => x.Active == 1).ToListAsync();
            return brokerlist;
        }

        public async Task<IEnumerable<Tradeinformation>> GetAllstockListusingIenumerable()
        {
            //IEnumerable<Broker> brokerlist = await context.brokers.ToListAsync();
            IEnumerable<Tradeinformation> stocklist = await context.tradeinformations.Where(x => x.Active == 1).ToListAsync();
            return stocklist;
        }

        //public int AddExtraQuantity(BrokerTradeViewModel brokerTradeViewModel)
        //{
        //    throw new NotImplementedException();
        //}

        public int AddExtraQuantity(ExtraQuantityAddedinStocks extraQuantityAddedinStocks, string action)
        {
            int i;
            //BuyrateMultyplyWithTotalSharesLogic totalintrestlogic = new BuyrateMultyplyWithTotalSharesLogic();
            //loanEmployees.TotalIntrest = totalintrestlogic.TotalIntrest(loanEmployees.TotalLoanAmount, loanEmployees.TotalEmi);
            using (SqlConnection con = new SqlConnection(_configuration.GetConnectionString("Default")))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        //cmd.CommandType = CommandType.Text
                        cmd.Connection = con;
                        cmd.Parameters.Clear();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "SP_ExtraQuantityAddedinStocks"; // Store procediure name

                        if (action == "Insert")
                        {
                            // DateTime d = Convert.ToDateTime(extraQuantityAddedinStocks.LoanDate);
                            //string en = loanEmployees.employeesname.ToString();

                            //cmd.CommandText = "INSERT INTO loanEmployees(EmployeeId,LoanID,TotalLoanAmount,TotalEmi,LoanDate,TotalIntrest,Active,LoanUserName)VALUES (@EmployeeId,@LoanID,@TotalLoanAmount,@TotalEmi,@LoanDate,@TotalIntrest,@Active,@LoanUserName)";
                            cmd.Parameters.AddWithValue("@brokerid", extraQuantityAddedinStocks.brokerid);
                            cmd.Parameters.AddWithValue("@stockid", extraQuantityAddedinStocks.stockid);
                            cmd.Parameters.AddWithValue("@BuyPrice", extraQuantityAddedinStocks.BuyPrice);
                            cmd.Parameters.AddWithValue("@TotalShare", extraQuantityAddedinStocks.TotalShare);
                            cmd.Parameters.AddWithValue("@TotalInvestment", extraQuantityAddedinStocks.TotalInvestment);
                            cmd.Parameters.AddWithValue("@Month", extraQuantityAddedinStocks.Month);
                            cmd.Parameters.AddWithValue("@Year", extraQuantityAddedinStocks.Year);
                            cmd.Parameters.AddWithValue("@Active", 1);
                            cmd.Parameters.AddWithValue("@action", "Insert");
                            // cmd.Parameters.AddWithValue("@LoanUserName", "null");
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
                        i = cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }

                    return i;
                }
            }
        }

        public int AddProfitandLoss(AddProfitLoss addProfitLoss , string action)
        {
            int i;
            //BuyrateMultyplyWithTotalSharesLogic totalintrestlogic = new BuyrateMultyplyWithTotalSharesLogic();
            //loanEmployees.TotalIntrest = totalintrestlogic.TotalIntrest(loanEmployees.TotalLoanAmount, loanEmployees.TotalEmi);
            using (SqlConnection con = new SqlConnection(_configuration.GetConnectionString("Default")))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        //cmd.CommandType = CommandType.Text
                        cmd.Connection = con;
                        cmd.Parameters.Clear();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "SP_AddProfitLoss"; // Store procediure name

                        if (action == "InsertProfitLoss")
                        {
                            // DateTime d = Convert.ToDateTime(extraQuantityAddedinStocks.LoanDate);
                            //string en = loanEmployees.employeesname.ToString();

                            //cmd.CommandText = "INSERT INTO loanEmployees(EmployeeId,LoanID,TotalLoanAmount,TotalEmi,LoanDate,TotalIntrest,Active,LoanUserName)VALUES (@EmployeeId,@LoanID,@TotalLoanAmount,@TotalEmi,@LoanDate,@TotalIntrest,@Active,@LoanUserName)";
                           
                            cmd.Parameters.AddWithValue("@Option", addProfitLoss.Option);
                            cmd.Parameters.AddWithValue("@IncomeLoss", addProfitLoss.IncomeLoss);
                            cmd.Parameters.AddWithValue("@Createat", addProfitLoss.Createat);
                            cmd.Parameters.AddWithValue("@Active", 1);
                            cmd.Parameters.AddWithValue("@action", "InsertProfitLoss");
                            // cmd.Parameters.AddWithValue("@LoanUserName", "null");
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
                        i = cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }

                    return i;
                }
            }
        }

        
    }
}
