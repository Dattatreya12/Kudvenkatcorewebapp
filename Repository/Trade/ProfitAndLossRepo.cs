using Kudvenkatcorewebapp.DBContext;
using Kudvenkatcorewebapp.Models.Trade;
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
    public class ProfitAndLossRepo : IProfitLoss
    {
        private readonly AppDbContext appDbContext;
        private readonly IConfiguration _configuration;

        public ProfitAndLossRepo(AppDbContext appDbContext, IConfiguration configuration)
        {

            this.appDbContext = appDbContext;
            this._configuration = configuration;
        }

        public void AddUpdateDeleteCustomer(Total_profit_loss profit_Loss, string action)
        {

            using (SqlConnection con = new SqlConnection(_configuration.GetConnectionString("Default")))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        cmd.Parameters.Clear();
                        if (action == "Insert")
                        {
                            //DateTime d = Convert.ToDateTime(loanEmployees.LoanDate);
                            //string en = loanEmployees.employeesname.ToString();

                            cmd.CommandText = "INSERT INTO TotalProfiLoss(Profit,Loss,Totalprofit,Totalloss,Year)VALUES (@Profit,@Loss,@Totalprofit,@Totalloss,@Year)";
                            cmd.Parameters.AddWithValue("@Profit", profit_Loss.Profit);
                            cmd.Parameters.AddWithValue("@Loss", profit_Loss.Loss);
                            cmd.Parameters.AddWithValue("@Totalprofit", profit_Loss.Totalprofit);
                            cmd.Parameters.AddWithValue("@Totalloss", profit_Loss.Totalloss);
                            cmd.Parameters.AddWithValue("@Year", profit_Loss.Year);

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
        }

        public async Task<Total_profit_loss> GetListofProfitAndLoss()
        {
            Total_profit_loss tpl = new Total_profit_loss();
            //var result = table.OrderByDescending(x => x.Status).First();
            var result = appDbContext.TotalProfiLoss.Select(x => new Total_profit_loss()
            {
                ID=x.ID,
                Totalprofit=x.Totalprofit,
                Totalloss=x.Totalloss,
            }).OrderByDescending(x=>x.ID).FirstOrDefault();
            //var records = await appDbContext.TotalProfiLoss.Select(x => new Total_profit_loss()
            //{
            //    ID = x.ID,
            //    Profit = x.Profit,
            //    Loss = x.Loss,
            //    Year = x.Year,
            //    Totalprofit = x.Totalprofit,
            //    Totalloss = x.Totalloss,
            //}).ToListAsync();
           
            if (result==null)
            {
                DateTime currentyear = DateTime.Now;
                tpl.Totalprofit = 00.00;
                tpl.Totalloss = 00.00;
                tpl.Year = Convert.ToInt32(currentyear.ToString("yyyy"));
                return tpl;
            }
            
            return result;
            
        }

        
       
    }
}
