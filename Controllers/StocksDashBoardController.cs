using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kudvenkatcorewebapp.DBContext;
using Kudvenkatcorewebapp.Models;
using Kudvenkatcorewebapp.Models.Loan;
using Kudvenkatcorewebapp.Models.Trade;
using Kudvenkatcorewebapp.Repository.LoanRepository;
using Kudvenkatcorewebapp.Repository.Trade;
using Kudvenkatcorewebapp.Repository.Trade.InterfaceRepo;
using Kudvenkatcorewebapp.ViewModels.Trade;
using Microsoft.AspNetCore.Mvc;

namespace Kudvenkatcorewebapp.Controllers
{
    public class StocksDashBoardController : Controller
    {
        private readonly IBrokerRepository _brokerRepository;
        private readonly ITradeshare _tradeinformation;
        private readonly AppDbContext appDbContext;
        private readonly IextraStocks _iextraStocks;
        private readonly IProfitLoss _profitLoss;
       

        public StocksDashBoardController(IBrokerRepository brokerRepository, 
                                         ITradeshare tradeinformation,
                                         AppDbContext appDbContext,
                                         IextraStocks iextraStocks,
                                         IProfitLoss profitLoss
                                         )
        {
            this._brokerRepository = brokerRepository;
            this._tradeinformation = tradeinformation;
            this.appDbContext = appDbContext;
            this._iextraStocks = iextraStocks;
            this._profitLoss = profitLoss;
          
        }
        public IActionResult Index()
        {
            return View();
        }

       [HttpPost]
        public IActionResult ProfitAndLoss()
        {
            return RedirectToAction("StocksDashBoard");
        }
        public async Task<IActionResult> StocksDashBoard()
        {
            double TotalInvetsment = 0;
            double Totalinvestedamountineachbroker = 0;
            double TotalinvestZerodha = 0;
            double TotalinvestedUpstox = 0;
            double TotalinvestedAngel = 0;

            // Total Profit & Loss
            double p=0,l=0;
            int y=0;
            
           

            IEnumerable<Tradeinformation> sharelist = await _tradeinformation.GetTradeInformationList();
            IEnumerable<ExtraQuantityAddedinStocks> ExtrastocksInfo = await _iextraStocks.GetTradeInformationList();
            //return View(sharelist);
            
            foreach (var i in sharelist)
            {
                TotalInvetsment += i.TotalInvestedAmount;
                Totalinvestedamountineachbroker = _tradeinformation.TotalinvestedinAllStocks(i.brokerid,i.BrokerName,i.TotalInvestedAmount);
                if(i.BrokerName== "ZERODHA")
                {
                    TotalinvestZerodha += Totalinvestedamountineachbroker;
                }
                else if(i.BrokerName == "UPSTOX")
                {
                    TotalinvestedUpstox += Totalinvestedamountineachbroker;
                }
                else
                {
                    TotalinvestedAngel += Totalinvestedamountineachbroker;
                }
                
            }


            // Total Profi and Loss Returning 
            
            Total_profit_loss total_Profit_Losses = await _profitLoss.GetListofProfitAndLoss();
            p = total_Profit_Losses.Totalprofit;
            l = total_Profit_Losses.Totalloss;
            y = total_Profit_Losses.Year;

           

            //throw Exception;

            // Declaring All Data into below function
            var tradedashborad = new DashBoardTradeItemsViewModel
            {
                tradeinformations=sharelist,
                TotalinvestZerodha = TotalinvestZerodha,
                TotalinvestedUpstox=TotalinvestedUpstox,
                TotalinvestedAngel=TotalinvestedAngel,
                TotalInvestment=TotalInvetsment,
                extraQuantityAddedinStocks=ExtrastocksInfo,
                //Total_Profit_Losses=total_Profit_Losses,
                Totalprofit=p,
                Totalloss=l,
                Year=y,
                

            };

          
            return View(tradedashborad);
        }
    }
}