using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kudvenkatcorewebapp.Models;
using Kudvenkatcorewebapp.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Kudvenkatcorewebapp.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly Icity _icity;

        public AccountController(UserManager<ApplicationUser> userManager,
                                 SignInManager<ApplicationUser> signInManager,
                                 Icity icity)
        {
           this._userManager = userManager;
           this._signInManager = signInManager;
            this._icity = icity;
        }

       

        [HttpGet]
        public async Task<IActionResult> Register()
        {
            ViewBag.cities = new SelectList(await _icity.GetCities(), "ID", "CityName");
            return View();
        }

        [Authorize(Roles ="Admin")]
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if(ModelState.IsValid)
            {
                var user = new ApplicationUser
                {
                    UserName = registerViewModel.Email,
                    Email = registerViewModel.Email,
                    CityId= registerViewModel.City
                    
                };
               
                var result=await _userManager.CreateAsync(user, registerViewModel.Password);
                if(result.Succeeded)
                {
                   
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Home");
                }
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(registerViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Presentation");

        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel,string returnUrl)
           
        {
            if (ModelState.IsValid)
            {
                //var user = new IdentityUser
                //{
                //    UserName = loginViewModel.Email,
                //    Email = loginViewModel.Email

                //};
                var result = await _signInManager.PasswordSignInAsync(loginViewModel.Email, loginViewModel.Password,loginViewModel.RememberMe,true);
                if (result.Succeeded)
                {
                    if(!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                    {
                        //return LocalRedirect(returnUrl);
                        return RedirectToAction("Login", "Account");
                    } 
                    else
                    {
                      return RedirectToAction("Index", "Home");
                    }
                    
                }
               
                    ModelState.AddModelError(string.Empty,"Invalid Login Attempt");
                
            }
            return View(loginViewModel);
        }

        [AcceptVerbs("Get","Post")]
        [AllowAnonymous]
        public async Task<IActionResult> IsEmailInUse(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if(user==null)
            {
                return Json(true);
            }
            else
            {
                return Json($"Email {email} is already in use");
            }
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }

    }
}