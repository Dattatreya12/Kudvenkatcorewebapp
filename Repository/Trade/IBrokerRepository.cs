using Kudvenkatcorewebapp.Models.Trade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kudvenkatcorewebapp.Repository.Trade
{
    public interface IBrokerRepository
    {
        //First 2 methods are same
          Task<IEnumerable<Broker>> GetAllBrokerListusingIenumerable();
          Task<List<Broker>>GetAllBrokerList();

        Task<Broker> Add(Broker broker);
    }

   

    
}
