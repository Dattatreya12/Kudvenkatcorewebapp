using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Kudvenkatcorewebapp.Models;
using Kudvenkatcorewebapp.Repository;
using Kudvenkatcorewebapp.ViewModels;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Authorization;

namespace Kudvenkatcorewebapp.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger _logger;
        private readonly IEmployeeRepository _employeeRepository;
        [Obsolete]
        private readonly IHostingEnvironment _hostingEnvironment;

        [Obsolete]
        public HomeController(ILogger<HomeController> logger,
                              IEmployeeRepository employeeRepository,
                              IHostingEnvironment hostingEnvironment
                               )
        {
            _logger = logger;
            _employeeRepository = employeeRepository;
            this._hostingEnvironment = hostingEnvironment;
        }

        public ViewResult Index()
        {
            
            var model = _employeeRepository.GetAllEmployees();
            return View(model);
        }

        public async Task<IActionResult> Details(int? id)
        {
            _logger.LogTrace("Log Trace");
            _logger.LogDebug("Log Debug");
            _logger.LogInformation("Log Information");
            _logger.LogWarning("Log Warning");
            _logger.LogError("Log Error");
            _logger.LogCritical("Log Critical");


            Employee employee =await _employeeRepository.GetEmployee(id.Value);
            /* VeiwData*/
            if(employee==null)
            {
                Response.StatusCode = 404;
                return View("EmployeeNotFound", id.Value);
            }
            //ViewData["Employee"] = model;
            //ViewData["PageTitle"] = "Employee Details";

            /* ViewBag*/
            //ViewBag.employee = model;
            //ViewBag.PageTitle = "Employee Details";
            HomeDetailsViewModel hdvm = new HomeDetailsViewModel()
            {
                employee =employee,
                PageTitle = "Employee Details"
            };
;            return View(hdvm);
        }

        [HttpGet]
        [Authorize]
        public ActionResult CreateEmployee()
        {
            return View();
        }

        
        //Inserting Data Into Database
        [HttpPost]
        [Obsolete]
        [Authorize(Roles ="Admin")]
        public IActionResult CreateEmployee(EmployeeViewModel model)
        {
            //TempData["Message"] = "Mr!";
            //TempData.Keep("Message");
            if (ModelState.IsValid)
            {
               
                string uniquFileName = null;
                if (model.Photo != null && model.Photo.Count>0)
                {
                    foreach (IFormFile p in model.Photo)
                    {
                        string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");
                        uniquFileName = Guid.NewGuid().ToString() + " " + p.FileName;
                        string filePath = Path.Combine(uploadsFolder, uniquFileName);
                        p.CopyTo(new FileStream(filePath, FileMode.Create));
                    }
                }
                Employee newemployee = new Employee
                {
                    Name = model.Name,
                    Email = model.Email,
                    Department = model.Department,
                    PhotoPath = uniquFileName,
                    Active=1,
                    Gender=model.Gender
                };
                _employeeRepository.Add(newemployee);
                return RedirectToAction("Details", new { id = newemployee.Id });
            }
         
            return View();
            
        }

        [HttpGet]

        public async Task<ActionResult> Editemployee(int id)
        {
            Employee employee =await _employeeRepository.GetEmployee(id);
            EmployeeEditViewModel eevm = new EmployeeEditViewModel
            {
                Id = employee.Id,
                Name = employee.Name,
                Email = employee.Email,
                Department = employee.Department,
                Gender=employee.Gender,
                ExistingPhotoPath = employee.PhotoPath

            };
            return View(eevm);
        }


        [HttpPost]
        [Obsolete]
        public async Task<IActionResult> Editemployee(EmployeeEditViewModel model)
        {
            //TempData["Message"] = "Mr!";
            //TempData.Keep("Message");
            if (ModelState.IsValid)
            {
                Employee emp =await _employeeRepository.GetEmployee(model.Id);
                emp.Name = model.Name;
                emp.Email = model.Email;
                emp.Department = model.Department;
                emp.Gender = model.Gender;
                emp.Active = 1;
                if(model.Photo!=null)
                {
                    if (model.ExistingPhotoPath != null)
                    {
                        string filePath = Path.Combine(_hostingEnvironment.WebRootPath, "images", model.ExistingPhotoPath);
                        System.IO.File.Delete(filePath);
                    }
                   emp.PhotoPath = ProcessUploadFile(model);
                }
               
                
                _employeeRepository.Update(emp);
                return RedirectToAction("Index");
            }

            return View();

        }
        public ActionResult AllEmployee()
        {
           
            var model = _employeeRepository.GetEmployeesList();
            return View(model);
        }


        public IActionResult Privacy()
        {
            return View();
        }
        

        [Obsolete]
        private string ProcessUploadFile(EmployeeViewModel model)
        {
            string uniquFileName = null;
            if (model.Photo != null && model.Photo.Count > 0)
            {
                foreach (IFormFile p in model.Photo)
                {
                    string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");
                    uniquFileName = Guid.NewGuid().ToString() + " " + p.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniquFileName);
                    using(var filestream= new FileStream(filePath, FileMode.Create))
                    {
                        p.CopyTo(filestream);
                    }
                }
            }
            return uniquFileName;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Route("CustomErrorPage/{StatusCode}")]
        public IActionResult HttpStatusCodeHandler(int StatusCode)
        {
           
            var statusCodeResult = HttpContext.Features.Get<IStatusCodeReExecuteFeature>();

            switch(StatusCode)
            {
                case 404:
                    ViewBag.Message = "Sorry, the resource you requested could not found";
                    ViewBag.Path = statusCodeResult.OriginalPath;
                    ViewBag.QS = statusCodeResult.OriginalQueryString;
                    break;
            }

            return View("CustomErrorPage");
        }
    }
}
