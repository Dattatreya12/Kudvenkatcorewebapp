﻿using Kudvenkatcorewebapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kudvenkatcorewebapp.Repository
{
    public interface Ilogic
    {
        IEnumerable<Employee> GetEmployeesList();
    }
}
