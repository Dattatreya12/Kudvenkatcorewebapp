using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kudvenkatcorewebapp.ViewModels.Trade
{
    public class AdminStockViewModel
    {
        public double Profit { get; set; }
        public double Totalprofit { get; set; }
        public double Loss { get; set; }
        public double Totalloss { get; set; }
        public int Year { get; set; }
    }
}
