using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kudvenkatcorewebapp.Models
{
    public class CityMaster
    {
        public int ID { get; set; }
        public string CityName { get; set; }
        public int Active { get; set; }
        public ICollection<ApplicationUser> applicationUsers { get; set; }
    }
}
