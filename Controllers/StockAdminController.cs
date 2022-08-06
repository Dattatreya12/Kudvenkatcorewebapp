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
using Microsoft.Extensions.Configuration;

namespace Kudvenkatcorewebapp.Controllers
{
    public class StockAdminController : Controller
    {
       
        private readonly IProfitLoss _profitLoss;
        private readonly IConfiguration _configuration;
        private readonly AppDbContext _context;

        public StockAdminController(IProfitLoss profitLoss, IConfiguration configuration, AppDbContext context)
        {
            this._profitLoss = profitLoss;
            this._configuration = configuration;
            this._context = context;
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
        


    }
}