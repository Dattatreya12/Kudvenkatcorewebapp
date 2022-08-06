using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kudvenkatcorewebapp.Models.Trade
{
    public class Total_profit_loss
    {
        public int ID { get; set; }

        [Required]
        public double Profit { get; set; }
        public double Totalprofit { get; set; }
        [Required]
        public double Loss { get; set; } 
        public double Totalloss { get; set; }
        public int Year { get; set; }
    }
}
