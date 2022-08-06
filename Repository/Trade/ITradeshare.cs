using Kudvenkatcorewebapp.Models.Trade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kudvenkatcorewebapp.Repository.Trade
{
    public interface ITradeshare
    {
        Task<List<Tradeinformation>> GetTradeInformationList();
        Tradeinformation AddITradeinformation(Tradeinformation tradeinformation);
        Task<Tradeinformation> UpdateITradeinformation(Tradeinformation tradeinformation, int id);
        Task<Tradeinformation> DeleteITradeinformation(int id);
        public double TotalinvestedinAllStocks(int brokerid, string brokername, double investedamount);
    }
}
