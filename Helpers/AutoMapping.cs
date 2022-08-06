using AutoMapper;
using Kudvenkatcorewebapp.DTO;
using Kudvenkatcorewebapp.Models;
using Kudvenkatcorewebapp.Models.Trade;
using Kudvenkatcorewebapp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kudvenkatcorewebapp.Helpers
{
    public class AutoMapping:Profile
    {
        public AutoMapping()
        {
            CreateMap<Employee, EmployeeViewModel>().ReverseMap();
            CreateMap<LoanEmployees, LoanEmployeesDTO>();
        }
    }
}
