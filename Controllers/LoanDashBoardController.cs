using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kudvenkatcorewebapp.DBContext;
using Kudvenkatcorewebapp.DTO;
using Kudvenkatcorewebapp.Models;
using Kudvenkatcorewebapp.Models.Loan;
using Kudvenkatcorewebapp.Repository.Trade;
using Kudvenkatcorewebapp.ViewModels.Sangh;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Kudvenkatcorewebapp.Controllers
{
    public class LoanDashBoardController : Controller
    {
        private readonly IConfiguration _configurtion;
        private readonly AppDbContext _context;
        private readonly ILoanmonthlyintrestcalculate _loanmonthlyintrest;


        public LoanDashBoardController(IConfiguration configurtion, AppDbContext context
                                       , ILoanmonthlyintrestcalculate loanmonthlyintrest)
        {
            this._configurtion = configurtion;
            this._context = context;
            this._loanmonthlyintrest = loanmonthlyintrest;

        }
        public IActionResult Index()
        {
            return View();
        }


        public JsonResult GetEmployees(string country)
        {
            var usages = new List<LoanEmployees>();
            double totalsumloan = 0;
            double TLA = 0;
            double sumofhandloancalculation = 0;
            // int monthlyFivehundred = 8000;
            int monthlyFivehundred = 25000;
            //NorthwindEntities entities = new NorthwindEntities();
            //var year = _context.loanEmployees.c.Value.Year.ToString();
            var employees = (from l in _context.loanEmployees
                                             join employee in _context.employees on l.EmployeeId equals employee.Id
                                             where l.LoanDate.Year.ToString() == country && l.Active==1 orderby l.LoanDate descending
                             select new 
                                        {
                                            loanId = l.LoanID,
                                            name = employee.Name,
                                            TotalloanAmount = l.TotalLoanAmount,
                                            Emi = l.TotalEmi,
                                            TotalPaidEmi = l.TotalPaidEmi,
                                            TotalBalanceEmi = l.TatlBalanceEmi,
                                            LoanDate = l.LoanDate
                                        }).ToList();

            if (employees?.Any() == true)
            {
                foreach (var sharesdata in employees)
                {
                    int Totalmonthlyamount = sharesdata.TotalloanAmount / sharesdata.Emi;
                    totalsumloan += Totalmonthlyamount;
                    TLA = sharesdata.TotalloanAmount;
                    //var dateAndTime = DateTime.Now;
                   
                    var dateValue1 = sharesdata.LoanDate;
                    DateTime date = dateValue1.Date;


                    usages.Add(new LoanEmployees()
                    {
                        LoanID = sharesdata.loanId,
                        LoanUserName = sharesdata.name,
                        TotalLoanAmount = Totalmonthlyamount,
                        TotalEmi = sharesdata.Emi,
                        TotalPaidEmi = sharesdata.TotalPaidEmi,
                        TatlBalanceEmi = sharesdata.TotalBalanceEmi,
                        LoanDate = date,
                    });
                }

            }

            return new JsonResult(usages);
           // return Json(employees, JsonRequestBehavior.AllowGet);
        }

        

        public async Task<IActionResult> LoanDashBoardAsync(int pageNumber = 1, int pageSize = 5)
        {

            int ExcludeRecords = (pageSize * pageNumber) - pageSize;
            // var loanemmployee =  _context.loanEmployees.Where(x => x.Active == 1).ToList();
            //return brokerlist;
            DateTime currentmonth = DateTime.Now;
         
            double totalsumloan = 0;

            //Total Loan Amount
            double TLA = 0;
            double sumofhandloancalculation = 0;
           // int monthlyFivehundred = 8000;
            int monthlyFivehundred = 25000;
            //Handloan List
            var Listhandloan = new List<HandLoan>();
            //LoanList
            var usages = new List<LoanEmployees>();

            // MonthlyTrackLoan
            var TrackmonthlyLoan = new List<MonthlyLoanTrack>();

           

            var result = (from loanuser in _context.loanEmployees
                               join employee in _context.employees on loanuser.EmployeeId equals employee.Id
                               where loanuser.Active == 1 orderby loanuser.LoanDate descending
                               select new
                               {
                                   loanId = loanuser.LoanID,
                                   name = employee.Name,
                                   TotalloanAmount = loanuser.TotalLoanAmount,
                                   Emi=loanuser.TotalEmi,
                                   TotalPaidEmi=loanuser.TotalPaidEmi,
                                   TotalBalanceEmi=loanuser.TatlBalanceEmi,
                                   LoanDate=loanuser.LoanDate,
                                  
                               }).ToList();


            if (result?.Any() == true)
            {
                foreach (var sharesdata in result)
                {
                    int Totalmonthlyamount = sharesdata.TotalloanAmount / sharesdata.Emi;
                    totalsumloan += Totalmonthlyamount;

                    TLA = sharesdata.TotalloanAmount;



                    usages.Add(new LoanEmployees()
                    {
                        LoanID = sharesdata.loanId,
                        LoanUserName = sharesdata.name,
                        TotalLoanAmount = Totalmonthlyamount,
                        TotalEmi=sharesdata.Emi,
                        TotalPaidEmi = sharesdata.TotalPaidEmi,
                        TatlBalanceEmi = sharesdata.TotalBalanceEmi,
                        LoanDate =sharesdata.LoanDate,
                        

                    }); 
                }
                
            }

            // HandLoan Data
            var handlon = (from HandLoan in _context.HandLoans
                           join employee in _context.employees on HandLoan.EmployeeId equals employee.Id
                           where HandLoan.Active == 1
                           select new
                           {
                               Name=employee.Name,
                               HandLoanAmount=HandLoan.HandLoanAmount,
                               Month=HandLoan.Month,
                               Year=HandLoan.Year,
                               Intrest=HandLoan.TotalIntrest,

                           }).ToList();

            if(handlon?.Any()==true)
            {
                foreach(var hl in handlon)
                {
                    sumofhandloancalculation += hl.HandLoanAmount;
                    Listhandloan.Add(new HandLoan()
                    {
                        LoanUserName = hl.Name,
                        HandLoanAmount = hl.HandLoanAmount,
                        Month = hl.Month,
                        Year = hl.Year,
                        TotalIntrest = hl.Intrest
                    });
                   
                }
            }

            //calculating MonthlyRemainingAmount
            
            var BalanceAmount = (from ba in _context.LoanTracks
                                 where ba.Month == currentmonth.ToString("MMM") && ba.Active==1
                                 select new
                                 {
                                     TotalBalanceAmountinPreviousMonth = ba.TotalBalanceAmount
                                 }).FirstOrDefault();

            
            double TotalBalanceAmountinPreviousMonth = BalanceAmount.TotalBalanceAmountinPreviousMonth;

            // Monthly Track List 
            var monthlyTrack = (from mt in _context.LoanTracks
                                where mt.Month == currentmonth.ToString("MMM")
                                select new
                                {
                                    monthlycollectedAmount = mt.MonthlyCollectedAmount,
                                    TotalLoaninMonth = mt.TotalLoan,
                                    TotalBalanaceAmount = mt.TotalBalanceAmount,
                                    Month = mt.Month,
                                    Year = mt.Year,
                                    currentmonthintrest = mt.TotalIntrest,
                                }).FirstOrDefault();

            
                TrackmonthlyLoan.Add(new MonthlyLoanTrack()
                {
                    MonthlyCollectedAmount=monthlyTrack.monthlycollectedAmount,
                    TotalLoan=monthlyTrack.TotalLoaninMonth,
                    TotalBalanceAmount=monthlyTrack.TotalBalanaceAmount,
                    Month=monthlyTrack.Month,
                    Year=monthlyTrack.Year,
                    TotalIntrest=monthlyTrack.currentmonthintrest,
                });


            // group by calculating monthly salary
            IEnumerable<MonthlytotlaLoanCount> calculatemonthly = (IEnumerable<MonthlytotlaLoanCount>)await _loanmonthlyintrest.MonthlyIntrestCalculate();
            //IEnumerable<LoanEmployees> calculatemonthly = (IEnumerable<LoanEmployees>)enumerable;
            IEnumerable<LoanEmployees> calculatemonthlyentityframework = await _loanmonthlyintrest.MonthlyIntrestCalculatebyEntityframework();

            //overall Data Passing into the view Model

            var DashBoradViewModel = new DashBoardViewModel
            {
                loanEmployees = usages,
                TotalSumofLoan = totalsumloan,
                TotalSumofAmount = totalsumloan + monthlyFivehundred + sumofhandloancalculation + TotalBalanceAmountinPreviousMonth,
                handLoans = Listhandloan,
                TotalSumofHandloanAmount = sumofhandloancalculation,
                monthlyLoanTracks = TrackmonthlyLoan,
                GetCurrenctMonth = currentmonth.ToString("MMMM"),
                loanEmployeesmonthlyLoancount = calculatemonthly,
                loanEmployeesmonthlyintrestcalculate = calculatemonthlyentityframework,
                TotalLoanAmount=TLA,

            };

            return View(DashBoradViewModel);



        }
    }
}