using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kudvenkatcorewebapp.Models.Trade
{
    public class Tradeinformation
    {
        public int Id { get; set; }
        public string Stockname { get; set; }
        public double Stockbuykprice { get; set; }
        public double Stocksellprice { get; set; }
        public int Stocktotalshares { get; set; }
        [DisplayName("Stock Purchase Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
       
        public DateTime? Stockpurchaseddate { get; set; }

        [DisplayName("Stock Sell Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime? Stockselldate { get; set; }
        public double TotalInvestedAmount { get; set; }
        public int Active { get; set; }
        // Broker List//
        public int brokerid { get; set; }
        public string BrokerName { get; set; }
        public double TotalProfit { get; set; }
        public double TotlaLoss { get; set; }
    }
}
