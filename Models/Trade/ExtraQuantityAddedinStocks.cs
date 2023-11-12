using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kudvenkatcorewebapp.Models.Trade
{
    public class  ExtraQuantityAddedinStocks
    {
        public int ID { get; set; }
        public string BrokerName { get; set; }
        public string StockName { get; set; }
        public double BuyPrice { get; set; }
        public int TotalShare { get; set; }
        public double TotalInvestment { get; set; }
        public string Day { get; set; }
        public string Month { get; set; }
        public int Year { get; set; }
        public int Active { get; set; }
        public int brokerid { get; set; }
        public int stockid { get; set; }
        //public string BrokerName { get; set; }
        public Tradeinformation tradeinformation { get; set; }
        public Broker broker { get; set; }
    }




}
