using Kudvenkatcorewebapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kudvenkatcorewebapp.DTO
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Active { get; set; }
        public Dept? Department { get; set; }
        public string PhotoPath { get; set; }
        public string Gender { get; set; }
        public string InitialName { get; set; }
        public int TotalInvestedAmount { get; set; }
    }
}
