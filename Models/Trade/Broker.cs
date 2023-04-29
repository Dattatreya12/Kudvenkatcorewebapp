using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kudvenkatcorewebapp.Models.Trade
{
    public class Broker
    {
        public int? ID { get; set; }
        public string BrokerName { get; set; }
        public int Active { get; set; }
        
        public IEnumerable<Tradeinformation> tradeinformations { get; set; }
        public IEnumerable<ExtraQuantityAddedinStocks> extraQuantityAddedinStocks { get; set; }
    }
}
