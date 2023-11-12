using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Kudvenkatcorewebapp.DBContext;
using Kudvenkatcorewebapp.Helpers;
using Kudvenkatcorewebapp.Models.Trade;
using Kudvenkatcorewebapp.Repository.LoanRepository;
using Kudvenkatcorewebapp.Repository.Trade;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Kudvenkatcorewebapp.Controllers
{
    public class StockAdminController : Controller
    {
        public const string V = "Data saved successfully";
       
        private readonly IProfitLoss _profitLoss;
        private readonly IConfiguration _configuration;
        private readonly AppDbContext _context;
        private readonly IBrokerRepository _brokerRepository;
        private readonly ITradeshare _tradeinformation;
        private readonly IConfiguration _configurtion;

        public StockAdminController(IProfitLoss profitLoss, IConfiguration configuration, AppDbContext context, IBrokerRepository brokerRepository, ITradeshare tradeinformation, IConfiguration configurtion)
        {
            this._profitLoss = profitLoss;
            this._configuration = configuration;
            this._context = context;
            this._brokerRepository = brokerRepository;
            this._tradeinformation = tradeinformation;
            this._configurtion = configurtion;
        }
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddCustomer()
        {
            ViewBag.Name = "Add";
            Total_profit_loss profitloss = new Total_profit_loss();
            return PartialView("_InsertStockProfitLoss", profitloss);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(Total_profit_loss profit_Loss)
        {

            Total_profit_loss total_Profit_Losses = await _profitLoss.GetListofProfitAndLoss();

            // profit_Loss.Totalprofit = total_Profit_Losses.Totalprofit + profit_Loss.Profit;
            //profit_Loss.Totalloss = total_Profit_Losses.Totalloss + profit_Loss.Loss;

            profit_Loss.Totalprofit = GenericsLogic.Add<double>(total_Profit_Losses.Totalprofit, profit_Loss.Profit);
            profit_Loss.Totalloss = GenericsLogic.Sub<double>(total_Profit_Losses.Totalloss, profit_Loss.Loss);
            _profitLoss.AddUpdateDeleteCustomer(profit_Loss, "Insert");
            return RedirectToAction("Index");
               //  return RedirectToAction("AddCustomer");
        }

        public IActionResult AvgExtraQuantityDisplay()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> AddAvgExtraQuantity()
        {
            ViewBag.brokerlist = new SelectList(await _brokerRepository.GetAllBrokerListusingIenumerable(), "ID", "BrokerName");
            ViewBag.tradelist = new SelectList(await _brokerRepository.GetAllstockListusingIenumerable(), "Id", "Stockname");
            return View();
        }

        [HttpPost]
        public IActionResult AddAvgExtraQuantity(ExtraQuantityAddedinStocks extraQuantityAddedinStocks)
        {
            int i=_brokerRepository.AddExtraQuantity(extraQuantityAddedinStocks, "Insert");
            if (i > 0 || i<0)
            {
                int sngid = 1;

                ViewBag.message = sngid;
                ViewBag.Result = "Saved Succesfully";

                return View();
            }
            else
            {
                int sngid = 2;

                ViewBag.message = sngid;
            }
            return View();
        }

        //public int AddExtraQuantity(ExtraQuantityAddedinStocks extraQuantityAddedinStocks, string action)
        //{
        //    int i;
        //    //BuyrateMultyplyWithTotalSharesLogic totalintrestlogic = new BuyrateMultyplyWithTotalSharesLogic();
        //    //loanEmployees.TotalIntrest = totalintrestlogic.TotalIntrest(loanEmployees.TotalLoanAmount, loanEmployees.TotalEmi);
        //    using (SqlConnection con = new SqlConnection(_configurtion.GetConnectionString("Default")))
        //    {
        //        using (SqlCommand cmd = new SqlCommand())
        //        {
        //            try
        //            {
        //                //cmd.CommandType = CommandType.Text;
        //                cmd.Connection = con;
        //                cmd.Parameters.Clear();
        //                cmd.CommandType = CommandType.StoredProcedure;
        //                cmd.CommandText = "SP_ExtraQuantityAddedinStocks"; // Store procediure name

        //                if (action == "Insert")
        //                {
        //                   // DateTime d = Convert.ToDateTime(extraQuantityAddedinStocks.LoanDate);
        //                    //string en = loanEmployees.employeesname.ToString();

        //                    //cmd.CommandText = "INSERT INTO loanEmployees(EmployeeId,LoanID,TotalLoanAmount,TotalEmi,LoanDate,TotalIntrest,Active,LoanUserName)VALUES (@EmployeeId,@LoanID,@TotalLoanAmount,@TotalEmi,@LoanDate,@TotalIntrest,@Active,@LoanUserName)";
        //                    cmd.Parameters.AddWithValue("@brokerid", extraQuantityAddedinStocks.brokerid);
        //                    cmd.Parameters.AddWithValue("@stockid", extraQuantityAddedinStocks.stockid);
        //                    cmd.Parameters.AddWithValue("@BuyPrice", extraQuantityAddedinStocks.BuyPrice);
        //                    cmd.Parameters.AddWithValue("@TotalShare", extraQuantityAddedinStocks.TotalShare);
        //                    cmd.Parameters.AddWithValue("@TotalInvestment", extraQuantityAddedinStocks.TotalInvestment);
        //                    cmd.Parameters.AddWithValue("@Month", extraQuantityAddedinStocks.Month);
        //                    cmd.Parameters.AddWithValue("@Year", extraQuantityAddedinStocks.Year);
        //                    cmd.Parameters.AddWithValue("@Active", 1);
        //                    cmd.Parameters.AddWithValue("@action", "Insert");
        //                    // cmd.Parameters.AddWithValue("@LoanUserName", "null");
        //                }
        //                else if (action == "Update")
        //                {
        //                    //cmd.CommandText = "UPDATE Customers SET NAME = @Name,Country = @Country WHERE CustomerId = @Id";
        //                    //cmd.Parameters.AddWithValue("@Id", customer.Id);
        //                    //cmd.Parameters.AddWithValue("@Name", customer.Name);
        //                    //cmd.Parameters.AddWithValue("@Country", customer.Country);
        //                }
        //                else if (action == "Delete")
        //                {
        //                    //cmd.CommandText = "DELETE FROM Customers WHERE CustomerId = @Id";
        //                    //cmd.Parameters.AddWithValue("@Id", customer.Id);
        //                }
        //                con.Open();
        //                 i=cmd.ExecuteNonQuery();
        //                con.Close();
        //            }
        //            catch (Exception e)
        //            {
        //                throw e;
        //            }

        //            return i;
        //        }
        //    }
        //}

        //[HttpGet]
        public async Task<IActionResult> DiviidendInfoList()
        {
            //ViewBag.brokerlist = new SelectList(await _brokerRepository.GetAllBrokerListusingIenumerable(), "ID", "BrokerName");
            ViewBag.tradelist = new SelectList(await _brokerRepository.GetAllstockListusingIenumerable(), "Id", "Stockname");
            return View();

        }

        [HttpGet]
        public async Task<JsonResult> DiviidendInfoListRead()
        {
            var usages = new List<Dividend_info>();
            //var list_of_dividend_data = _context.dividend_Infos.ToList();
            var query =await (from d in _context.dividend_Infos
                                        join t in _context.tradeinformations on d.stockid equals t.Id
                                        select new
                                        {
                                            t.Stockname,
                                            d.dividendAmount,
                                            d.year,
                                            d.stockid
                                        }).ToListAsync();

            if(query?.Any() == true)
            {
                foreach (var sharesdata in query)
                {
                    usages.Add(new Dividend_info()
                    {
                        
                        stockname =sharesdata.Stockname,
                        dividendAmount = sharesdata.dividendAmount,
                         year= sharesdata.year
                    });
                }
            }
            return new  JsonResult(usages);

        }

        //Adding dividend Amount
        [HttpPost]
        public JsonResult AddDividend(Dividend_info di)
        {
            var datasave = new Dividend_info()
            {
                stockid =Convert.ToInt32( di.stockname),
                dividendAmount = di.dividendAmount,
                year = di.year
            };
            if (datasave.stockid == 0 || datasave.dividendAmount == 0.0 || datasave.year == 0)
            {
                return new JsonResult(new { success = false, message = "your request has been Not submitted" });
            }
            else
            {
                _context.dividend_Infos.AddAsync(datasave);
                _context.SaveChangesAsync();
            }
            return new JsonResult(new { success = true, message = "your request has been submitted successfully" }); 
        }

        [HttpPost]
        public JsonResult Addextrastock(ExtraQuantityAddedinStocks extraQuantityAddedinStocks)
        {
           if(extraQuantityAddedinStocks.stockid==0 || extraQuantityAddedinStocks.brokerid==0|| extraQuantityAddedinStocks.BuyPrice==0||extraQuantityAddedinStocks.TotalShare==0||extraQuantityAddedinStocks.Month==""||extraQuantityAddedinStocks.TotalInvestment==0)
            {
                return new JsonResult(new { success = false, message = "Fill the all fields" });
            }
            int i = _brokerRepository.AddExtraQuantity(extraQuantityAddedinStocks, "Insert");
            if (i > 0 || i < 0)
            {
                int sngid = 1;

                ViewBag.message = sngid;
                ViewBag.Result = "Saved Succesfully";
                return new JsonResult(new { success = true, message = "your request has been submitted" });
            }
            else
            {
                int sngid = 2;
                ViewBag.message = sngid;
            }
            return new JsonResult(new { success = true, message = "your request has been submitted" });

        }


        [HttpGet]
        public async Task<IActionResult> Addextrastock()
        {
            ViewBag.brokerlist = new SelectList(await _brokerRepository.GetAllBrokerListusingIenumerable(), "ID", "BrokerName");
            ViewBag.tradelist = new SelectList(await _brokerRepository.GetAllstockListusingIenumerable(), "Id", "Stockname");
            return PartialView("_showParticalView");
        }

    }
}