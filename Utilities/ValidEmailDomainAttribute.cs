using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kudvenkatcorewebapp.Utilities
{
    public class ValidEmailDomainAttribute:ValidationAttribute
    {
        private readonly string AllowedDomain;
        public ValidEmailDomainAttribute(string allowedDomain)
        {
           this.AllowedDomain = allowedDomain;
        }

        

        public override bool IsValid(object value)
        {
          string[] strings=  value.ToString().Split('@');
            return strings[1].ToUpper() == AllowedDomain.ToUpper();
        }
    }
}
