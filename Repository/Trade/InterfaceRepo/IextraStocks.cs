using Kudvenkatcorewebapp.Models.Trade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kudvenkatcorewebapp.Repository.Trade.InterfaceRepo
{
    public interface IextraStocks
    {
        Task <IEnumerable<ExtraQuantityAddedinStocks>> GetTradeInformationList();
    }
}
