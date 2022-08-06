using Kudvenkatcorewebapp.Models.Trade;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kudvenkatcorewebapp.ViewModels.Trade
{
    public class BrokerTradeViewModel:Broker
    {
        public Tradeinformation tradeinformation { get; set; }
        public IEnumerable<Broker> brokers { get; set; }
        public int Brokerid { get; set; }
        
        public IEnumerable<SelectListItem> GetDropdownList(IEnumerable<Broker> brokers)
        {
            List<SelectListItem> blist = new List<SelectListItem>();
            SelectListItem sli = new SelectListItem
            {
                Text =".....Select....",
                Value="0"
            };
            blist.Add(sli);
            foreach (Broker b in brokers)
            {
                sli = new SelectListItem
                {
                    Text = b.BrokerName,
                    Value = b.ID.ToString()
                 };
            blist.Add(sli);
            }

            return blist;
        }
        
        
    
    }
}
  
