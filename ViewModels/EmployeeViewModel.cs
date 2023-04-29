using Kudvenkatcorewebapp.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kudvenkatcorewebapp.ViewModels
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public int Active { get; set; }
        [Required]
        public Dept? Department { get; set; }
        public List<IFormFile> Photo { get; set; }
        public string Gender { get; set; }
        public string InitialName { get; set; }
        public int TotalInvestedAmount { get; set; }
    }
}
