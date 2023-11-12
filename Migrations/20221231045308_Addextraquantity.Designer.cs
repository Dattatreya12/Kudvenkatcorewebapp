﻿// <auto-generated />
using System;
using Kudvenkatcorewebapp.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Kudvenkatcorewebapp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221231045308_Addextraquantity")]
    partial class Addextraquantity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Kudvenkatcorewebapp.DTO.EmployeeDTO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Active")
                        .HasColumnType("int");

                    b.Property<int?>("Department")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InitialName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalInvestedAmount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("EmployeeDTO");
                });

            modelBuilder.Entity("Kudvenkatcorewebapp.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<int?>("CityMasterID")
                        .HasColumnType("int");

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("CityMasterID");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Kudvenkatcorewebapp.Models.CityMaster", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Active")
                        .HasColumnType("int");

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("CityMasters");
                });

            modelBuilder.Entity("Kudvenkatcorewebapp.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Active")
                        .HasColumnType("int");

                    b.Property<int>("Department")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HandLoanID")
                        .HasColumnType("int");

                    b.Property<string>("InitialName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LoanEmployeesId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalInvestedAmount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HandLoanID");

                    b.HasIndex("LoanEmployeesId");

                    b.ToTable("employees");

                    b.HasData(
                        new
                        {
                            Id = 5,
                            Active = 1,
                            Department = 2,
                            Email = "dh@gmail.com",
                            Name = "Dhriti",
                            TotalInvestedAmount = 0
                        });
                });

            modelBuilder.Entity("Kudvenkatcorewebapp.Models.Loan.HandLoan", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Active")
                        .HasColumnType("int");

                    b.Property<int?>("DashBoardViewModelId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<double>("HandLoanAmount")
                        .HasColumnType("float");

                    b.Property<int>("HandLoanId")
                        .HasColumnType("int");

                    b.Property<string>("LoanUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Month")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TotalIntrest")
                        .HasColumnType("float");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("DashBoardViewModelId");

                    b.ToTable("HandLoans");
                });

            modelBuilder.Entity("Kudvenkatcorewebapp.Models.Loan.MonthlyLoanInformation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DashBoardViewModelId")
                        .HasColumnType("int");

                    b.Property<DateTime>("LoanEndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LoanID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Month")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("MonthEmiAmount")
                        .HasColumnType("float");

                    b.Property<int>("TotalPaidEmi")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("DashBoardViewModelId");

                    b.ToTable("MonthlyloanInformation");
                });

            modelBuilder.Entity("Kudvenkatcorewebapp.Models.Loan.MonthlyLoanTrack", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Active")
                        .HasColumnType("int");

                    b.Property<int?>("DashBoardViewModelId")
                        .HasColumnType("int");

                    b.Property<double>("HandLoan")
                        .HasColumnType("float");

                    b.Property<string>("Month")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("MonthlyCollectedAmount")
                        .HasColumnType("float");

                    b.Property<double>("TotalBalanceAmount")
                        .HasColumnType("float");

                    b.Property<double>("TotalIntrest")
                        .HasColumnType("float");

                    b.Property<double>("TotalLoan")
                        .HasColumnType("float");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("DashBoardViewModelId");

                    b.ToTable("LoanTracks");
                });

            modelBuilder.Entity("Kudvenkatcorewebapp.Models.LoanEmployees", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Active")
                        .HasColumnType("int");

                    b.Property<int?>("DashBoardViewModelId")
                        .HasColumnType("int");

                    b.Property<int?>("DashBoardViewModelId1")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("LoanDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LoanID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LoanStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LoanUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TatlBalanceEmi")
                        .HasColumnType("int");

                    b.Property<int>("TotalEmi")
                        .HasColumnType("int");

                    b.Property<double>("TotalIntrest")
                        .HasColumnType("float");

                    b.Property<int>("TotalLoanAmount")
                        .HasColumnType("int");

                    b.Property<int>("TotalPaidEmi")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DashBoardViewModelId");

                    b.HasIndex("DashBoardViewModelId1");

                    b.ToTable("loanEmployees");
                });

            modelBuilder.Entity("Kudvenkatcorewebapp.Models.Trade.Broker", b =>
                {
                    b.Property<int?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Active")
                        .HasColumnType("int");

                    b.Property<string>("BrokerName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("brokers");
                });

            modelBuilder.Entity("Kudvenkatcorewebapp.Models.Trade.ExtraQuantityAddedinStocks", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Active")
                        .HasColumnType("int");

                    b.Property<string>("BrokerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("BuyPrice")
                        .HasColumnType("float");

                    b.Property<string>("Month")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StockName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TotalInvestment")
                        .HasColumnType("float");

                    b.Property<int>("TotalShare")
                        .HasColumnType("int");

                    b.Property<int?>("TradeinformationId")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.Property<int>("brokerid")
                        .HasColumnType("int");

                    b.Property<int>("stockid")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("TradeinformationId");

                    b.HasIndex("brokerid");

                    b.ToTable("ExtraQuantityAddedinStocks");
                });

            modelBuilder.Entity("Kudvenkatcorewebapp.Models.Trade.Total_profit_loss", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Loss")
                        .HasColumnType("float");

                    b.Property<double>("Profit")
                        .HasColumnType("float");

                    b.Property<double>("Totalloss")
                        .HasColumnType("float");

                    b.Property<double>("Totalprofit")
                        .HasColumnType("float");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("TotalProfiLoss");
                });

            modelBuilder.Entity("Kudvenkatcorewebapp.Models.Trade.Tradeinformation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Active")
                        .HasColumnType("int");

                    b.Property<string>("BrokerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Stockbuykprice")
                        .HasColumnType("float");

                    b.Property<string>("Stockname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Stockpurchaseddate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Stockselldate")
                        .HasColumnType("datetime2");

                    b.Property<double>("Stocksellprice")
                        .HasColumnType("float");

                    b.Property<int>("Stocktotalshares")
                        .HasColumnType("int");

                    b.Property<double>("TotalInvestedAmount")
                        .HasColumnType("float");

                    b.Property<double>("TotalProfit")
                        .HasColumnType("float");

                    b.Property<double>("TotlaLoss")
                        .HasColumnType("float");

                    b.Property<int>("brokerid")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("brokerid");

                    b.ToTable("tradeinformations");
                });

            modelBuilder.Entity("Kudvenkatcorewebapp.ViewModels.Sangh.DashBoardViewModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GetCurrenctMonth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LoanDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("TotalIntrest")
                        .HasColumnType("float");

                    b.Property<double>("TotalSumofAmount")
                        .HasColumnType("float");

                    b.Property<double>("TotalSumofHandloanAmount")
                        .HasColumnType("float");

                    b.Property<double>("TotalSumofLoan")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("DashBoardViewModel");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Kudvenkatcorewebapp.Models.ApplicationUser", b =>
                {
                    b.HasOne("Kudvenkatcorewebapp.Models.CityMaster", null)
                        .WithMany("applicationUsers")
                        .HasForeignKey("CityMasterID");
                });

            modelBuilder.Entity("Kudvenkatcorewebapp.Models.Employee", b =>
                {
                    b.HasOne("Kudvenkatcorewebapp.Models.Loan.HandLoan", null)
                        .WithMany("employeesname")
                        .HasForeignKey("HandLoanID");

                    b.HasOne("Kudvenkatcorewebapp.Models.LoanEmployees", null)
                        .WithMany("employeesname")
                        .HasForeignKey("LoanEmployeesId");
                });

            modelBuilder.Entity("Kudvenkatcorewebapp.Models.Loan.HandLoan", b =>
                {
                    b.HasOne("Kudvenkatcorewebapp.ViewModels.Sangh.DashBoardViewModel", null)
                        .WithMany("handLoans")
                        .HasForeignKey("DashBoardViewModelId");
                });

            modelBuilder.Entity("Kudvenkatcorewebapp.Models.Loan.MonthlyLoanInformation", b =>
                {
                    b.HasOne("Kudvenkatcorewebapp.ViewModels.Sangh.DashBoardViewModel", null)
                        .WithMany("monthlyLoanInformation")
                        .HasForeignKey("DashBoardViewModelId");
                });

            modelBuilder.Entity("Kudvenkatcorewebapp.Models.Loan.MonthlyLoanTrack", b =>
                {
                    b.HasOne("Kudvenkatcorewebapp.ViewModels.Sangh.DashBoardViewModel", null)
                        .WithMany("monthlyLoanTracks")
                        .HasForeignKey("DashBoardViewModelId");
                });

            modelBuilder.Entity("Kudvenkatcorewebapp.Models.LoanEmployees", b =>
                {
                    b.HasOne("Kudvenkatcorewebapp.ViewModels.Sangh.DashBoardViewModel", null)
                        .WithMany("loanEmployees")
                        .HasForeignKey("DashBoardViewModelId");

                    b.HasOne("Kudvenkatcorewebapp.ViewModels.Sangh.DashBoardViewModel", null)
                        .WithMany("loanEmployeesmonthlyintrestcalculate")
                        .HasForeignKey("DashBoardViewModelId1");
                });

            modelBuilder.Entity("Kudvenkatcorewebapp.Models.Trade.ExtraQuantityAddedinStocks", b =>
                {
                    b.HasOne("Kudvenkatcorewebapp.Models.Trade.Tradeinformation", null)
                        .WithMany("extraQuantityAddedinStocks")
                        .HasForeignKey("TradeinformationId");

                    b.HasOne("Kudvenkatcorewebapp.Models.Trade.Broker", null)
                        .WithMany("extraQuantityAddedinStocks")
                        .HasForeignKey("brokerid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Kudvenkatcorewebapp.Models.Trade.Tradeinformation", b =>
                {
                    b.HasOne("Kudvenkatcorewebapp.Models.Trade.Broker", null)
                        .WithMany("tradeinformations")
                        .HasForeignKey("brokerid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Kudvenkatcorewebapp.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Kudvenkatcorewebapp.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Kudvenkatcorewebapp.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Kudvenkatcorewebapp.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
