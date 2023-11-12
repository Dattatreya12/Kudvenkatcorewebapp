<<<<<<< HEAD
﻿using Kudvenkatcorewebapp.Models.Loan;
using Kudvenkatcorewebapp.Models.Trade;
=======
﻿using Kudvenkatcorewebapp.Models.Trade;
>>>>>>> dk
using Kudvenkatcorewebapp.ViewModels.Trade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kudvenkatcorewebapp.Repository.Trade
{
    public interface IBrokerRepository
    {
        //First 2 methods are same
        int AddExtraQuantity(ExtraQuantityAddedinStocks extraQuantityAddedinStocks, string action);
<<<<<<< HEAD
        int AddProfitandLoss(AddProfitLoss addProfitLoss, string action);
        Task<IEnumerable<Broker>> GetAllBrokerListusingIenumerable();
        Task<IEnumerable<Tradeinformation>> GetAllstockListusingIenumerable();
        Task<List<Broker>>GetAllBrokerList();
        Task<Broker> Add(Broker broker);
=======
        Task<IEnumerable<Broker>> GetAllBrokerListusingIenumerable();
        Task<IEnumerable<Tradeinformation>> GetAllstockListusingIenumerable();
          Task<List<Broker>>GetAllBrokerList();

          Task<Broker> Add(Broker broker);
>>>>>>> dk
    }

   

    
}
