#pragma checksum "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\StocksDashBoard\StocksDashBoard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "406852e10716995691b54f76643cd5441ab3983c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StocksDashBoard_StocksDashBoard), @"mvc.1.0.view", @"/Views/StocksDashBoard/StocksDashBoard.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\_ViewImports.cshtml"
using Kudvenkatcorewebapp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\_ViewImports.cshtml"
using Kudvenkatcorewebapp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\_ViewImports.cshtml"
using Kudvenkatcorewebapp.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\_ViewImports.cshtml"
using Kudvenkatcorewebapp.Models.Trade;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\_ViewImports.cshtml"
using Kudvenkatcorewebapp.ViewModels.Trade;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"406852e10716995691b54f76643cd5441ab3983c", @"/Views/StocksDashBoard/StocksDashBoard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5ba9eb9fbf7f890246b7991df0aa86b0dfdac00", @"/Views/_ViewImports.cshtml")]
    public class Views_StocksDashBoard_StocksDashBoard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Kudvenkatcorewebapp.ViewModels.Trade.DashBoardTradeItemsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "5", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "10", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "20", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "50", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "StocksDashBoard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/js/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Loaddashboard.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\StocksDashBoard\StocksDashBoard.cshtml"
  
    ViewData["Title"] = "StocksDashBoard";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    #loader {\r\n        position: fixed;\r\n        left: 0px;\r\n        top: 0px;\r\n        width: 100%;\r\n        height: 100%;\r\n        z-index: 99999;\r\n        background: url(\'../images/Gear.gif\') no-repeat center;\r\n    }\r\n</style>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "406852e10716995691b54f76643cd5441ab3983c8487", async() => {
                WriteLiteral(@"

    <div id=""loader"" style=""display:none;""></div>

    <div style=""background-color:rgb(233,234,237)"">

        <div class=""row m-1 shadow-sm border border-light"">

            <div class=""col-xs-6 col-md-10 m-0"">
                <h3>Total Stocks:<b class=""text-black"">");
#nullable restore
#line 28 "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\StocksDashBoard\StocksDashBoard.cshtml"
                                                  Write(Model.Totalsharecount);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</b></h3>
            </div>
            <div class=""col-xs-6 col-md-2  m-0"">
                <button type=""button"" class=""btn btn-info shadow-sm"" data-toggle=""modal"" data-target=""#myModal"">PROFIT AND LOSS</button>
            </div>
        </div>



        <div class=""row m-1 "">

            <div class=""card col-3 m-0 border-white shadow-sm"">
                <div class=""card-body bg-gradient"">
                    <h6 class=""card-title text-capitalize  text-black"">Total Invested in Zerodha</h6>
");
                WriteLiteral("                    <h4 class=\"card-text text-muted\">Rs:");
#nullable restore
#line 43 "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\StocksDashBoard\StocksDashBoard.cshtml"
                                                   Write(Model.TotalinvestZerodha);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n");
                WriteLiteral(@"                </div>
            </div>

            <div class=""card col-3 m-0 border-white shadow-sm"">
                <div class=""card-body bg-gradient"">
                    <h6 class=""card-title text-capitalize text-black"">Total Invested in Upstox</h6>
");
                WriteLiteral("                    <h4 class=\"card-text text-muted\">Rs:");
#nullable restore
#line 53 "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\StocksDashBoard\StocksDashBoard.cshtml"
                                                   Write(Model.TotalinvestedUpstox);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n");
                WriteLiteral(@"                </div>
            </div>

            <div class=""card col-3  m-0 border-white shadow-sm"">
                <div class=""card-body bg-gradient"">
                    <h6 class=""card-title text-capitalize text-black"">Total Invested in Angel</h6>
");
                WriteLiteral("                    <h4 class=\"card-text text-muted\">Rs:");
#nullable restore
#line 63 "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\StocksDashBoard\StocksDashBoard.cshtml"
                                                   Write(Model.TotalinvestedAngel);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n");
                WriteLiteral(@"                </div>
            </div>

            <div class=""card col-3 m-0 border-white shadow-sm"">
                <div class=""card-body bg-gradient"">
                    <h6 class=""card-title text-capitalize text-black"">Total Invested Amount</h6>
");
                WriteLiteral("                    <h4 class=\"card-text text-muted\">Rs:");
#nullable restore
#line 73 "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\StocksDashBoard\StocksDashBoard.cshtml"
                                                   Write(Model.TotalInvestment);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n");
                WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <br />\r\n\r\n        <div class=\"row bg-white\">\r\n\r\n            <!--<div class=\"col-xs-6 col-md-2 shadow-sm bg-light\">\r\n            <div class=\"card-body bg-light\">-->\r\n");
                WriteLiteral("            <!--</div>\r\n            </div>-->\r\n");
                WriteLiteral("            <div class=\"col-xs-12 col-sm-6 col-md-8 shadow-sm\" style=\" border-color:green\">\r\n                <span>Stock Name:</span><input type=\"text\" name=\"Stockname\"");
                BeginWriteAttribute("class", " class=\"", 4181, "\"", 4189, 0);
                EndWriteAttribute();
                WriteLiteral(@" />

                <input type=""submit"" value=""Search"" class=""btn btn-success"" />
            </div>


            <div class=""col-xs-12 col-sm-6 col-md-8 shadow-sm"" style="" border-color:green"">
                <h3 class=""m-0 bg-success shadow-sm text-white"">
                    List of Stocks

                </h3>
                <table class=""table table-striped text-sm-center font-weight-bold mx-auto m-2"">
                    <thead class=""bg-info text-black"">
                        <tr style=""font-size:medium; font-weight:bold"" class=""table-info"">
                            <th>Broker Name</th>
                            <th>Share Name</th>
                            <th>Buy Price</th>
                            <th>Total Share</th>
                            <th>Total Investment</th>
                            <th>Purchased Date</th>
                        </tr>
                    </thead>
                    <tbody style=""font-size:smaller"" class=""text-sm-center"">
");
#nullable restore
#line 118 "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\StocksDashBoard\StocksDashBoard.cshtml"
                         foreach (var item in Model.tradeinformations)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 121 "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\StocksDashBoard\StocksDashBoard.cshtml"
                               Write(item.BrokerName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 122 "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\StocksDashBoard\StocksDashBoard.cshtml"
                               Write(item.Stockname);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 123 "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\StocksDashBoard\StocksDashBoard.cshtml"
                               Write(item.Stockbuykprice);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 124 "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\StocksDashBoard\StocksDashBoard.cshtml"
                               Write(item.Stocktotalshares);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 125 "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\StocksDashBoard\StocksDashBoard.cshtml"
                               Write(item.TotalInvestedAmount);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 126 "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\StocksDashBoard\StocksDashBoard.cshtml"
                               Write(item.Stockpurchaseddate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 129 "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\StocksDashBoard\StocksDashBoard.cshtml"

                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </tbody>
                </table>
            </div>

            <div class=""col-xs-6 col-md-4 bg-white"">
                <div class=""card-body bg-gradient"">
                    <ul>
                        <li><h6 class=""card-title text-capitalize text-black""> Total Invested In ");
#nullable restore
#line 138 "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\StocksDashBoard\StocksDashBoard.cshtml"
                                                                                            Write(Model.Year);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <b>Rs:");
#nullable restore
#line 138 "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\StocksDashBoard\StocksDashBoard.cshtml"
                                                                                                              Write(Model.TotalinvestAmountInYear);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b> </h6></li>\r\n                    </ul>\r\n");
                WriteLiteral(@"                </div>
            </div>

        </div>

        <br />
        <h3 class=""m-0 bg-success shadow-sm text-white""> List of Stocks</h3>
        <div class=""row"">
            <div class=""md-6"">
                <select id=""stockDropDownList"" name=""stockDropDownList"" class=""form-control select2 select2-hidden-accessible m-4"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "406852e10716995691b54f76643cd5441ab3983c18094", async() => {
                    WriteLiteral("5");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "406852e10716995691b54f76643cd5441ab3983c19333", async() => {
                    WriteLiteral("10");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "406852e10716995691b54f76643cd5441ab3983c20573", async() => {
                    WriteLiteral("20");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "406852e10716995691b54f76643cd5441ab3983c21813", async() => {
                    WriteLiteral("50");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </select>\r\n            </div>\r\n            <div class=\"md-3 \">\r\n                <h4 class=\"m-4 p-2\">Total Records</h4>\r\n            </div>\r\n            <div class=\"md-3\">\r\n                <h4 class=\"m-4 p-2\">");
#nullable restore
#line 164 "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\StocksDashBoard\StocksDashBoard.cshtml"
                               Write(Model.Totaladdedextrastocks);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h4>
            </div>
        </div>

        <table id=""stocktab"" class=""table table-striped text-sm-center font-weight-bold mx-auto m-2"">

            <thead class=""bg-info text-black"">
                <tr style=""font-size:medium; font-weight:bold;"" class=""table-info"">
                    <th>Broker Name</th>
                    <th>Stock Name</th>
                    <th>Buy Price</th>
                    <th>Total Share</th>
                    <th>Total Investment</th>
                    <th>Month</th>
                    <th>Year</th>
                </tr>
            </thead>
            <tbody class=""text-sm-center"" style=""font-size:smaller"">
");
#nullable restore
#line 182 "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\StocksDashBoard\StocksDashBoard.cshtml"
                 foreach (var item in Model.extraQuantityAddedinStocks)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 185 "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\StocksDashBoard\StocksDashBoard.cshtml"
                       Write(item.BrokerName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 186 "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\StocksDashBoard\StocksDashBoard.cshtml"
                       Write(item.StockName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 187 "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\StocksDashBoard\StocksDashBoard.cshtml"
                       Write(item.BuyPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 188 "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\StocksDashBoard\StocksDashBoard.cshtml"
                       Write(item.TotalShare);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 189 "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\StocksDashBoard\StocksDashBoard.cshtml"
                       Write(item.TotalInvestment);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 190 "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\StocksDashBoard\StocksDashBoard.cshtml"
                       Write(item.Month);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 191 "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\StocksDashBoard\StocksDashBoard.cshtml"
                       Write(item.Year);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 194 "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\StocksDashBoard\StocksDashBoard.cshtml"

                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n");
                WriteLiteral(@"        <div class=""modal fade"" id=""myModal"" role=""dialog"">
            <div class=""modal-dialog"">

                <!-- Modal content-->
                <div class=""modal-content"">
                    <div class=""modal-header text-white bg-primary"">
                        <h4 class=""modal-title text-center"">Total Profit and Loss</h4>
                        <button type=""button"" class=""close float-right"" data-dismiss=""modal"">&times;</button>
                    </div>
                    <div class=""modal-body"">
                        <p><h6>Total Profit</h6><h5 class=""text-success"">");
#nullable restore
#line 210 "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\StocksDashBoard\StocksDashBoard.cshtml"
                                                                    Write(Model.Totalprofit);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5></p>\r\n                        <p><h6>Total Loss</h6><h5 class=\"text-danger\">");
#nullable restore
#line 211 "C:\Datta\KudVenkatBackUp\Kudvenkatcorewebapp\Views\StocksDashBoard\StocksDashBoard.cshtml"
                                                                 Write(Model.Totalloss);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h5></p>
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Close</button>
                    </div>
                </div>

            </div>
        </div>
    </div>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "406852e10716995691b54f76643cd5441ab3983c30157", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "406852e10716995691b54f76643cd5441ab3983c31197", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "406852e10716995691b54f76643cd5441ab3983c32237", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "406852e10716995691b54f76643cd5441ab3983c33277", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Kudvenkatcorewebapp.ViewModels.Trade.DashBoardTradeItemsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591