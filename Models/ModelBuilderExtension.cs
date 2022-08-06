using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kudvenkatcorewebapp.Models
{
    public static class ModelBuilderExtension
    {
        public static void seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 5,
                    Name = "Dhriti",
                    Email = "dh@gmail.com",
                    Active = 1,
                    Department = Dept.IT

                }
                );
        }
    }
}
