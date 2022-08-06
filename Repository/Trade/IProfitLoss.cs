using Kudvenkatcorewebapp.Models.Trade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kudvenkatcorewebapp.Repository.Trade
{
    public interface IProfitLoss
    {
        Task<Total_profit_loss> GetListofProfitAndLoss();

        void AddUpdateDeleteCustomer(Total_profit_loss profit_Loss, string action);
    }
}
