using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kudvenkatcorewebapp.Models.Loan
{
    public class AddProfitLoss
    {
        [Key]
        public int ID { get; set; }
        public string Option { get; set; }
        public int IncomeLoss { get; set; }
        public DateTime Createat { get; set; }
        public int Active { get; set; }

    }
}
