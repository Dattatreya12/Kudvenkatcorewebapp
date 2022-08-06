using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kudvenkatcorewebapp.DBContext;
using Kudvenkatcorewebapp.Helpers;
using Kudvenkatcorewebapp.Models;
using Kudvenkatcorewebapp.Models.Loan;
using Kudvenkatcorewebapp.Repository;
using Kudvenkatcorewebapp.Repository.LoanRepository;
using Kudvenkatcorewebapp.Repository.Trade;
using Kudvenkatcorewebapp.Repository.Trade.ImplementedRepo;
using Kudvenkatcorewebapp.Repository.Trade.InterfaceRepo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json.Serialization;
using Kudvenkatcorewebapp.Extensions;
using Kudvenkatcorewebapp.CustonMiddleware;

namespace Kudvenkatcorewebapp
{
    public class Startup
    {
        private IConfiguration _configuration { get; }
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

       

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<AppDbContext>(options => options.UseSqlServer(_configuration.GetConnectionString("Default")));
          

            services.AddControllersWithViews().AddNewtonsoftJson(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver());
            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 10;
                options.Password.RequiredUniqueChars = 4;

            }
                ).AddEntityFrameworkStores<AppDbContext>();
            services.AddMvc();

            //services.AddMvc(options =>
            //{
            //    var policy = new AuthorizationPolicyBuilder()
            //                    .RequireAuthenticatedUser()
            //                    .Build();
            //    options.Filters.Add(new AuthorizeFilter(policy));
            //}).AddXmlSerializerFormatters();

            //Claim Policy
            services.AddAuthorization(options =>
            {
                options.AddPolicy("DeleteRolePolicy", policy => policy.RequireClaim("Delete Role"));
            });

            //Role Policy

            services.AddAuthorization(options =>
            {
                options.AddPolicy("AddAdminPolicy", policy => policy.RequireRole("Admin"));
            });

            services.AddControllersWithViews ();
            services.AddAutoMapper(typeof(Startup));
            services.AddScoped<Icity, CityRepository>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IBrokerRepository, BrokerRepository>();
            services.AddScoped<ITradeshare, SharetradeRepository>();
            services.AddScoped<IloanCrudService, LoanCrudService>();
            services.AddScoped<IloanCrud, LoanCrudRepository>();
            services.AddScoped<IextraStocks, ExtrastocksRepp>();
            services.AddScoped<IProfitLoss, ProfitAndLossRepo>();
            services.AddScoped<ILoanmonthlyintrestcalculate, LoanMonthlyIntrestrepo>();
            services.AddCloudscribePagination();


            
            //services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //if (env.IsDevelopment())
            //{
            //    //app.UseStatusCodePagesWithReExecute("/Error/{0}");  // This is already commeneted code
            //    app.UseDeveloperExceptionPage();


            //}
            //else
            //{
            //    app.UseExceptionHandler("/Home/Error");
            //    // This below caode already commented code
            //    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            //    app.UseHsts();
            //}


            app.ConfigureExceptionHandler(env);
            //app.UseMiddleware<ExceptinMiddleware>();
            

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            // app.UseMvcWithDefaultRoute();



            //working
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Presentation}/{action=Index}/{id?}");
            });


        }
    }
}
