using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kudvenkatcorewebapp.DBContext;
using Kudvenkatcorewebapp.Models.Trade;
using Kudvenkatcorewebapp.Repository.Trade;
using Kudvenkatcorewebapp.ViewModels.Trade;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Kudvenkatcorewebapp.Controllers
{
    [Authorize(Roles ="Admin")]
    public class BtradeController : Controller
    {
        private readonly IBrokerRepository _brokerRepository;
        private readonly ITradeshare _tradeinformation;
        private readonly AppDbContext appDbContext;
        //SharetradeRepository sr=new SharetradeRepository();

        public BtradeController(IBrokerRepository brokerRepository, ITradeshare tradeinformation,AppDbContext appDbContext)
        {
            this._brokerRepository = brokerRepository;
            this._tradeinformation = tradeinformation;
            this.appDbContext = appDbContext;
        }
        public async Task<IActionResult> Index()
        {
            var brokerlist =await _brokerRepository.GetAllBrokerListusingIenumerable();
            return View(brokerlist);
        }
        
        public async Task<IActionResult> BrokerDropdownList()
        {
            //ViewBag.brokerlist = new SelectList(await _brokerRepository.GetAllBrokerListusingIenumerable(), "ID", "BrokerName");
            IEnumerable<Tradeinformation> brokerlist = await _tradeinformation.GetTradeInformationList();
            ////return View(__StocksnformationView, brokerlist);
            //return PartialView("_StocksnformationView", brokerlist);
            return View(brokerlist);
        }

        public async Task<IActionResult> GetAllStocks()
        {
            IEnumerable<Tradeinformation> sharelist = await _tradeinformation.GetTradeInformationList();
            return View(sharelist);
        }

        public async Task<IActionResult> GetAllStocksAjax()
        {
            int id = Convert.ToInt32(TempData["ID"]);
            ViewBag.message = id;
            IEnumerable<Tradeinformation> sharelist = await _tradeinformation.GetTradeInformationList();
            return View(sharelist);
        }

        [HttpGet]
        public async Task<IActionResult> ShareCreate()
        {
            ViewBag.brokerlist = new SelectList(await _brokerRepository.GetAllBrokerListusingIenumerable(), "ID", "BrokerName");
            return View();
        }

        [HttpPost]
        public IActionResult ShareCreate(BrokerTradeViewModel model)
        {
            //double im = sr.TotalInvestedAmountinShares(model.tradeinformation.Stockbuykprice, model.tradeinformation.Stocktotalshares);
            model.tradeinformation.TotalInvestedAmount = 0;
           
            if (ModelState.IsValid)
            {
                Tradeinformation tradeinformation = new Tradeinformation
                {
                    brokerid = model.tradeinformation.brokerid,
                    Stockname = model.tradeinformation.Stockname,
                    Stockbuykprice = model.tradeinformation.Stockbuykprice,
                    Stocksellprice = model.tradeinformation.Stocksellprice,
                    Stocktotalshares = model.tradeinformation.Stocktotalshares,
                    TotalInvestedAmount = model.tradeinformation.TotalInvestedAmount,
                    Stockpurchaseddate = model.tradeinformation.Stockpurchaseddate,
                    Stockselldate = model.tradeinformation.Stockselldate,
                    Active = 1,
                };
                _tradeinformation.AddITradeinformation(tradeinformation);
                if (tradeinformation.Id > 0)
                {
                    int sngid = 1;

                    TempData["ID"] = sngid;

                    return RedirectToAction("GetAllStocksAjax");
                }
                return RedirectToAction("GetAllStocks");
            }
                //ViewBag.brokerlist = new SelectList(await _brokerRepository.GetAllBrokerListusingIenumerable(), "ID", "BrokerName");
                return View();
        }

        [HttpPost]
        public IActionResult DeleteShare(int id)
        {
            Tradeinformation tradeinformation = appDbContext.tradeinformations.Where(t => t.Id == id).FirstOrDefault();
            appDbContext.Entry(tradeinformation).State = EntityState.Deleted;
            appDbContext.SaveChanges();
            return Ok();
        }
        
        [HttpPost]
        public IActionResult ViewShare(int id)
        {
            Tradeinformation tradeinformation = appDbContext.tradeinformations.Where(t => t.Id == id).FirstOrDefault();
            return PartialView("_Detail", tradeinformation);
           
        }
    }
}