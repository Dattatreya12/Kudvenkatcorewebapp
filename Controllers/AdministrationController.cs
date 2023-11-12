using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Kudvenkatcorewebapp.Models;
using Kudvenkatcorewebapp.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Kudvenkatcorewebapp.Controllers
{

    [Authorize(Policy = "AddAdminPolicy")]
    public class AdministrationController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public AdministrationController(RoleManager<IdentityRole> roleManager,
                                        UserManager<ApplicationUser> userManager)
        {
            this._roleManager = roleManager;
            this._userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        //lIST OF USERS
        [HttpGet]
        public IActionResult ListOfUsers()
        {
            var users = _userManager.Users;
            return View(users);
        }

        [HttpPost]
        [Authorize(Policy = "DeleteRolePolicy")]
        public async Task< IActionResult> Userdelete(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {id} cannot be found";
                return View("NotFound");
            }
            else
            {
                var result = await _userManager.DeleteAsync(user);
                if(result.Succeeded)
                {
                    return RedirectToAction("ListOfUsers");
                }

                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View("ListOfUsers");

            }
        }


        [HttpGet]
        public async Task<IActionResult> UserEdit(string id)
        {
            var user =await _userManager.FindByIdAsync(id);
           if(user==null)
            {
                ViewBag.Error = $"Error with id {id} cannot be found";
                return View("NotFound");
            }

            var userClaims = await _userManager.GetClaimsAsync(user);
            var userRoles = await _userManager.GetRolesAsync(user);
            var model = new EditUserViewModel
            {
                Id = user.Id,
                Email = user.Email,
                UserName = user.UserName,
                Claims = userClaims.Select(c => c.Value).ToList(),
                Roles = userRoles
            };

            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> UserEdit(EditUserViewModel model)
        {
            var user = await _userManager.FindByIdAsync(model.Id);
            if (user == null)
            {
                ViewBag.Error = $"Error with id {model.Id} cannot be found";
                return View("NotFound");
            }

            else
            {
                user.Email = model.Email;
                user.UserName = model.UserName;
                var result =await _userManager.UpdateAsync(user);
                if(result.Succeeded)
                {
                    return RedirectToAction("ListOfUsers");
                }

                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(model);

            }

        }


        /// <summary>
        /// Role taBLE STARTED
        /// </summary>
        /// <returns></returns>

        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(RoleViewModel roleViewModel)
        {
            if (ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole
                {
                    Name = roleViewModel.RoleName
                };
                IdentityResult result = await _roleManager.CreateAsync(identityRole);

                if (result.Succeeded)
                {
                   return RedirectToAction("ListOfRoles", "Administration");
                }
               foreach(IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                
            }
            return View();
        }

        [HttpGet]
        public IActionResult ListOfRoles()
        {
            var roles=_roleManager.Roles;
            return View(roles);
        }

        [HttpGet]
        public async Task<IActionResult> EdirRoleAction(string id)
        {
            var role =await _roleManager.FindByIdAsync(id);
            if(role==null)
            {
                ViewBag.ErrorMessage = $"Role with Id = {id} cannot be found";
                return View("NotFound");
            }
            var model = new EditRoleViewModel
            {
                Id = role.Id,
                RoleName = role.Name
            };

            foreach(var user in _userManager.Users)
            {
                if(await _userManager.IsInRoleAsync(user,role.Name))
                {
                    model.Users.Add(user.UserName);
                }
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EdirRoleAction(EditRoleViewModel editRoleViewModel)
        {
            var role = await _roleManager.FindByIdAsync(editRoleViewModel.Id);
            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id = {editRoleViewModel.Id} cannot be found";
                return View("NotFound");
            }
            else
            {
                role.Name = editRoleViewModel.RoleName;
                var result = await _roleManager.UpdateAsync(role);

                if (result.Succeeded)
                {
                  return  RedirectToAction("ListOfRoles");
                }
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(editRoleViewModel);
            }
           
        }

        [HttpGet]
        public async Task<IActionResult> EditUserInRole(string roleId)
        {
            ViewBag.roleid = roleId;
            var role = await _roleManager.FindByIdAsync(roleId);

            if(role==null)
            {
                ViewBag.ErrorMessage = $"Role with Id {roleId} cannot be found";
                return View("NotFound");
            }

            var model = new List<UserRoleViewModel>();

            foreach (var user in _userManager.Users)
            {
                var userroleviewmodel = new UserRoleViewModel()
                {
                    UserId = user.Id,
                    UserName = user.UserName
                };

                if(await _userManager.IsInRoleAsync(user,role.Name))
                {
                    userroleviewmodel.IsSelected = true;
                }
                else
                {
                    userroleviewmodel.IsSelected = false;
                }

                model.Add(userroleviewmodel);
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditUserInRole(List<UserRoleViewModel> model, string roleId)
        {
            var role = await _roleManager.FindByIdAsync(roleId);
            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id {roleId} cannot be found";
                return View("NotFound");
            }

            for(int i=0;i< model.Count; i++)
            {
                var user = await _userManager.FindByIdAsync(model[i].UserId);
                IdentityResult result = null;

                if (model[i].IsSelected && !(await _userManager.IsInRoleAsync(user, role.Name)))
                {
                    result =await _userManager.AddToRoleAsync(user, role.Name);
                }
                else if(!model[i].IsSelected && await _userManager.IsInRoleAsync(user, role.Name))
                {
                    result = await _userManager.RemoveFromRoleAsync(user, role.Name);
                }
                else
                {
                    continue;
                }

                if(result.Succeeded)
                {
                    if(i <(model.Count-1))
                    {
                        continue;
                    }
                    else
                    {
                        return RedirectToAction("EdirRoleAction", new { Id = roleId });
                    }
                }

            }
            return RedirectToAction("EdirRoleAction", new { Id = roleId });
        }

        [HttpGet]
        public async Task<IActionResult> ManageUserRoles(string userid)
        {
            ViewBag.userId = userid;

            var user = await _userManager.FindByIdAsync(userid);
            if (user == null)
            {
                ViewBag.Error = $"Error with id {userid} cannot be found";
                return View("NotFound");
            }

            var model = new List<RolesUserViewModel>();

            foreach(var role in _roleManager.Roles)
            {
                var ruvm = new RolesUserViewModel
                {
                    RoleId = role.Id,
                    RoleName = role.Name
                };

                if (await _userManager.IsInRoleAsync(user, role.Name))
                {
                    ruvm.IsSelected = true;
                }
                else
                {
                    ruvm.IsSelected = false;
                }

                model.Add(ruvm);
            }
            return View(model);
            
        }


        [HttpPost]
        public async Task<IActionResult> ManageUserRoles(List<RolesUserViewModel> model, string userid)
        {
            ViewBag.userId = userid;

            var user = await _userManager.FindByIdAsync(userid);
            if (user == null)
            {
                ViewBag.Error = $"Error with id {userid} cannot be found";
                return View("NotFound");
            }

            var roles = await _userManager.GetRolesAsync(user);
            var result = await _userManager.RemoveFromRolesAsync(user, roles);

            if(!result.Succeeded)
            {
                ModelState.AddModelError("", "cannot remove user existing roles");
                return View(model);
            }

            result = await _userManager.AddToRolesAsync(user, model.Where(x => x.IsSelected).Select(r => r.RoleName));
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "cannot remove user existing roles");
                return View(model);
            }

            return RedirectToAction("UserEdit", new { id = userid });
        }

        // Get Claims 
        [HttpGet]
        public async Task<IActionResult> ManageUserClaims(string userid)
        {
            ViewBag.userId = userid;

            var user = await _userManager.FindByIdAsync(userid);
            if (user == null)
            {
                ViewBag.Error = $"Error with id {userid} cannot be found";
                return View("NotFound");
            };
            var existingUserClaims = await _userManager.GetClaimsAsync(user);

            var model = new UserClaimsViewModel
            {
                UserId = userid,

            };

            foreach(Claim claim in  ClaimStore.AllClaims )
            {
                UserClaim userClaim = new UserClaim
                {
                    ClaimType = claim.Type
                };

                if(existingUserClaims.Any(c=>c.Type== claim.Type))
                {
                    userClaim.IsSelected = true;
                }
                model.Claims.Add(userClaim);
            }
            return View(model);

        }

        [HttpPost]
        public async Task<IActionResult> ManageUserClaims(UserClaimsViewModel m)
        {
            

            var user = await _userManager.FindByIdAsync(m.UserId);
            if (user == null)
            {
                ViewBag.Error = $"Error with id {m.UserId} cannot be found";
                return View("NotFound");
            };

            var claims = await _userManager.GetClaimsAsync(user);
            var result = await _userManager.RemoveClaimsAsync(user, claims);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "cannot remove user existing claims");
                return View(m);
            }

            result = await _userManager.AddClaimsAsync(user, m.Claims.Where(c => c.IsSelected).Select(c => new Claim(c.ClaimType, c.ClaimType)));
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "cannot add selected claims to user");
                return View(m);
            }

            return RedirectToAction("UserEdit", new { id = m.UserId });

        }
    }
}