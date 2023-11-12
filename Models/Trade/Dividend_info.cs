using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kudvenkatcorewebapp.Models.Trade
{
    public class Dividend_info
    {
        public int Id { get; set; }
        public int stockid { get; set; }

        public string stockname { get; set; }
        //public string BrokerName { get; set; }
        public Tradeinformation tradeinformation { get; set; }
        public double dividendAmount { get; set; }
        public int year { get; set; }

    }

   
}
