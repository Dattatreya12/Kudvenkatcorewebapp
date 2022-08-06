using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kudvenkatcorewebapp.Models;
using Kudvenkatcorewebapp.Models.Loan;
using Kudvenkatcorewebapp.Models.Trade;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Kudvenkatcorewebapp.ViewModels.Sangh;
namespace Kudvenkatcorewebapp.DBContext
{
    public class AppDbContext:IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Employee> employees { get;  set; }
        public DbSet<CityMaster> CityMasters { get; private set; }
        public DbSet<Broker> brokers { get; set; }
        public DbSet<Tradeinformation> tradeinformations { get; set; }
        public DbSet<LoanEmployees> loanEmployees { get; set; }
        public DbSet<MonthlyLoanInformation> MonthlyloanInformation { get; set; }
        public DbSet<HandLoan> HandLoans { get; set; }
        public DbSet<ExtraQuantityAddedinStocks> ExtraQuantityAddedinStocks { get; set; }
        public DbSet<MonthlyLoanTrack> LoanTracks { get; set; }
        public DbSet<Total_profit_loss> TotalProfiLoss { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.seed();
        }

        public DbSet<Kudvenkatcorewebapp.ViewModels.Sangh.DashBoardViewModel> DashBoardViewModel { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
