using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Kudvenkatcorewebapp.DBContext;
using Kudvenkatcorewebapp.Models;
using Kudvenkatcorewebapp.Repository.LoanRepository;
using Kudvenkatcorewebapp.Utilities.ShresLogic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using cloudscribe.Pagination.Models;
using System.Xml.Linq;
using Kudvenkatcorewebapp.DTO;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Kudvenkatcorewebapp.Controllers
{
    public class LoanModule : Controller
    {
        private readonly IloanCrudService _iloanCrudService;

        private readonly IConfiguration _configurtion;
        private readonly AppDbContext _context;

        // GET: /<controller>/

        public LoanModule(IloanCrudService iloanCrudService, IConfiguration configurtion, AppDbContext context)
        {
            this._iloanCrudService = iloanCrudService;
            this._configurtion = configurtion;
            this._context = context;
        }
        public async Task<IActionResult> Index(int pageNumber=1,int pageSize=5)
        {
            int ExcludeRecords = (pageSize * pageNumber) - pageSize;
            ViewBag.loanemployee = new SelectList(await _iloanCrudService.GetEmployeeName(), "Id", "Name");

            var model = (await _iloanCrudService.GetLoanEmployees()).Skip(ExcludeRecords).Take(pageSize);
            var result = new PagedResult<LoanEmployees>
            {
                Data = model.ToList(),
                TotalItems = _context.loanEmployees.Count(),
                PageNumber = pageNumber,
                PageSize = pageSize
            };
            return View(result);
            //return View();
        }

        public async Task<IActionResult> LoanInformationByLoanID(string LoanID)
        {
            var model = await _iloanCrudService.GetLoanInformatiomByLoanID(LoanID);
            return View(model);
            //return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddCustomer()
        {
            ViewBag.loanemployee = new SelectList(await _iloanCrudService.GetEmployeeName(), "Id", "Name");
            string a =  _iloanCrudService.RandomLoanIDGenerate();
           
            ViewBag.Name = "Add";
            LoanEmployees customer = new LoanEmployees();
            customer.LoanID = a.ToString();
           
            return PartialView("_InsertUpdatePartial", customer);
        }

        [HttpPost]
        public IActionResult Create(LoanEmployees loanEmployees)
        {
            AddUpdateDeleteCustomer(loanEmployees, "Insert");
            return RedirectToAction("Index");
        }

        public void AddUpdateDeleteCustomer(LoanEmployees loanEmployees, string action)
        {
            BuyrateMultyplyWithTotalSharesLogic totalintrestlogic = new BuyrateMultyplyWithTotalSharesLogic();
            loanEmployees.TotalIntrest = totalintrestlogic.TotalIntrest(loanEmployees.TotalLoanAmount, loanEmployees.TotalEmi);
            using (SqlConnection con = new SqlConnection(_configurtion.GetConnectionString("Default")))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        cmd.Parameters.Clear();
                        if (action == "Insert")
                        {
                            DateTime d =Convert.ToDateTime( loanEmployees.LoanDate);
                            //string en = loanEmployees.employeesname.ToString();

                            cmd.CommandText = "INSERT INTO loanEmployees(EmployeeId,LoanID,TotalLoanAmount,TotalEmi,LoanDate,TotalIntrest,Active,LoanUserName)VALUES (@EmployeeId,@LoanID,@TotalLoanAmount,@TotalEmi,@LoanDate,@TotalIntrest,@Active,@LoanUserName)";
                            cmd.Parameters.AddWithValue("@EmployeeId", loanEmployees.EmployeeId);
                            cmd.Parameters.AddWithValue("@LoanID", loanEmployees.LoanID);
                            cmd.Parameters.AddWithValue("@TotalLoanAmount", loanEmployees.TotalLoanAmount);
                            cmd.Parameters.AddWithValue("@TotalEmi", loanEmployees.TotalEmi);
                            cmd.Parameters.AddWithValue("@LoanDate", d);
                            cmd.Parameters.AddWithValue("@TotalIntrest", loanEmployees.TotalIntrest);
                            cmd.Parameters.AddWithValue("@Active", 1);
                            cmd.Parameters.AddWithValue("@LoanUserName", "null");
                        }
                        else if (action == "Update")
                        {
                            //cmd.CommandText = "UPDATE Customers SET NAME = @Name,Country = @Country WHERE CustomerId = @Id";
                            //cmd.Parameters.AddWithValue("@Id", customer.Id);
                            //cmd.Parameters.AddWithValue("@Name", customer.Name);
                            //cmd.Parameters.AddWithValue("@Country", customer.Country);
                        }
                        else if (action == "Delete")
                        {
                            //cmd.CommandText = "DELETE FROM Customers WHERE CustomerId = @Id";
                            //cmd.Parameters.AddWithValue("@Id", customer.Id);
                        }
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch(Exception e)
                    {
                        throw e;
                    }
                }
            }
        }

        public string LinqToXML(LoanEmployees loanEmployees)
        {

            string depname = string.Empty;
            var depnamelist = new List<XmlDeoartment>();
            string myxml = @"<Departments>
                            <Department>Account</Department>
                             <Department>Sales</Department>
                                   </Departments>";

            XDocument xdoc = new XDocument();
            xdoc = XDocument.Parse(myxml);
            var result = xdoc.Element("Departments").Descendants();

            foreach(XElement item in result)
            {
                depname = item.Value;
                depnamelist.Add(new XmlDeoartment()
                {
                  
                    Department =depname,
                }) ;
                return depname += depnamelist;
            }
            return depname;

           // return depnamelist.ToList();

        }






    }
}
