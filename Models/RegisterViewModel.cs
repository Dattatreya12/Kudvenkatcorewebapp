using Kudvenkatcorewebapp.Utilities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kudvenkatcorewebapp.Models
{
    public class RegisterViewModel
    {
        [Required]
        [Remote(action: "IsEmailInUse", controller:"Account")]
        //[ValidEmailDomainAttribute(allowedDomain:"dk.com", ErrorMessage ="Email domain must be dk.com")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="Confirm Password")]
        [Compare("Password", ErrorMessage ="Password and Confirmation Password do not match")]
        public string ConfirmPassword { get; set; }

        public int City { get; set; }
    }
}
