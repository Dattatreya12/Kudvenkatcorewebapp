using Kudvenkatcorewebapp.Models;
using Kudvenkatcorewebapp.Models.Trade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kudvenkatcorewebapp.ViewModels.Trade
{
    public class DashBoardTradeItemsViewModel
    {
        public int Id { get; set; }
        public List<Broker> brokers { get; set; }
        public IEnumerable<Tradeinformation> tradeinformations { get; set; }
        public IEnumerable<ExtraQuantityAddedinStocks> extraQuantityAddedinStocks { get; set; }
        public double TotalinvestZerodha { get; set; }
        public double TotalinvestedUpstox { get; set; }
        public double TotalinvestedAngel { get; set; }
        public double TotalInvestment { get; set; }

        // showing Data from 
        public List<Total_profit_loss> Total_Profit_Losses { get; set; }
        public double Profit { get; set; }
        public double Totalprofit { get; set; }
        public double Totalloss { get; set; }
        public double Loss { get; set; }
        public int  Year { get; set; }
        public int? Totalsharecount { get; set; }
        public int? Totaladdedextrastocks { get; set; }
        public double TotalinvestAmountInYear { get; set; }
        public IEnumerable<LoanEmployees> loanEmployees { get; set; }




    }
}
